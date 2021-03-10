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
    public partial class Shortcuts_form : Form
    {
        public Shortcuts_form()
        {
            InitializeComponent();
        }

        private void Shortcuts_form_Load(object sender, EventArgs e)
        {
			dataGridView1.DoubleBuffered(setting: true);
			foreach (KeyValuePair<string, string> item in new Dictionary<string, string>
			{
				{
					"Query Builder",
					"Ctrl + Q"
				},
				{
					"Backup Manager",
					"Ctrl + B"
				},
				{
					"Shortcuts cheat sheet",
					"Home"
				},
				{
					"Reload Database",
					"Ctrl + R"
				},
				{
					"Toggle Edit Mode",
					"Ctrl + E"
				},
				{
					"Toggle Search",
					"Ctrl + F"
				},
				{
					"Export current view",
					"Ctrl + P"
				},
				{
					"Delete selected entry",
					"Delete"
				},
				{
					"Copy selected value",
					"Ctrl + Shift + C or Ctrl + Mouse left-click"
				},
				{
					"Show reminder panel",
					"Ctrl + Space"
				},
				{
					"Add new reminder",
					"Ctrl + M"
				},
				{
					"Add new client",
					"Ctrl + N"
				},
				{
					"Increase font size",
					"Ctrl + +"
				},
				{
					"Decrease font size",
					"Ctrl + -"
				},
				{
					"Commit data",
					"Ctrl + S"
				}
			})
			{
				dataGridView1.Rows.Add(item.Key, item.Value);
			}
		}

        private void Shortcuts_form_KeyUp(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Home)
			{
				Hide();
			}
		}

        private void Shortcuts_form_FormClosing(object sender, FormClosingEventArgs e)
        {
			e.Cancel = true;
			Hide();
		}
    }
}
