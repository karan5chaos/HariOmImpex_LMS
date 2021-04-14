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
using System.Reflection;
using System.Resources;
using System.Globalization;
using System.Collections;
using System.Media;

namespace HariOmImpex_LMS.Forms
{
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
        }

        SoundPlayer audio = new SoundPlayer();

        private void Settings_form_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.database_path;
            textBox2.Text = Settings.Default.backup_path;
            comboBox1.SelectedIndex = Settings.Default.backup_time;
            comboBox2.SelectedIndex = Settings.Default.save_mode;
            checkBox3.Checked = Settings.Default.quick_search;
            checkBox4.Checked = Settings.Default.load_data_startup;
            load_notif_sounds();

            notif_combox.SelectedIndex = Properties.Settings.Default.selected_notif_sound;

            global_functions.Entry_log(0, "setting_loaded - success", "");
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

        void load_notif_sounds()
        {
            ResourceSet rsrcSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, false, true);
            List<string> notif = new List<string>();

            
            foreach (DictionaryEntry entry in rsrcSet)
            {
                if (entry.Key.ToString().Contains("notif"))
                {
                    notif.Add(entry.Key.ToString());
                    //notif_combox.Items.Add();
                }
            }
            notif.Sort();

            foreach (string item in notif)
            {
                notif_combox.Items.Add(item);

            }

            //var assembly = Assembly.GetExecutingAssembly();

            //foreach (var resourceName in assembly.GetManifestResourceNames())
            //{
            //        notif_combox.Items.Add(resourceName.ToString());
            //}
        }

        private void save_settings()
        {
            Settings.Default.quick_search = Convert.ToBoolean(checkBox3.CheckState);
            Settings.Default.load_data_startup = Convert.ToBoolean(checkBox4.CheckState);
            Settings.Default.database_path = textBox1.Text;
            Settings.Default.selected_notif_sound = notif_combox.SelectedIndex;
            Settings.Default.Save();
            Settings.Default.Reload();
            global_vars.updated = true;

            global_functions.Entry_log(0, "settings_updated - success", "");
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

            audio.Stop();
            audio.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.backup_time = comboBox1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (notif_combox.Text != "")
            {

                string notif_name = "notif_sound_" + notif_combox.SelectedIndex.ToString();

                audio.Stream = Properties.Resources.ResourceManager.GetStream(notif_name);

                //switch (notif_combox.SelectedIndex)
                //{
                //    case 0:
                //        {
                //            audio.Stream = Properties.Resources.notif_sound_0;
                //        }
                //        break;

                //    case 1:
                //        {
                //            audio.Stream = Properties.Resources.notif_sound_1;
                //        }
                //        break;
                //}

                audio.Play(); 
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.save_mode = comboBox2.SelectedIndex;
        }

        private void notif_combox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
