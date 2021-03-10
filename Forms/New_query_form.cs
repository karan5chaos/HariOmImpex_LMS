using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HariOmImpex_LMS.Properties;

namespace HariOmImpex_LMS.Forms
{
    public partial class New_query_form : Form
    {
        public New_query_form()
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

        private void button1_Click(object sender, EventArgs e)
        {
			try
			{
				string text = Path.GetDirectoryName(global_vars.getDatabasePath()) + "/queries";
				if (Directory.Exists(text))
				{
					File.AppendAllText(text + "/" + textBox1.Text, textBox2.Text);
				}
				else
				{
					Directory.CreateDirectory(text);
					File.AppendAllText(text + "/" + textBox1.Text, textBox2.Text);
				}
				global_vars.queryadded = true;
				global_functions.Entry_log(0, "query_add - success", "");
				Close();
			}
			catch(Exception ex)
			{
				global_functions.Entry_log(1, "query_add - " + ex.Message, ex.StackTrace);
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
			textBox1.Clear();
			textBox2.Clear();

		}


    }
}
