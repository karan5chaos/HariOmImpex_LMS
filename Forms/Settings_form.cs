using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HariOmImpex_LMS.Properties;
using HariOmImpex_LMS.Forms;
using System.IO;

namespace HariOmImpex_LMS.Forms
{
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
        }

        private void Settings_form_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.database_path;
            textBox2.Text = Settings.Default.backup_path;
            comboBox1.SelectedIndex = Settings.Default.backup_time;
            checkBox3.Checked = Settings.Default.quick_search;
            checkBox4.Checked = Settings.Default.load_data_startup;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
            Settings.Default.database_path = openFileDialog1.FileName;
            Settings.Default.Save();
            Settings.Default.Reload();
            global_vars.updated = true;
        }

        private void save_settings()
        {
            Settings.Default.quick_search = Convert.ToBoolean(checkBox3.CheckState);
            Settings.Default.load_data_startup = Convert.ToBoolean(checkBox4.CheckState);
            Settings.Default.database_path = textBox1.Text;
            Settings.Default.Save();
            Settings.Default.Reload();
            global_vars.updated = true;
        }

        private void Settings_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
            
            
            if (File.Exists(global_vars.getDatabasePath()))
            {
                Form1 main_Page = new Form1();

                main_Page.fileSystemWatcher1.Path = Path.GetDirectoryName(global_vars.getDatabasePath());
                main_Page.fileSystemWatcher1.NotifyFilter = NotifyFilters.LastWrite;
                main_Page.fileSystemWatcher1.EnableRaisingEvents = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.backup_time = comboBox1.SelectedIndex;
        }
    }
}
