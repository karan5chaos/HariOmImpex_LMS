using HariOmImpex_LMS.Globals_Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HariOmImpex_LMS.Forms
{
    public partial class Admin_dashboard_form : Form
    {
        public Admin_dashboard_form()
        {
            InitializeComponent();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Add_new_user_form().ShowDialog();
        }

        private void Admin_dashboard_form_Load(object sender, EventArgs e)
        {
            load_users();
        }

        private void deleteSelectedUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Delete selected user?\nThis cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    global_functions.execute_command("delete from users_data where ID = " + dataGridView1.SelectedRows[0].Cells[0].Value?.ToString() + ";");
                    toolStripStatusLabel1.Text = "user deleted";

                    load_users();

                    global_functions.Entry_log(0, "delete_user - success","");
                    
                }
            }
            catch (Exception ex)
            {
                global_functions.Entry_log(1, "delete_user - " + ex.Message, ex.StackTrace);
                toolStripStatusLabel1.Text = "Error occurred while deleting an user..";

            }
        }

        DataSet users;
        void load_users()
        {
            try
            {
                dataGridView1.DataSource = null;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                global_functions.Entry_log(1, "load_users_admin - " + ex.Message, ex.StackTrace);
                toolStripStatusLabel1.Text = "Error occurred while fetching users..";
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                users = new DataSet();
                users = global_functions.load_SQLiteData("select * from users_data;");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.DataSource = users.Tables[0].DefaultView;
            toolStripStatusLabel1.Text = "Users data fetched..";
            users.Dispose();

            global_functions.Entry_log(0, "load_users_admin - success" , "");

        }

        private void refreshUserListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_users();
        }
    }
}
