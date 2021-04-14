
namespace HariOmImpex_LMS.Forms
{
    partial class Reminder_window_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder_window_form));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.today_rem_datagrid = new System.Windows.Forms.DataGridView();
            this.upcoming_rem_datagrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNewReminderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.get_reminders = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.today_rem_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcoming_rem_datagrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // today_rem_datagrid
            // 
            this.today_rem_datagrid.AllowUserToAddRows = false;
            this.today_rem_datagrid.AllowUserToOrderColumns = true;
            this.today_rem_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.today_rem_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.today_rem_datagrid.ColumnHeadersVisible = false;
            this.today_rem_datagrid.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.today_rem_datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.today_rem_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.today_rem_datagrid.Location = new System.Drawing.Point(3, 3);
            this.today_rem_datagrid.MultiSelect = false;
            this.today_rem_datagrid.Name = "today_rem_datagrid";
            this.today_rem_datagrid.ReadOnly = true;
            this.today_rem_datagrid.RowHeadersVisible = false;
            this.today_rem_datagrid.RowHeadersWidth = 51;
            this.today_rem_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.today_rem_datagrid.Size = new System.Drawing.Size(357, 245);
            this.today_rem_datagrid.TabIndex = 1;
            // 
            // upcoming_rem_datagrid
            // 
            this.upcoming_rem_datagrid.AllowUserToAddRows = false;
            this.upcoming_rem_datagrid.AllowUserToOrderColumns = true;
            this.upcoming_rem_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.upcoming_rem_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcoming_rem_datagrid.ColumnHeadersVisible = false;
            this.upcoming_rem_datagrid.ContextMenuStrip = this.contextMenuStrip3;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.upcoming_rem_datagrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.upcoming_rem_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcoming_rem_datagrid.Location = new System.Drawing.Point(3, 3);
            this.upcoming_rem_datagrid.MultiSelect = false;
            this.upcoming_rem_datagrid.Name = "upcoming_rem_datagrid";
            this.upcoming_rem_datagrid.ReadOnly = true;
            this.upcoming_rem_datagrid.RowHeadersVisible = false;
            this.upcoming_rem_datagrid.RowHeadersWidth = 51;
            this.upcoming_rem_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.upcoming_rem_datagrid.Size = new System.Drawing.Size(357, 245);
            this.upcoming_rem_datagrid.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 277);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.today_rem_datagrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Today\'s Reminders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.upcoming_rem_datagrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(363, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Reminders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewReminderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 277);
            this.panel1.TabIndex = 10;
            // 
            // addNewReminderToolStripMenuItem
            // 
            this.addNewReminderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewReminderToolStripMenuItem.Image")));
            this.addNewReminderToolStripMenuItem.Name = "addNewReminderToolStripMenuItem";
            this.addNewReminderToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.addNewReminderToolStripMenuItem.Text = "Add new reminder";
            this.addNewReminderToolStripMenuItem.Click += new System.EventHandler(this.addNewReminderToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // get_reminders
            // 
            this.get_reminders.WorkerSupportsCancellation = true;
            this.get_reminders.DoWork += new System.ComponentModel.DoWorkEventHandler(this.get_reminders_DoWork);
            this.get_reminders.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.get_reminders_RunWorkerCompleted);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(177, 30);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // deleteSelectedToolStripMenuItem1
            // 
            this.deleteSelectedToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteSelectedToolStripMenuItem1.Image")));
            this.deleteSelectedToolStripMenuItem1.Name = "deleteSelectedToolStripMenuItem1";
            this.deleteSelectedToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteSelectedToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.deleteSelectedToolStripMenuItem1.Text = "Delete Selected";
            this.deleteSelectedToolStripMenuItem1.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem1_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip2";
            this.contextMenuStrip3.Size = new System.Drawing.Size(177, 30);
            this.contextMenuStrip3.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip3_Opening);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 26);
            this.toolStripMenuItem2.Text = "Delete Selected";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Reminder_window_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reminder_window_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminders";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reminder_window_form_FormClosing);
            this.Load += new System.EventHandler(this.Reminder_window_form_Load);
            this.VisibleChanged += new System.EventHandler(this.Reminder_window_form_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.today_rem_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcoming_rem_datagrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView today_rem_datagrid;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView upcoming_rem_datagrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem addNewReminderToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker get_reminders;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}