using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HariOmImpex_LMS.Forms;
using HariOmImpex_LMS.Properties;

namespace HariOmImpex_LMS
{
    public partial class Form1 : Form
    {
        private List<Control> control_list;
        private string query;

        public Form1()
        {
            InitializeComponent();

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
				}
				connection.Close();
			}
			catch
			{
			}
		}

		private void queryBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (!splitContainer3.Panel2Collapsed)
			{
				splitContainer3.Panel2Collapsed = true;
				edit_mode_button.Enabled = true;
				reloadDatabaseToolStripMenuItem.Enabled = true;
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
				foreach (string item in comboBox1.Items)
				{
					//if (!autocompleteMenu1.get_Items().Contains(item))
					//{
					//	autocompleteMenu1.AddItem(item);
					//}
				}
			}
		}

        private void toggleSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			if (splitContainer2.Panel1Collapsed)
			{
				splitContainer2.Panel1Collapsed = false;
				comboBox1.Focus();
			}
			else
			{
				splitContainer2.Panel1Collapsed = true;
			}
		}

        private void backupManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Backup_manager_form backup_Manager = new Backup_manager_form();
			backup_Manager.ShowDialog();
        }

        private void aboutApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
			
		}

        private void add_user_btn_Click(object sender, EventArgs e)
        {
			Add_new_client_form add_New = new Add_new_client_form();
			add_New.ShowDialog();
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
					add_user_btn.Enabled = false;
				}
				else
				{
					client_basic_datagrid.ReadOnly = false;
					edit_mode_button.Text = "Edit mode (On)";
					edit_mode_button.BackColor = Color.GreenYellow;
					add_user_btn.Enabled = true;
				}
			}
		}

		private void load_all_data()
		{
			get_column_names();
			query = "select * from client_data;";
			load_database();
		}

		private void load_reminders()
		{
			today_rem_datagrid.DataSource = null;
			upcoming_rem_datagrid.DataSource = null;
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
				textBox1.Enabled = false;
			}
			else
			{
				textBox1.Enabled = true;
			}
		}

		private void set_status(string mess)
		{
			sts_txt.Text = mess;
		}

        private void button2_Click(object sender, EventArgs e)
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

		private void load_database()
		{
			if (!get_data.IsBusy)
			{
				loading_box.Visible = true;
				if (File.Exists(global_vars.getDatabasePath()))
				{
					fileSystemWatcher1.Path = Path.GetDirectoryName(global_vars.getDatabasePath());
					fileSystemWatcher1.NotifyFilter = NotifyFilters.LastWrite;
					fileSystemWatcher1.EnableRaisingEvents = true;
					get_data.RunWorkerAsync();
				}
			}
		}
	}
}
