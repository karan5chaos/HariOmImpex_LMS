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


namespace HariOmImpex_LMS.Forms
{
    public partial class Reminder_window_form : Form
    {
        public Reminder_window_form()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms["Form1"];
            SplitContainer sc = new SplitContainer();
            sc = (SplitContainer)form1.Controls["main_splitcontainer"];

            if (sc.Panel2Collapsed)
            {
                sc.Panel2Collapsed = false;
            }
            else
            {
                sc.Panel2Collapsed = true;
            }
        }

        private void Reminder_window_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Reminder_window_form_Load(object sender, EventArgs e)
        {

        }

        private void Reminder_window_form_VisibleChanged(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer();

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
                }

            if (this.Visible)
            {
                audio.Play();
                
            }
            else
            {
                audio.Stop();
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            global_vars.hide_rem_window = Convert.ToBoolean(checkBox1.CheckState);
        }
    }
}
