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
    public partial class custom_msgbox_form : Form
    {
        public custom_msgbox_form()
        {
            InitializeComponent();
        }

        private void custom_msgbox_form_Load(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.ReadOnly = Convert.ToBoolean(checkBox1.CheckState);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
