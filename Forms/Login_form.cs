using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HariOmImpex_LMS.Properties;
using HariOmImpex_LMS.Globals_Variables;

namespace HariOmImpex_LMS.Forms
{
    public partial class Login_form : Form
    {
        private List<Control> control_list;

        public Login_form()
        {
            InitializeComponent();

            control_list = new List<Control>();
            foreach (Control control in base.Controls)
            {
                control_list.Add(control);
            }
            control_list.Add(groupBox1);
            if (Settings.Default.ui_size == 1)
            {
                global_functions.ui_size_1(control_list);
                global_functions.Entry_log(0, "UI_size set to 1","");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                global_functions.Entry_log(0, "textbox_keydown - check_access","");
                check_access(comboBox1.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caption = "";
            if (comboBox1.Text == "admin")
            {
                caption = "'admin' mode allows unrestricted access to all features and fuctionality of this program.\nOnly admins can remove existing entries.";
            }
            else if (comboBox1.Text == "user")
            {
                caption = "'user' mode allows access to limited funtionalities.\nusers can add or modify existing entries but cannot delete them.";
            }
            else if (comboBox1.Text == "view")
            {
                caption = "'view' mode only allows you to view data. Majority of the program features are disabled.";
            }
            toolTip1.SetToolTip(comboBox1, caption);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Default.oper_mode = 2;
            Close();
            global_functions.Entry_log(0, "Skip button clicked. oper_mode set to 2.","");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //global_functions.Entry_log(0, "login_button_clicked - check_access","");
            //check_access();

            var users = global_functions.load_SQLiteData("select password from users_data where user_name = '"+ comboBox1.Text +"';");
            string passwrd = users.Tables[0].Rows[0].Field<string>("password");

            if (textBox1.Text == passwrd)
            {
                check_access(comboBox1.Text);
                Close();

            }
            else
            {
                MessageBox.Show("incorrect password");
            
            }
               

            //foreach (DataRow user in users.Tables[0].Rows)
            //{
            //    comboBox1.Items.Add(user.Field<string>("user_name"));

            //}


        }

        bool access_check = false;
        private void check_access(string user)
        {
            //if (comboBox1.Text == "admin" && textBox1.Text == "admin_0000")
            //{
            //    Settings.Default.oper_mode = 0;
            //    global_functions.Entry_log(0, "check_access mode 0 - admin","");
            //    access_check = true;
            //    Close();
            //}
            //else if (comboBox1.Text == "user" && textBox1.Text == "impex123")
            //{
            //    Settings.Default.oper_mode = 1;
            //    global_functions.Entry_log(0, "check_access mode 1 - user","");
            //    access_check = true;
            //    Close();
            //}
            //else if (comboBox1.Text == "view")
            //{
            //    Settings.Default.oper_mode = 2;
            //    global_functions.Entry_log(0, "check_access mode 2 - view","");
            //    access_check = true;
            //    Close();
            //}
            //else
            //{
            //    toolStripStatusLabel1.Text = "Verification failed.. Please try again.";
            //    global_functions.Entry_log(0, "check_access verification failed.","");
            //}


            var users = global_functions.load_SQLiteData("select * from users_data where user_name = '" + user + "';");

            Access_points_vars.af_bm = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("af_bm"));

            Access_points_vars.af_al = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("af_al"));
            Access_points_vars.af_set = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("af_set"));
            Access_points_vars.af_ad = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("af_ad"));
            Access_points_vars.af_qb = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("af_qb"));
            Access_points_vars.do_anc = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("do_anc"));
            Access_points_vars.do_dce = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("do_dce"));
            Access_points_vars.do_dr = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("do_dr"));
            Access_points_vars.do_ecd = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("do_ecd"));
            Access_points_vars.do_mce = Convert.ToBoolean(users.Tables[0].Rows[0].Field<Int64>("do_mce"));

        }

        private void Login_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;

            if (!access_check)
            {
                Settings.Default.oper_mode = 2;
                global_functions.Entry_log(0, "form_closed. oper_mode set to 2", "");

            }
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            var users = global_functions.load_SQLiteData("select user_name from users_data;");

            foreach (DataRow user in users.Tables[0].Rows)
            {
                comboBox1.Items.Add(user.Field<string>("user_name"));
            
            }
        }
    }
}
