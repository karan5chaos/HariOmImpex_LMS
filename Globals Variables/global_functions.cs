using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using HariOmImpex_LMS.Properties;
using HariOmImpex_LMS.Forms;
using System;

namespace HariOmImpex_LMS
{
	internal class global_functions
	{
		public static DataSet load_SQLiteData(string sql)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			SQLiteConnection val = new SQLiteConnection();
			((DbConnection)(object)val).ConnectionString = "Data Source=" + global_vars.getDatabasePath();
			((DbConnection)(object)val).Open();
			DataSet dataSet = new DataSet();
			((DataAdapter)new SQLiteDataAdapter(sql, val)).Fill(dataSet);
			((DbConnection)(object)val).Close();
			return dataSet;
		}

		public static void execute_command(string sql)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			SQLiteConnection val = new SQLiteConnection();
			((DbConnection)(object)val).ConnectionString = "Data Source=" + global_vars.getDatabasePath();
			((DbConnection)(object)val).Open();
			((DbCommand)new SQLiteCommand(sql, val)).ExecuteNonQuery();
			((DbConnection)(object)val).Close();
		}

		public static DataSet load_SearchQuery(string sql)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			SQLiteConnection val = new SQLiteConnection();
			((DbConnection)(object)val).ConnectionString = "Data Source=" + global_vars.getDatabasePath();
			((DbConnection)(object)val).Open();
			DataSet dataSet = new DataSet();
			((DataAdapter)new SQLiteDataAdapter(sql, val)).Fill(dataSet);
			((DbConnection)(object)val).Close();
			return dataSet;
		}

		public static void increase_font_big(Control control)
		{
			control.Font = new Font("Calibri", 10f);
		}

		public static void default_font(Control control)
		{
			control.Font = new Font("Calibri", 8.25f);
		}

		public static void ui_size_0(List<Control> controls)
		{
			foreach (Control control in controls)
			{
				default_font(control);
			}
			Settings.Default.ui_size = 0;
			Settings.Default.Save();
			Settings.Default.Reload();
		}

		public static void ui_size_1(List<Control> controls)
		{
			foreach (Control control in controls)
			{
				increase_font_big(control);
			}
			Settings.Default.ui_size = 1;
			Settings.Default.Save();
			Settings.Default.Reload();
		}


		public static Log_console_form log_Console = new Log_console_form();
		public static void Entry_log(int type, string message, string stack_trace)
		{
			

			//if (log_Console.Visible == false)
			//{
			//	//log_Console.Show();
			//	log_Console.Hide();
			
			//}
			log_Console.dataGridView1.Rows.Add(DateTime.Now.ToLongTimeString(), type.ToString(), message, stack_trace);
		}


	}
}
