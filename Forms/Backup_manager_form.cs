using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HariOmImpex_LMS.Properties;

namespace HariOmImpex_LMS.Forms
{
    public partial class Backup_manager_form : Form
    {
        private string filetorestore;
        private string databasepath;
        private string newpath;
        private string filename;
        private List<Control> control_list;

        public Backup_manager_form()
        {
            InitializeComponent();
        }

        private void Backup_manager_form_Load(object sender, EventArgs e)
        {
			control_list = new List<Control>();
			control_list.Add(menuStrip1);
			control_list.Add(dataGridView1);
			control_list.Add(statusStrip1);
			if (Settings.Default.ui_size == 1)
			{
				global_functions.ui_size_1(control_list);
			}
			try
			{
				if (!Directory.Exists(Settings.Default.backup_path))
				{
					Directory.CreateDirectory(Settings.Default.backup_path);
				}
				string[] files = Directory.GetFiles(Settings.Default.backup_path);
				for (int i = 0; i < files.Length; i++)
				{
					FileInfo fileInfo = new FileInfo(files[i]);
					if (fileInfo.Extension == ".db")
					{
						dataGridView1.Rows.Add(fileInfo.Name, fileInfo.FullName, fileInfo.CreationTime, ConvertBytesToMegabytes(fileInfo.Length));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erorr occured..\n\n" + ex.Message);
				ststxt.Text = "Error occured.. please restart backup manager.";
			}
		}

        private void create_backup_worker_DoWork(object sender, DoWorkEventArgs e)
        {
			filename = Settings.Default.backup_path + "/backup_" + DateTime.Now.ToLongDateString() + "_" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + ".db";
			File.Copy(global_vars.getDatabasePath(), filename);
		}

        private void create_backup_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			loading_box.Visible = false;
			FileInfo fileInfo = new FileInfo(filename);
			dataGridView1.Rows.Add(fileInfo.Name, fileInfo.FullName, fileInfo.CreationTime, ConvertBytesToMegabytes(fileInfo.Length));
			ststxt.Text = "Backup " + fileInfo.Name + " created.";
		}

		private static double ConvertBytesToMegabytes(long bytes)
		{
			return (float)bytes / 1024f / 1024f;
		}

        private void restore_backup_worker_DoWork(object sender, DoWorkEventArgs e)
        {
			try
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
				File.Delete(global_vars.getDatabasePath());
				File.Copy(filetorestore, newpath);
				Settings.Default.database_path = newpath;
				Settings.Default.Save();
				Settings.Default.Reload();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erorr occured..\n\n" + ex.Message);
				ststxt.Text = "Error occured.. please restart backup manager.";
			}
		}

        private void restore_backup_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			loading_box.Visible = false;
			ststxt.Text = "Database restored..";
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["restore"].Index)
				{
					if (MessageBox.Show("Restoring database will replace the current database with current one.\nProceed?", "Restore database?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						loading_box.Visible = true;
						ststxt.Text = "Restoring database: " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "...";
						filetorestore = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
						databasepath = Path.GetDirectoryName(global_vars.getDatabasePath());
						newpath = databasepath + "/" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
						restore_backup_worker.RunWorkerAsync();
					}
				}
				else if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
				{
					File.Delete(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					ststxt.Text = "Database " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " deleted..";
					dataGridView1.Rows.RemoveAt(e.RowIndex);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erorr occured..\n\n" + ex.Message);
				ststxt.Text = "Error occured.. please restart backup manager.";
			}
		}

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
			loading_box.Visible = true;
			ststxt.Text = "Creating backup.. Please wait..";
			if (!create_backup_worker.IsBusy)
			{
				create_backup_worker.RunWorkerAsync();
			}
		}
    }
}
