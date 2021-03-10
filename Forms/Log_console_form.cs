using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HariOmImpex_LMS.Forms
{
    public partial class Log_console_form : Form
    {
        public Log_console_form()
        {
            InitializeComponent();
            dataGridView1.DoubleBuffered(true);
        }

        private void Log_console_form_Load(object sender, EventArgs e)
        {

        }

        private void exportLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                saveFileDialog1.ShowDialog();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            IEnumerable<DataGridViewColumn> source = dataGridView1.Columns.Cast<DataGridViewColumn>();
            stringBuilder.AppendLine(string.Join(",", source.Select((DataGridViewColumn column) => "\"" + column.HeaderText + "\"").ToArray()));
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                IEnumerable<DataGridViewCell> source2 = item.Cells.Cast<DataGridViewCell>();
                stringBuilder.AppendLine(string.Join(",", source2.Select((DataGridViewCell cell) => "\"" + cell.Value?.ToString() + "\"").ToArray()));
            }
            File.AppendAllText(saveFileDialog1.FileName, stringBuilder.ToString());
            global_functions.Entry_log(0, "export_log - success", "");
        }

        private void Log_console_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }

    public static class ExtensionMethods
    {

        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            dgv.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgv, setting, null);
        }
    }
    }
