using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HariOmImpex_LMS.Properties;

namespace HariOmImpex_LMS.Forms
{
	public partial class Add_reminder_form : Form
	{
		public Add_reminder_form()
		{
			InitializeComponent();

			List<Control> list = new List<Control>();
			foreach (Control control in base.Controls)
			{
				list.Add(control);
			}
			if (Settings.Default.ui_size == 1)
			{
				global_functions.ui_size_1(list);
			}
		}

		private void Add_reminder_form_Load(object sender, EventArgs e)
		{

		}

		private void add_reminder()
		{

			try
			{
				SQLiteConnection connection = new SQLiteConnection();
				connection.ConnectionString = "Data Source=" + global_vars.getDatabasePath();
				connection.Open();
				SQLiteCommand command = new SQLiteCommand("insert into reminder_data(assigned_to, date, text)values (@assignedto, @date, @text);", connection);
				SQLiteParameter dateaparm = new SQLiteParameter("date", DbType.String);
				dateaparm.Value = date_text.Text;
				SQLiteParameter textparam = new SQLiteParameter("text", DbType.String);
				textparam.Value = rem_text.Text;
				SQLiteParameter assignedparam = new SQLiteParameter("assignedto", DbType.String);
				assignedparam.Value = textBox1.Text;
				command.Parameters.Add(dateaparm);
				command.Parameters.Add(textparam);
				command.Parameters.Add(assignedparam);
				command.ExecuteNonQuery();
				connection.Close();
				sts_text.Text = "Reminder successfully added.";
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred..\n\n" + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			add_reminder();
			global_vars.updated = true;
		}
	}
    }
