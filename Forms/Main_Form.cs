using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HariOmImpex_LMS.Forms;

namespace HariOmImpex_LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        }

        private void aboutApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
			
		}

        private void add_user_btn_Click(object sender, EventArgs e)
        {
			Add_new_client_form add_New = new Add_new_client_form();
			add_New.ShowDialog();
        }
    }
}
