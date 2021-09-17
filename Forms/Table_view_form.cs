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
    public partial class Table_view_form : Form
    {
        public Table_view_form()
        {
            InitializeComponent();
        }

        private void splitContainer6_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer6_Panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nf = new Form1();
            nf.MdiParent = this;
          //  nf.LayoutMdi(MdiLayout.Cascade);
            nf.TopLevel = false;
            //panel1.Controls.Add(nf);
            nf.Show();

            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void backupManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup_manager_form nf = new Backup_manager_form();
            nf.TopLevel = false;
            panel1.Controls.Add(nf);
            nf.Show();
        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_data_form nf = new Import_data_form();
            nf.TopLevel = false;
            panel1.Controls.Add(nf);
            nf.Show();
        }

        private void remindersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reminder_window_form nf = new Reminder_window_form();
            nf.TopLevel = false;
            panel1.Controls.Add(nf);
            nf.Show();
        }
    }
}
