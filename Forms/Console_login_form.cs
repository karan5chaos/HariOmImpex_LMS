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
    public partial class Console_login_form : Form
    {
        public Console_login_form()
        {
            InitializeComponent();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (textBox1.Text == "admin" && textBox2.Text == "admin@12345")
                {
                    new Admin_dashboard_form().ShowDialog();
                    //Access_points_vars.c_login = true;
                    Close();
                
                }
            
            
            }
        }

        private void Console_login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
