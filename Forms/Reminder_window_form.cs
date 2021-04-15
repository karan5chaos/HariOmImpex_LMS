using HariOmImpex_LMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Transitions;

namespace HariOmImpex_LMS.Forms
{
    public partial class Reminder_window_form : Form
    {
        private DataSet today_reminder;
        private DataSet upcoming_reminder;
        private string todaysdate;

        public Reminder_window_form()
        {
            InitializeComponent();

            todaysdate = DateTime.Now.ToLongDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form form1 = Application.OpenForms["Form1"];
            //SplitContainer sc = new SplitContainer();
            //sc = (SplitContainer)form1.Controls["main_splitcontainer"];

            //if (sc.Panel2Collapsed)
            //{
            //    sc.Panel2Collapsed = false;
            //}
            //else
            //{
            //    sc.Panel2Collapsed = true;
            //}
        }

        private void Reminder_window_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.Hide();
        }

        private void Reminder_window_form_Load(object sender, EventArgs e)
        {
            load_reminders();
        }

        private void Reminder_window_form_VisibleChanged(object sender, EventArgs e)
        {
            //SoundPlayer audio = new SoundPlayer();

            //    switch (Properties.Settings.Default.selected_notif_sound)
            //    {
            //        case 0:
            //            {
            //                audio.Stream = Properties.Resources.notif_sound_0;
            //            }
            //            break;

            //        case 1:
            //            {
            //                audio.Stream = Properties.Resources.notif_sound_1;
            //            }
            //            break;
            //    }

            //if (this.Visible)
            //{
            //    audio.Play();
                
            //}
            //else
            //{
            //    audio.Stop();
                
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //global_vars.hide_rem_window = Convert.ToBoolean(checkBox1.CheckState);
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
            catch (Exception ex)
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
                today_rem_datagrid.DataSource = today_reminder.Tables[0].DefaultView;
                upcoming_rem_datagrid.DataSource = upcoming_reminder.Tables[0].DefaultView;

                global_vars.reminders = today_rem_datagrid.Rows.Count;

                if (global_vars.reminders>0)
                {
                   
                    toolStripStatusLabel1.Text = "There are active reminders for today!";
                }

                today_reminder.Dispose();
                upcoming_reminder.Dispose();

                global_functions.Entry_log(0, "get_reminders_workcompleted - success", "");
            }

            catch (Exception exc)
            {
                global_functions.Entry_log(1, "get_reminders_workcompleted" + exc.Message, exc.StackTrace);
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (today_rem_datagrid.Rows.Count > 0 && Settings.Default.oper_mode != 2)
            {
                contextMenuStrip2.Enabled = true;
            }
            else
            {
                contextMenuStrip2.Enabled = false;
            }
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            if (upcoming_rem_datagrid.Rows.Count > 0 && Settings.Default.oper_mode != 2)
            {
                contextMenuStrip3.Enabled = true;
            }
            else
            {
                contextMenuStrip3.Enabled = false;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            delete_reminder(upcoming_rem_datagrid);
        }

        private void deleteSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete_reminder(today_rem_datagrid);
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
                    toolStripStatusLabel1.Text = "Reminder deleted..";
                }
                catch (Exception exception)
                {
                    global_functions.Entry_log(1, "delete_reminder (global_functions.execute_command) - " + exception.Message, exception.StackTrace);
                    toolStripStatusLabel1.Text = "Failed to delete reminder..";
                }
            }
        }

        private void load_reminders()
        {
            global_functions.Entry_log(0, "load_reminders - start", "");
            today_rem_datagrid.DataSource = null;
            upcoming_rem_datagrid.DataSource = null;
            if (!get_reminders.IsBusy)
            {
                get_reminders.RunWorkerAsync();
            }
        }

        private void addNewReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Add_reminder_form().ShowDialog(this);
            global_functions.Entry_log(0, "add_reminder_form opened", "");
        }
    }
}
