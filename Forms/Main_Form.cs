﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using HariOmImpex_LMS.Forms;
using HariOmImpex_LMS.Globals_Variables;
using HariOmImpex_LMS.Properties;
using Spire.Xls;
using Transitions;
using Excels = Microsoft.Office.Interop.Excel;



namespace HariOmImpex_LMS
{
    public partial class Form1 : Form
    {
        private List<Control> control_list;
        private string query;
        private string todaysdate;
        private string search_text;
        private DataTable table;
        private bool refreshing;
        private bool data_updated;
        private DataSet today_reminder;
        private DataSet upcoming_reminder;
        private bool chnanged;
		private SQLiteDataAdapter dataAdapter;
        private string query_builder_text;
        private DataSet query_builder_dataset;
        private string filename;
		private Shortcuts_form shortcuts_List;
		SoundPlayer audio = new SoundPlayer();
		bool played = false;

		public Form1()
        {
			//ConsoleApp2.Program
            InitializeComponent();

            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;

			//global_vars.hide_rem_window = false;
			control_list = new List<Control>();
			foreach (Control control in base.Controls)
			{
				control_list.Add(control);
			}
			control_list.Add(contextMenuStrip1);
			control_list.Add(contextMenuStrip2);
			control_list.Add(contextMenuStrip3);
			control_list.Add(menuStrip2);
			control_list.Add(menuStrip4);
			control_list.Add(toolStrip1);
			control_list.Add(comboBox1.ComboBox);
			control_list.Add(textBox1.TextBox);
			if (Settings.Default.ui_size == 1)
			{
				global_functions.ui_size_1(control_list);
				global_functions.Entry_log(0, "UI_size set to 1","");
			}



			string notif_name = "notif_sound_" + Properties.Settings.Default.selected_notif_sound.ToString();

            switch (Properties.Settings.Default.selected_notif_sound)
            {
                case 0:
                    {
                        audio.Stream = Properties.Resources.notif_sound_0;
                    }
                    break;

                case 1:
                    {
                        audio.Stream = Properties.Resources.notif_sound_1;
                    }
                    break;
				case 2:
					{
						audio.Stream = Properties.Resources.notif_sound_2;
					}
					break;

				case 3:
					{
						audio.Stream = Properties.Resources.notif_sound_3;
					}
					break;
				case 4:
					{
						audio.Stream = Properties.Resources.notif_sound_4;
					}
					break;
				case 5:
					{
						audio.Stream = Properties.Resources.notif_sound_5;
					}
					break;
			}


			global_functions.Entry_log(0, "audio stream configured.","");

			if (Properties.Settings.Default.save_mode == 0)
			{
				commit_button.Enabled = false;
			}
			else if (Properties.Settings.Default.save_mode == 1)
			{
				commit_button.Enabled = true;
			}

		
		


		}

		private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

				if (Properties.Settings.Default.save_mode == 0)
				{
					commit_button.Enabled = false;
				}
				else if(Properties.Settings.Default.save_mode == 1)
				{
					commit_button.Enabled = true;
				}
        }

        private void get_column_names()
		{
			
			comboBox1.Items.Clear();
			try
			{
				SQLiteConnection connection = new SQLiteConnection();
				connection.ConnectionString = "Data Source=" + global_vars.getDatabasePath();
				connection.Open();
				SQLiteDataReader reader = new SQLiteCommand("select * from client_data", connection).ExecuteReader();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					comboBox1.Items.Add(reader.GetName(i));

					if (!autocompleteMenu1.Items.Contains(reader.GetName(i)))
					{
						autocompleteMenu1.AddItem(reader.GetName(i));
					}
					
				}
				connection.Close();
				global_functions.Entry_log(0, "get_column_names - success","");

			}
			catch(Exception exception)
			{
				global_functions.Entry_log(1, "get_column_names - " + exception.Message, exception.StackTrace);
			}
		}

		private void queryBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (!splitContainer3.Panel2Collapsed)
			{
				splitContainer3.Panel2Collapsed = true;
				reloadDatabaseToolStripMenuItem.Enabled = true;

				if(Access_points_vars.do_mce)
                {
					edit_mode_button.Enabled = true;
					client_basic_datagrid.ReadOnly = false;
				}
				

				global_functions.Entry_log(0, "query_builder panel collapsed = true", "");
			}
			else
			{
				if (!splitContainer3.Panel2Collapsed)
				{
					return;
				}
				splitContainer3.Panel2Collapsed = false;
				edit_mode_button.Enabled = false;
				reloadDatabaseToolStripMenuItem.Enabled = false;
				client_basic_datagrid.ReadOnly = true;
				load_queries();
				global_functions.Entry_log(0, "query_builder panel collapsed = false", "");
			}
		}

        private void toggleSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			if (splitContainer2.Panel1Collapsed)
			{
				splitContainer2.Panel1Collapsed = false;
				comboBox1.Focus();
				global_functions.Entry_log(0, "search_panel collapsed = false", "");
			}
			else
			{
				splitContainer2.Panel1Collapsed = true;
				global_functions.Entry_log(0, "search_panel collapsed = true", "");
			}
		}

        private void backupManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
			new Backup_manager_form().ShowDialog(this);
			global_functions.Entry_log(0, "Backup_manager opened", "");
		}

        private void aboutApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
			new About_form().ShowDialog();
			global_functions.Entry_log(0, "about_form opened", "");
		}

        private void add_user_btn_Click(object sender, EventArgs e)
        {
			if (client_basic_datagrid.Rows.Count > 0)
			{
				new Add_new_client_form().ShowDialog();
				global_functions.Entry_log(0, "add_new_client form opened", "");
			}
		}


        private void edit_mode_button_Click(object sender, EventArgs e)
        {
			if (client_basic_datagrid.Rows.Count > 0)
			{
				if (!client_basic_datagrid.ReadOnly)
				{
					client_basic_datagrid.ReadOnly = true;
					edit_mode_button.Text = "Edit mode (Off)";
					edit_mode_button.BackColor = Color.IndianRed;
				//	add_user_btn.Enabled = false;
					global_functions.Entry_log(0, "edit_mode = false", "");
				}
				else
				{
					client_basic_datagrid.ReadOnly = false;
					edit_mode_button.Text = "Edit mode (On)";
					edit_mode_button.BackColor = Color.GreenYellow;
				//	add_user_btn.Enabled = true;
					global_functions.Entry_log(0, "edit_mode = true", "");
				}
			}
		}

		public int fromidx = 0;
		public int numrows = 100;

		bool first_load = true;
		private void load_all_data()
		{
			global_functions.Entry_log(0, "load_all_data - start", "");

			get_column_names();

			if (first_load)
			{
				query = "select * from client_data limit " + fromidx + ", " + numrows + ";";
			}
				load_database();

			if (first_load)
			{
				fromidx += 100;
			}
			
			    first_load = false;

		}

        private void load_reminders()
        {
            global_functions.Entry_log(0, "load_reminders - start", "");
            //today_rem_datagrid.DataSource = null;
            //upcoming_rem_datagrid.DataSource = null;
            if (!get_reminders.IsBusy && check_connected())
            {
                loading_box.Visible = true;
                get_reminders.RunWorkerAsync();
            }
        }

        public static bool CheckForInternetConnection()
		{
			try
			{
                WebClient webClient = new WebClient();
				using (webClient.OpenRead("http://google.com/generate_204"))
				{
					return true;
				}
			}
			catch
			{
				return false;
			}
		}

		public bool check_connected()
		{
			set_status("Checking connection. Please wait..");
			bool result;
			if (CheckForInternetConnection() && File.Exists(global_vars.getDatabasePath()))
			{
				sts_txt.Text = "Connection established.";
				result = true;
			}
			else
			{
				result = false;
				sts_txt.Text = "Computer is not connected to the internet. Please check your network connectivity and try again.";
			}
			return result;
		}

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (comboBox1.Text == "" || comboBox1.Text == null)
			{
				textBox1.ReadOnly = true;
			}
			else
			{
				textBox1.ReadOnly = false;
			}
		}

		private void set_status(string mess)
		{
			sts_txt.Text = mess;
		}

        private void button2_Click(object sender, EventArgs e)
        {

			if (tabControl1.SelectedTab == tabPage1)
			{
				if (File.Exists(global_vars.getDatabasePath()))
				{
					if (!get_data.IsBusy)
					{
						query = "select * from client_data where " + comboBox1.SelectedItem?.ToString() + " like '%" + textBox1.Text + "%';";
						loading_box.Visible = true;
						load_database();
					}
					else
					{
						get_data.CancelAsync();
						loading_box.Visible = false;
						sts_txt.Text = "Already fetching data.. Please search again..";
					}
				}
				else
				{
					sts_txt.Text = "Network path unavailable. Please check if computer is connected to internet.";
				}
			}

		    if(tabControl1.SelectedTab==tabPage2)
			{
				if (string.IsNullOrEmpty(textBox1.Text))
				{
					(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
				}
				else
				{
					var Rowfilter = string.Format("CONVERT([{0}], System.String) like '%{1}%'",
							 comboBox1.Text.Trim(), textBox1.Text.Trim());
					(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = Rowfilter;
				}
			}


			
		}

		private void load_database()
		{
			try
			{
				if (!get_data.IsBusy)
				{
					loading_box.Visible = true;
					if (File.Exists(global_vars.getDatabasePath()))
					{
						client_basic_datagrid.DataSource = null;
						fileSystemWatcher1.Path = Path.GetDirectoryName(global_vars.getDatabasePath());
						fileSystemWatcher1.NotifyFilter = NotifyFilters.LastWrite;
						fileSystemWatcher1.EnableRaisingEvents = true;
						get_data.RunWorkerAsync();
					}
				}
			}
			catch(Exception exception)
			{
				global_functions.Entry_log(1, "load_databse - "+exception.Message, exception.StackTrace);

			}
		}

		private void create_backup()
		{
			global_functions.Entry_log(0, "create_backup - started", "");
			loading_box.Visible = true;
			sts_txt.Text = "Creating backup.. Please wait..";
			if (!create_backup_worker.IsBusy)
			{
				create_backup_worker.RunWorkerAsync();
			}
		}

		private DataTable ReadExcelFile(string sheetName, string path)
		{

			using (OleDbConnection conn = new OleDbConnection())
			{
				DataTable dt = new DataTable();
				string Import_FileName = path;
				string fileExtension = Path.GetExtension(Import_FileName);
				if (fileExtension == ".xls")
					conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
				if (fileExtension == ".xlsx")
					conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
				using (OleDbCommand comm = new OleDbCommand())
				{
					comm.CommandText = "Select * from [" + sheetName + "$]";
					comm.Connection = conn;
					using (OleDbDataAdapter da = new OleDbDataAdapter())
					{
						da.SelectCommand = comm;
						da.Fill(dt);
						return dt;
					}
				}
			}
		}

		public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
		{
			Hashtable hTable = new Hashtable();
			ArrayList duplicateList = new ArrayList();

			//Add list of all the unique item value to hashtable, which stores combination of key, value pair.
			//And add duplicate item value in arraylist.
			foreach (DataRow drow in dTable.Rows)
			{
				if (hTable.Contains(drow[colName]))
					duplicateList.Add(drow);
				else
					hTable.Add(drow[colName], string.Empty);
			}

			//Removing a list of duplicate items from datatable.
			foreach (DataRow dRow in duplicateList)
				dTable.Rows.Remove(dRow);

			//Datatable which contains unique records will be return as output.
			return dTable;
		}



		Import_data_form import_Data_Form;

		private void Form1_Load(object sender, EventArgs e)
        {
			splitContainer6.Panel1Collapsed = true;

            queryBuilderToolStripMenuItem.Text = "Query\nBuilder";
            backupManagerToolStripMenuItem.Text = "Backup\nManager";
            applicationLogToolStripMenuItem.Text = "Activity\nLog";
			login_console.Text = "Admin\nConsole";

            import_Data_Form = new Import_data_form();
            import_Data_Form.Show();
            import_Data_Form.Hide();



            digi_time.Start();

			if (!File.Exists(global_vars.getDatabasePath()))
			{
				new Settings_form().ShowDialog();
			}

			new Login_form().ShowDialog();
			set_access_mode();
			
			shortcuts_List = new Shortcuts_form();
			if (Settings.Default.backup_time == 1 && Settings.Default.oper_mode == 0)
			{
				create_backup();
			}

			client_basic_datagrid.DoubleBuffered(setting: true);
			splitContainer2.Panel1Collapsed = true;
			main_splitcontainer.Panel2Collapsed = true;
			splitContainer5.Panel1Collapsed = true;

			global_vars.ispanelcollapsed = main_splitcontainer.Panel2Collapsed;

			
			todaysdate = DateTime.Now.ToLongDateString();
			get_column_names();
			load_reminders();
			load_queries();
			if (Settings.Default.load_data_startup && check_connected())
			{
				load_all_data();
			}

			timer1.Start();
			timer2.Start();
			check_reminders.Start();
			check_queries.Start();

			
			//List<string> notes = new List<string>();
			//notes.Add("1) this is a big note man.");
			//notes.Add("2) this is a big note man.");
			//notes.Add("3) this is a big note man.");

			//foreach(string note in notes)
			//{
				


           // }
		}

		private void set_access_mode()
		{

			backupManagerToolStripMenuItem.Enabled = Access_points_vars.af_bm;
			deleteSelectedToolStripMenuItem.Enabled = Access_points_vars.do_dce;
			settingsToolStripMenuItem.Enabled = Access_points_vars.af_set;
			applicationLogToolStripMenuItem.Enabled = Access_points_vars.af_al;
			queryBuilderToolStripMenuItem.Enabled = Access_points_vars.af_qb;
			login_console.Enabled = Access_points_vars.af_ad;
			exportCurrentViewToolStripMenuItem.Enabled = Access_points_vars.do_ecd;
			add_user_btn.Enabled = Access_points_vars.do_anc;
			edit_mode_button.Enabled = Access_points_vars.do_mce;



			//string text = "";
			//switch (Settings.Default.oper_mode)
			//{
			//	case 0:
			//		edit_mode_button.Enabled = true;
			//		backupManagerToolStripMenuItem.Enabled = true;
			//		//accessModeToolStripMenuItem.BackColor = Color.LightSteelBlue;
			//		text = "Access Mode: admin";
			//		break;
			//	case 1:
			//		edit_mode_button.Enabled = true;
			//		deleteSelectedToolStripMenuItem.Enabled = false;
			//		backupManagerToolStripMenuItem.Enabled = false;
			//		//accessModeToolStripMenuItem.BackColor = Color.LimeGreen;
			//		queryBuilderToolStripMenuItem.Enabled = true;
			//		text = "Access Mode: user";
			//		break;
			//	case 2:
			//		edit_mode_button.Enabled = false;
			//		settingsToolStripMenuItem.Enabled = false;
			//		contextMenuStrip2.Enabled = false;
			//		contextMenuStrip2.Enabled = false;
			//		contextMenuStrip1.Enabled = false;
			//		backupManagerToolStripMenuItem.Enabled = false;
			//		queryBuilderToolStripMenuItem.Enabled = false;
			//		//accessModeToolStripMenuItem.BackColor = Color.DarkGoldenrod;
			//		text = "Access Mode: view";
			//		break;
			//}
			//accessModeToolStripMenuItem.Text = text;
			global_functions.Entry_log(0, "set_access_mode - success", "");
		}

		public void get_count()
		{
			if (client_basic_datagrid.Rows.Count > 0)
			{
				int count = client_basic_datagrid.Rows.Count;
				sts_txt.Text = "Database loaded. Total Clients: " + count;
			}
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
			if (global_vars.reminder_added)
			{
				load_reminders();
				global_vars.reminder_added = false;
			}
		}

		private void delete_reminder(DataGridView grid)
		{
			if (MessageBox.Show("Delete selected reminder?\nThis cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					global_functions.execute_command("delete from reminder_data where ID = " + grid.SelectedRows[0].Cells[0].Value?.ToString() + ";");
					load_reminders();
					global_functions.Entry_log(0, "delete_reminder (global_functions.execute_command) - success", "");
				}
				catch (Exception exception)
				{
					global_functions.Entry_log(1, "delete_reminder (global_functions.execute_command) - " + exception.Message, exception.StackTrace);

				}
			}
		}

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (!client_basic_datagrid.ReadOnly && MessageBox.Show("Delete selected entry?\nThis cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					global_functions.execute_command("delete from client_data where ID = " + client_basic_datagrid.SelectedRows[0].Cells[0].Value?.ToString() + ";");
					client_basic_datagrid.Rows.RemoveAt(client_basic_datagrid.SelectedRows[0].Index);
					global_functions.Entry_log(0, "delete_client_entry (global_functions.execute_command) - success", "");
				}
				catch(Exception exception)
				{
					global_functions.Entry_log(1, "delete_client_entry (global_functions.execute_command) - "+ exception.Message, exception.StackTrace);

				}
			}
		}

        private void textBox1_Click(object sender, EventArgs e)
        {
			
		}

		private void copy_data_to_clipboard(string text)
		{
			Clipboard.SetText(text);
			sts_txt.Text = text + " copied to clipboard.";

			global_functions.Entry_log(0, "clipboard_settext - success", "");
		}

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			new Settings_form().ShowDialog();
			global_functions.Entry_log(0, "settings_form opened - success", "");
		}

		private void get_data_DoWork(object sender, DoWorkEventArgs e)
		{
			if (query == null || !(query != ""))
			{
				return;
			}
			try
			{
				var connection = new SQLiteConnection();
				connection.ConnectionString = "Data Source=" + global_vars.getDatabasePath();
				connection.Open();
				dataAdapter = new SQLiteDataAdapter(query, connection);
				SQLiteCommandBuilder cb = new SQLiteCommandBuilder(dataAdapter);

				//dataAdapter.DeleteCommand = cb.GetDeleteCommand(true);
				//dataAdapter.UpdateCommand = cb.GetUpdateCommand(true);
				//dataAdapter.InsertCommand = cb.GetInsertCommand(true);

				connection.Close();
				table = new DataTable();
				dataAdapter.Fill(table);

			}
			catch (Exception ex)
			{
				table.Dispose();
				global_functions.Entry_log(1, "get_data_dowork - " + ex.Message, ex.StackTrace);
			}
		}

        private void get_data_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			refreshing = true;
			bindingSource1.DataSource = table;
			client_basic_datagrid.DataSource = bindingSource1;
			//client_basic_datagrid.Columns[0].Visible = false;
			//client_basic_datagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			//
			//OrderColumns();
			refreshing = false;
			loading_box.Visible = false;
			get_count();

			nextToolStripMenuItem1.Enabled = true;
			previousToolStripMenuItem.Enabled = true;

			global_functions.Entry_log(0, "get_data_dowork - success", "");
		}


		
        private void timer2_Tick(object sender, EventArgs e)
        {
			if (data_updated)
			{
				load_database();
				data_updated = false;
			}
		}

        private void get_reminders_DoWork(object sender, DoWorkEventArgs e)
        {
			try
			{
				today_reminder = new DataSet();
				today_reminder = global_functions.load_SQLiteData("select * from reminder_data where date like '%" + todaysdate + "%';");
				upcoming_reminder = new DataSet();
				upcoming_reminder = global_functions.load_SQLiteData("select * from reminder_data;");
			}
			catch(Exception ex)
			{
				get_reminders.CancelAsync();
				get_reminders.Dispose();
				global_functions.Entry_log(1, "get_reminders_dowork - " + ex.Message, ex.StackTrace);
			}
		}

        private void get_reminders_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			try
			{
				loading_box.Visible = false;
				//today_rem_datagrid.DataSource = today_reminder.Tables[0].DefaultView;
				//upcoming_rem_datagrid.DataSource = upcoming_reminder.Tables[0].DefaultView;
				global_vars.reminders = today_reminder.Tables[0].Rows.Count;

				if (global_vars.reminders > 0)
				{
					//Transition.run(active_remiders, "BackColor", Color.Khaki, new TransitionType_Flash(999999, 99999));
					
					reminder_pane_visiblechanged();
				}
				else
				{
					//active_remiders.Text = "Reminders";
				}

				today_reminder.Dispose();
				upcoming_reminder.Dispose();

				global_functions.Entry_log(0, "get_reminders_workcompleted - success", "");
			}

			catch(Exception exc)
			{
				global_functions.Entry_log(1, "get_reminders_workcompleted" + exc.Message, exc.StackTrace);
			}
		}

        private void check_connectivity_DoWork(object sender, DoWorkEventArgs e)
        {
			
		}

        private void check_connectivity_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			//if (Settings.Default.load_data_startup)
			//{
			//	load_reminders();
			//}
		}


		


		void reminder_pane_visiblechanged()
		{

			if (splitContainer5.Panel1Collapsed)
			{
				splitContainer5.Panel1Collapsed = false;
				if (!global_vars.mute_audio && played == false)
				{
					audio.Stop();
					audio.Play();
					played = true;
					Transition.run(panel6, "BackColor", Color.Khaki, new TransitionType_Flash(10,1000));

					//Transition.run(active_remiders, "BackColor", Color.Khaki, new TransitionType_Flash(10, 1000));
					active_remiders.Text = "Reminders\n(" + global_vars.reminders.ToString() +" active)";
				}
			}
			else
			{
				played = false;
			}

			global_functions.Entry_log(0, "reminder_pane_visiblechanged - success","");

		}
        private void check_reminders_Tick(object sender, EventArgs e)
        {
			if (global_vars.reminders > 0)
			{
				reminder_pane_visiblechanged();
			}
			//else
			//{
			//	load_reminders();
			//}
		}

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
			
		}

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
			if (query != "" || query != null)
			{
				data_updated = true;
			}
		}

        private void copyCellValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string text = client_basic_datagrid.CurrentCell.Value.ToString();
			Clipboard.Clear();
			Clipboard.SetText(text);
			sts_txt.Text = text + " copied to clipboard.";
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
			float size = client_basic_datagrid.DefaultCellStyle.Font.Size;
			client_basic_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", size + 2f);
			client_basic_datagrid.DefaultCellStyle.Font = new Font("Calibri", size + 2f);
		}

        private void decrease_font_btn_Click(object sender, EventArgs e)
        {
			float size = client_basic_datagrid.DefaultCellStyle.Font.Size;
			client_basic_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", size - 2f);
			client_basic_datagrid.DefaultCellStyle.Font = new Font("Calibri", size - 2f);
		}

        private void client_basic_datagrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
			chnanged = true;
		}

        private void update_query_DoWork(object sender, DoWorkEventArgs e)
        {

			try
			{
				var source = ((DataTable)bindingSource1.DataSource);
				update_query.ReportProgress(0, source);
			}
			catch(Exception ex)
			{
				update_query.CancelAsync();
				global_functions.Entry_log(1, "update_query - " + ex.Message, ex.StackTrace);
			}

		}

        private void update_query_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

				Loding_form loading = new Loding_form();
				loading.CloseAfterDelay(2000);
				loading.ShowDialog();

			//commitChangesToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
			//commitChangesToolStripMenuItem.Text = "Commit changes";

			set_status("Row updated..");
			chnanged = false;

			global_functions.Entry_log(0, "update_query - success", "");


		}

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
			//if (today_rem_datagrid.Rows.Count > 0 && Settings.Default.oper_mode != 2)
			//{
			//	contextMenuStrip2.Enabled = true;
			//}
			//else
			//{
			//	contextMenuStrip2.Enabled = false;
			//}
		}

        private void deleteSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			//delete_reminder(today_rem_datagrid);
		}

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
			//delete_reminder(upcoming_rem_datagrid);
		}

        private void active_remiders_Click(object sender, EventArgs e)
        {
			new Reminder_window_form().ShowDialog(this);
			//if (main_splitcontainer.Panel2Collapsed)
			//{
			//	main_splitcontainer.Panel2Collapsed = false;

			//	load_reminders();

			//	if (global_vars.reminders > 0)
			//	{
			//		Transition.run(groupBox3, "BackColor", Color.Khaki, new TransitionType_Flash(999999, 99999));
			//	}

			//		global_functions.Entry_log(0, "Reminders panel collapsed = false", "");
			//}
			//else
			//{
			//	main_splitcontainer.Panel2Collapsed = true;
			//	global_functions.Entry_log(0, "Reminders panel collapsed = true", "");

			//}
			//global_vars.ispanelcollapsed = main_splitcontainer.Panel2Collapsed;
		}

        private void executeCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (File.Exists(global_vars.getDatabasePath()))
			{
				global_functions.Entry_log(0, "query_builder (execute_query) - started", "");
				query_builder_text = textBox2.Text;
				if (!query_builder_text.Contains("delete", StringComparison.OrdinalIgnoreCase))
				{
					query_ststxt.Text = "Executing query..";
					client_basic_datagrid.DataSource = null;
					query_builder_worker.RunWorkerAsync();
				}
			}
			else
			{
				sts_txt.Text = "Query cannot be executed. Database not found..";
			}
		}

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
			textBox2.Clear();
		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
			if (Settings.Default.oper_mode != 0 && textBox2.Text.Contains("delete", StringComparison.OrdinalIgnoreCase))
			{
				query_ststxt.Text = "You are not authorised to execute delete queries..";
				textBox2.Clear();
			}
		}

        private void query_builder_worker_DoWork(object sender, DoWorkEventArgs e)
        {
			try
			{
				query_builder_dataset = new DataSet();
				query_builder_dataset = global_functions.load_SQLiteData(query_builder_text);

				
			}
			catch(Exception ex)
			{
				global_functions.Entry_log(1, "query_builder_worker - " +  ex.Message, ex.StackTrace);
			}
		}

        private void query_builder_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			if (query_builder_dataset.Tables.Count > 0)
			{
				client_basic_datagrid.DataSource = query_builder_dataset.Tables[0].DefaultView;
			}
			query_ststxt.Text = "Query successfully executed..";
			global_functions.Entry_log(0, "query_builder_worker - success", "");
		}

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.Control && e.KeyCode == Keys.Return && sender != null)
			{
				executeCommandToolStripMenuItem_Click(null, null);
				e.Handled = true;
			}
		}

        private void saveCurrentQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (textBox2.Text != null && textBox2.Text != "")
			{
				New_query_form save_Query = new New_query_form();
				save_Query.textBox2.Text = textBox2.Text;
				save_Query.ShowDialog();
				global_functions.Entry_log(0, "save_query_form opened", "");
			}
		}

        private void exportCurrentViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (client_basic_datagrid.DataSource != null && client_basic_datagrid.Rows.Count > 0)
			{
				saveFileDialog1.ShowDialog();
			}
		}

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
			StringBuilder stringBuilder = new StringBuilder();
			IEnumerable<DataGridViewColumn> source = client_basic_datagrid.Columns.Cast<DataGridViewColumn>();
			stringBuilder.AppendLine(string.Join(",", source.Select((DataGridViewColumn column) => "\"" + column.HeaderText + "\"").ToArray()));
			foreach (DataGridViewRow item in client_basic_datagrid.Rows)
			{
				IEnumerable<DataGridViewCell> source2 = item.Cells.Cast<DataGridViewCell>();
				stringBuilder.AppendLine(string.Join(",", source2.Select((DataGridViewCell cell) => "\"" + cell.Value?.ToString() + "\"").ToArray()));
			}
			File.AppendAllText(saveFileDialog1.FileName, stringBuilder.ToString());
			global_functions.Entry_log(0, "export_current_view - success", "");
		}

        private void create_backup_worker_DoWork(object sender, DoWorkEventArgs e)
        {
			try
			{
				filename = Settings.Default.backup_path + "/backup_" + DateTime.Now.ToLongDateString() + "_" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + ".db";
				File.Copy(global_vars.getDatabasePath(), filename);
			}
			catch (Exception ex)
			{
				global_functions.Entry_log(1, "create_back_worker -" + ex.Message, ex.StackTrace);

			}
		}

        private void create_backup_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			loading_box.Visible = false;
			FileInfo fileInfo = new FileInfo(filename);
			sts_txt.Text = "Backup " + fileInfo.Name + " created.";
			MessageBox.Show("Backup " + fileInfo.Name + " created.", "Backup creation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

			global_functions.Entry_log(0, "create_backup_worker - success", "");
		}

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
			//if (upcoming_rem_datagrid.Rows.Count > 0 && Settings.Default.oper_mode != 2)
			//{
			//	contextMenuStrip3.Enabled = true;
			//}
			//else
			//{
			//	contextMenuStrip3.Enabled = false;
			//}
		}

        private void client_basic_datagrid_ReadOnlyChanged(object sender, EventArgs e)
        {
			if (client_basic_datagrid.Enabled && Settings.Default.oper_mode != 2)
			{
				add_user_btn.Enabled = true;
			}
			else
			{
				add_user_btn.Enabled = false;
			}
		}

        private void client_basic_datagrid_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
			//if (refreshing)
			//{
			//	return;
			//}
			//Dictionary<string, int> dictionary = new Dictionary<string, int>();
			//dictionary.Add("ID", 0);
			//foreach (DataGridViewColumn column in client_basic_datagrid.Columns)
			//{
			//	if (column.Name != "ID")
			//	{
			//		dictionary.Add(column.Name, column.DisplayIndex);
			//	}
			//}
			//FileStream serializationStream = new FileStream("ColumnOrder.bin", FileMode.Create);
			//((IFormatter)new BinaryFormatter()).Serialize((Stream)serializationStream, (object)dictionary);
		}

		private void OrderColumns()
		{
			//if (!File.Exists("ColumnOrder.bin"))
			//{
			//	return;
			//}
			//FileStream serializationStream = new FileStream("ColumnOrder.bin", FileMode.Open);
			//Dictionary<string, int> dictionary = (Dictionary<string, int>)((IFormatter)new BinaryFormatter()).Deserialize((Stream)serializationStream);
			//foreach (DataGridViewColumn column in client_basic_datagrid.Columns)
			//{
			//	if (dictionary.ContainsKey(column.Name))
			//	{
			//		column.DisplayIndex = dictionary[column.Name];
			//	}
			//}

			//global_functions.Entry_log(0, "order_columns - success", "");
		}

        private void client_basic_datagrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
			{
				copyCellValueToolStripMenuItem_Click(null, null);
			}
		}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Home)
			{
				shortcuts_List.Show();
			}
		}

        private void shortcutsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
			shortcuts_List.Show();
		}

        private void changelogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			new Changelogs_form().ShowDialog();
		}

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
			if (client_basic_datagrid.Rows.Count > 0)
			{
				iDToolStripMenuItem.Text = "ID: " + client_basic_datagrid.SelectedRows[0].Cells[0].Value.ToString();
			}
			
		}

        private void client_basic_datagrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
			
		}

		private void increase_font_big(Control control)
		{
			control.Font = new Font("Calibri", 10f);
		}

		private void default_font(Control control)
		{
			control.Font = new Font("Calibri", 8.25f);
		}

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
			global_functions.ui_size_0(control_list);
		}

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
			global_functions.ui_size_1(control_list);
		}

        private void reloadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
			load_all_data();
			global_functions.Entry_log(0, "reload_databse_clicked - success", "");
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
			search_text = textBox1.Text;
			if (Settings.Default.quick_search)
			{
				button2_Click(null, null);
				global_functions.Entry_log(0, "quick_search - success", "");
			}
		}

        private void textBox1_Enter(object sender, EventArgs e)
        {
			if (comboBox1.Text == "" || comboBox1.Text == null)
			{
				textBox1.ReadOnly = true;
			}
			else
			{
				textBox1.ReadOnly = false;
			}
		}

        private void client_basic_datagrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
			if (Settings.Default.save_mode == 0 && chnanged)
			{
				if (!update_query.IsBusy)
				{
					update_query.RunWorkerAsync();
				}
			}
		}

        private void client_basic_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void client_basic_datagrid_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
			
		}

		
        private void commitChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			update_query.RunWorkerAsync();
		}

        private void update_query_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

			try
			{
				dataAdapter.Update((DataTable)e.UserState);
				Thread.Sleep(500);
			}
			catch(Exception ex)
			{
				update_query.CancelAsync();
				global_functions.Entry_log(1, "commit_data_worker - " + ex.Message , ex.StackTrace);

			}
		}

        private void Reminders_timer_Tick(object sender, EventArgs e)
        {
			
        }

        private void button1_Click(object sender, EventArgs e)
        {
			splitContainer5.Panel1Collapsed = true;
			audio.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
			if (global_vars.mute_audio)
			{
				button3.Text = "Mute";
				global_vars.mute_audio = false;
				global_functions.Entry_log(0, "audio unmuted", "");
			}
			else
			{
				button3.Text = "Unmute";
				global_vars.mute_audio = true;
				audio.Stop();

				global_functions.Entry_log(0, "audio muted", "");
			}
			
		}

        private void label1_Click(object sender, EventArgs e)
        {
			splitContainer5.Panel1Collapsed = true;
			audio.Stop();
			new Reminder_window_form().ShowDialog(this);
			

			global_functions.Entry_log(0, "reminder_popup clicked", "");
		}

        private void savedQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

		void load_queries()
		{
			try
			{
				listBox1.Items.Clear();
				string querypath = Path.GetDirectoryName(global_vars.getDatabasePath()) + "/queries";
				foreach (string queries in Directory.GetFiles(querypath))
				{
					listBox1.Items.Add(Path.GetFileNameWithoutExtension(queries));

				}

				global_functions.Entry_log(0, "load_queries - success", "");

			}
			catch(Exception ex)
			{
				set_status("Error occured while loading selected queries.. Please try again or restart the application.");
				global_functions.Entry_log(1, "load_queries" + ex.Message, ex.StackTrace);
			}

		}

        private void check_queries_Tick(object sender, EventArgs e)
        {
			if (global_vars.queryadded)
			{
				load_queries();
				global_vars.queryadded = false;
			}
			
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			try
			{
				string querypath = Path.GetDirectoryName(global_vars.getDatabasePath()) + "/queries";
				textBox2.Text = File.ReadAllText(querypath + "/" + listBox1.SelectedItem.ToString());

				global_functions.Entry_log(0, "query_loaded - success", "");
			}
			catch(Exception ex)
			{
				set_status("Error occured while loading the selected query.. Please check if the query is valid.");
				global_functions.Entry_log(1, "query_loaded - " + ex.Message, ex.StackTrace);

			}
		}

        private void applicationLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
			global_functions.log_Console.Show();
        }

        private void remwindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
			
        }

        private void digi_time_Tick(object sender, EventArgs e)
        {
			digi_clock.Text = DateTime.Now.ToShortTimeString();
        }


        private void splitContainer6_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer6_SplitterMoved(object sender, SplitterEventArgs e)
        {
			
		}

        private void splitContainer6_Panel1_MouseEnter(object sender, EventArgs e)
        {
			
		}

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
			
        }

        private void openSidebarToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (splitContainer6.Panel1Collapsed == false)
			{
				splitContainer6.Panel1Collapsed = true;
				optionsToolStripMenuItem.Visible = true;
			}
			else
			{
				splitContainer6.Panel1Collapsed = false;
				optionsToolStripMenuItem.Visible = false;
			}
			
		}


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void login_console_Click(object sender, EventArgs e)
        {
			new Console_login_form().ShowDialog();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
			string querypath = Path.GetDirectoryName(global_vars.getDatabasePath()) + "/queries";

			try
			{
				if (e.KeyCode == Keys.Delete)
				{
					if (MessageBox.Show("Delete selected query?\nThis action cannot be undone.", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
					{
						File.Delete(querypath + "/" + listBox1.SelectedItem.ToString());

						sts_txt.Text = "Query file deleted..";
						load_queries();
					}



				}
			}
			catch
			{
				sts_txt.Text = "Error occurred.. Selected query not deleted..";
			}

		}

        private void splitContainer6_VisibleChanged(object sender, EventArgs e)
        {
			
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			splitContainer6.Panel1Collapsed = false;
			optionsToolStripMenuItem.Visible = false;
		}

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {


		}

        private void button4_Click(object sender, EventArgs e)
        {

			sts_txt.Text = "Reading excel file";
			read_excel_worker.RunWorkerAsync();
			
			//Workbook workbook = new Workbook();


			//workbook.LoadFromFile("C:/Users/Karan/Downloads/123  IGST Status 24-07-2018 - Copy.xlsx");

			//Worksheet sheet = workbook.Worksheets[0];

			////sheet.range
			//DataTable dataTable = sheet.ExportDataTable();

			

			//dataGridView1.DataSource =;

		}


		//DataTable dataTable;
		string excelfile = "";

		string dataset_file;
		private void read_excel_worker_DoWork(object sender, DoWorkEventArgs e)
        {


			//using (Workbook workbook = new Workbook())
			//{
			//	workbook.LoadFromFile(excelfile);

			//	Worksheet sheet = workbook.Worksheets[0];


			//	dataTable = new DataTable();
			//	dataTable = sheet.ExportDataTable();
			//	view = new DataView(dataTable);

			//	read_excel_worker.ReportProgress(100, dataTable);
			//}

			


			string filepath = excelfile;
	
            using (var stream = File.Open(filepath, FileMode.Open, FileAccess.Read))
            {
              
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

					var result = reader.AsDataSet(new ExcelDataSetConfiguration()
					{

						// Gets or sets a callback to obtain configuration options for a DataTable. 
						ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
						{
							UseHeaderRow = true,

							// Gets or sets a callback to determine which row is the header row. 
							// Only called when UseHeaderRow = true.
							//ReadHeaderRow = (rowReader) => {
							//	// F.ex skip the first row and use the 2nd row as column headers:
							//	rowReader.Read();
							//}
						}
					});


					read_excel_worker.ReportProgress(100, result.Tables[0]);

					//result = null;
					result.Dispose();
					
                    // The result of each spreadsheet is in result.Tables
                }
				GC.Collect();
				GC.WaitForPendingFinalizers();
				
            }
        }


		private const int totalRecords = 43;
		private const int pageSize = 10;
		List<DataTable> tabless = new List<DataTable>();
		//BindingSource SBind;
		private void read_excel_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {


			var results = e.UserState as DataTable;


			//dataTable.DataSet.EnforceConstraints = true;

			//DataTable dataTable = new DataTable();
			//dataTable.BeginLoadData();
			//dataTable.ReadXml(dataset_file);


			////tabless = CloneTable(dataTable, 1000);
			////dataTable.Rows.Cast<System.Data.DataRow>().Take(50);

			//dataTable.EndLoadData();




			//dataTable = dataTable.Rows.Cast<DataRow>().
			//Where(row => !row.ItemArray.All(field => field is System.DBNull ||
			//string.Compare((field as string).Trim(), string.Empty) == 0)).CopyToDataTable();



			//dataGridView1.AutoGenerateColumns = false;
			//dataGridView1.DataSource = dataTable;

			//
			//
			//dataTable.AsEnumerable().Skip(100).Take(25);

			//	bindingSource2.DataSource = dataTable;
			////	bindingNavigator1.BindingSource = bindingSource2;
			//	bindingSource1.CurrentChanged += BindingSource2_CurrentChanged;
			//	bindingSource1.DataSource = new PageOffsetList();

			//dataTable.AcceptChanges();
			dataGridView1.DataSource = results;
			

			dataGridView1.ReadOnly = false;

			comboBox1.Items.Clear();
			foreach (DataGridViewColumn column in dataGridView1.Columns)
			{
				comboBox1.Items.Add(column.HeaderText);

			}

		}


		private List<DataTable> CloneTable(DataTable tableToClone, int countLimit)
		{
			List<DataTable> tables = new List<DataTable>();
			int count = 0;
			DataTable copyTable = null;
			foreach (DataRow dr in tableToClone.Rows)
			{
				if ((count++ % countLimit) == 0)
				{
					copyTable = new DataTable();
					// Clone the structure of the table.
					copyTable = tableToClone.Clone();
					// Add the new DataTable to the list.
					tables.Add(copyTable);
				}
				// Import the current row.
				copyTable.ImportRow(dr);
			}
			return tables;
		}


		private void read_excel_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

			//dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
			sts_txt.Text = "Total rows: " + dataGridView1.Rows.Count;

			//dataTable = null;
			//dataTable.Dispose();
			GC.Collect();
			GC.WaitForPendingFinalizers();

			// or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

			// set it to false if not needed
			//	dataGridView1.RowHeadersVisible = tru;

			//dataTable.Dispose();
			//sts_txt.Text = "setting dataset";
			//	dataGridView1.DataSource = dataTable;

		}

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
			if (!save_sheet_worker.IsBusy)
			{
				toolStripMenuItem4.Text = "Saving...";
				save_sheet_worker.RunWorkerAsync();

			}
			else
			{
				sts_txt.Text = "Saving already in progress.. Please wait for the process to finish.";
			
			}
					

		}

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
			try
			{
				//dataTable.Rows[e.RowIndex][e.ColumnIndex] = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
				//dataGridView1.DataSource.AcceptChanges();
				dataGridView1.DataSource = dataGridView1.DataSource as DataTable;
				//dataTable.AcceptChanges();
				//var source = ((DataTable)SBind.DataSource);
				//update_query.ReportProgress(0, source);
			}
			catch (Exception ex)
			{
				//update_query.CancelAsync();
				//global_functions.Entry_log(1, "update_query - " + ex.Message, ex.StackTrace);
			}
		}

        private void button5_Click(object sender, EventArgs e)
        {

			

		}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
		
		}

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
			//dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
		}

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
			
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
			if (e.TabPage == tabPage1)
			{
				load_all_data();

			}
			if (e.TabPage == tabPage2)
			{
				comboBox1.Items.Clear();

				if (dataGridView1.Columns.Count > 0)
				{
					foreach (DataGridViewColumn column in dataGridView1.Columns)
					{
						comboBox1.Items.Add(column.HeaderText);
					
					}
				
				}

			}
		}

        private void panel12_DragEnter(object sender, DragEventArgs e)
        {
			
		}

        private void panel12_DragDrop(object sender, DragEventArgs e)
        {
			
				
				//textBox1.Text = file.First();

			//excelfile = file;
			
		}

        private void listView1_SizeChanged(object sender, EventArgs e)
        {
			listView1.Columns[0].Width = listView1.Width;
		}

        private void save_sheet_worker_DoWork(object sender, DoWorkEventArgs e)
        {


			//ExportDataTableToExcel(dataGridView1.DataSource as DataTable, "C:/Rajja_Logistics/insertTableToExcel.xlsx");
			//using (Workbook book = new Workbook())
			//{
			//    book.Version = ExcelVersion.Version2010;
			//    using (Worksheet sheet = book.Worksheets[0])
			//    {

			//        //sheet.SetCellValue();
			//        sheet.InsertDataTable(dataGridView1.DataSource as DataTable, true, 1, 1);
			//        book.SaveAsXml("C:/Rajja_Logistics/insertTableToExcel.xml");
			//        //dataTable.Dispose();


			//    }
			//}

			//var sb = new StringBuilder();


			

			var path = "C:/Rajja_Logistics/insertTableToExcel.csv";
            var file = File.Create(path);
			file.Close();
			
			using (FileStream fs = File.Open(path,FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
			using (BufferedStream bs = new BufferedStream(fs))
			using (StreamWriter w = new StreamWriter(bs))
			{

				var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
				w.WriteLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
				var counter = 0;
				
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					counter++;
					if (counter > 1000)
					{
						w.Flush();
						bs.Flush();
						fs.Flush();

						counter = 0;
					}
					var cells = row.Cells.Cast<DataGridViewCell>();
					var string_cells = (string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));


					w.WriteLine(string_cells);


					

				}
			}
			GC.Collect();
			GC.WaitForPendingFinalizers();


		}

	


		private void save_sheet_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			toolStripMenuItem4.Text = "Save";
			

		}

        private void addPhoneColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var dataTable = dataGridView1.DataSource as DataTable;

			if (dataGridView1.Rows.Count > 0 && dataTable!=null && !dataTable.Columns.Contains("Phone_number"))
			{
				
				dataTable.Columns.Add("Phone_number");
				dataGridView1.DataSource = dataTable;
			
			}
        }

		//int table_num = 1;

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
			//var tab_c = tabless.Count;
			//sts_txt.Text = tab_c.ToString();
			//int current_table = 0;

			//if (current_table <= tab_c)
			//{
			//	current_table++;
			//	dataGridView1.DataSource =  tabless[current_table];
		
			//}

			
			//MessageBox.Show(tab_c.ToString());

			//dataTable.AsEnumerable().Skip(25).Take(25);
			
			
		}

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
			string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

			if (file != null && file.Any())
			{
				var datatable = dataGridView1.DataSource as DataTable;
				if (datatable != null)
				{
					datatable.Dispose();
				}
				
				GC.Collect();
				GC.WaitForPendingFinalizers();

				excelfile = file.First();

				ListViewItem li = new ListViewItem();
				li.ImageIndex = 0;
				li.Text = excelfile;
				listView1.Items.Add(li);
				sts_txt.Text = "Loading file " + Path.GetFileNameWithoutExtension(excelfile) + " ...";

				dataGridView1.DataSource = null;
				//c_AdvancedDataGrid1.DataSource = excelfile;

				read_excel_worker.RunWorkerAsync();
			}
		}

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

        private void uISizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

			if (!import_Data_Form.IsDisposed)
			{
				import_Data_Form.Close();
				import_Data_Form.Dispose();

			}

			new Import_data_form().Show();
		}
		
        private void nextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			if (fromidx >= 0)
			{
				previousToolStripMenuItem.Enabled = true;
			}

			if (client_basic_datagrid.Rows.Count < 100)
			{
				nextToolStripMenuItem1.Enabled = false;
			}
			else
			{
				nextToolStripMenuItem1.Enabled = true;
				query = "select * from client_data limit " + (fromidx + 100) + ", " + numrows + ";";
				load_database();
				fromidx += 100;
			}
		}

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (client_basic_datagrid.Rows.Count >= 100)
			{
				nextToolStripMenuItem1.Enabled = true;
			}
			//numrows -= 100;
			if (fromidx == 0)
			{
				previousToolStripMenuItem.Enabled = false;
			}
			else
			{
				previousToolStripMenuItem.Enabled = true;
				query = "select * from client_data limit " + (fromidx - 100) + ", " + numrows + ";";
				load_database();
				fromidx -= 100;
			}

		}
    }

    public static class ExtensionMethods
	{

		public static void DoubleBuffered(this DataGridView dgv, bool setting)
		{
			dgv.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgv, setting, null);
		}

		public static bool Contains(this string source, string toCheck, StringComparison comp)
		{
			if (source == null)
			{
				return false;
			}
			return source.IndexOf(toCheck, comp) >= 0;
		}

		public static async Task CloseAfterDelay(this Form form, int millisecondsDelay)
		{
			await TaskEx.Delay(millisecondsDelay);
			form.Close();
		}

		



	}



	public class SyncBindingSource : BindingSource
	{
		private SynchronizationContext syncContext;
		public SyncBindingSource()
		{
			syncContext = SynchronizationContext.Current;
		}
		protected override void OnListChanged(ListChangedEventArgs e)
		{
			if (syncContext != null)
				syncContext.Send(_ => base.OnListChanged(e), null);
			else
				base.OnListChanged(e);
		}


	}


}
