
namespace HariOmImpex_LMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.check_connectivity = new System.ComponentModel.BackgroundWorker();
            this.get_data = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveCurrentQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.query_ststxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.main_splitcontainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.add_user_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loading_box = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_mode_button = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleSearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCurrentViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.comboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.textBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.button2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.client_basic_datagrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCellValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.rem_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rem_split_container = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.today_rem_datagrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.upcoming_rem_datagrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.remindersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.create_backup_worker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.query_builder_worker = new System.ComponentModel.BackgroundWorker();
            this.update_query = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.check_reminders = new System.Windows.Forms.Timer(this.components);
            this.get_reminders = new System.ComponentModel.BackgroundWorker();
            this.sts_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.active_remiders = new System.Windows.Forms.ToolStripMenuItem();
            this.accessModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectivityCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uISizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryBuilderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.increase_font_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.decrease_font_btn = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.main_splitcontainer)).BeginInit();
            this.main_splitcontainer.Panel1.SuspendLayout();
            this.main_splitcontainer.Panel2.SuspendLayout();
            this.main_splitcontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_basic_datagrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.rem_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rem_split_container)).BeginInit();
            this.rem_split_container.Panel1.SuspendLayout();
            this.rem_split_container.Panel2.SuspendLayout();
            this.rem_split_container.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.today_rem_datagrid)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upcoming_rem_datagrid)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.DetectUrls = false;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(663, 61);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // check_connectivity
            // 
            this.check_connectivity.DoWork += new System.ComponentModel.DoWorkEventHandler(this.check_connectivity_DoWork);
            this.check_connectivity.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.check_connectivity_RunWorkerCompleted);
            // 
            // get_data
            // 
            this.get_data.WorkerReportsProgress = true;
            this.get_data.WorkerSupportsCancellation = true;
            this.get_data.DoWork += new System.ComponentModel.DoWorkEventHandler(this.get_data_DoWork);
            this.get_data.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.get_data_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveCurrentQueryToolStripMenuItem
            // 
            this.saveCurrentQueryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveCurrentQueryToolStripMenuItem.Image")));
            this.saveCurrentQueryToolStripMenuItem.Name = "saveCurrentQueryToolStripMenuItem";
            this.saveCurrentQueryToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.saveCurrentQueryToolStripMenuItem.Text = "Save current query";
            this.saveCurrentQueryToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentQueryToolStripMenuItem_Click);
            // 
            // savedQueriesToolStripMenuItem
            // 
            this.savedQueriesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.savedQueriesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("savedQueriesToolStripMenuItem.Image")));
            this.savedQueriesToolStripMenuItem.Name = "savedQueriesToolStripMenuItem";
            this.savedQueriesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.savedQueriesToolStripMenuItem.Text = "Query list";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // executeCommandToolStripMenuItem
            // 
            this.executeCommandToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("executeCommandToolStripMenuItem.Image")));
            this.executeCommandToolStripMenuItem.Name = "executeCommandToolStripMenuItem";
            this.executeCommandToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.executeCommandToolStripMenuItem.Text = "Execute Command";
            this.executeCommandToolStripMenuItem.Click += new System.EventHandler(this.executeCommandToolStripMenuItem_Click);
            // 
            // query_ststxt
            // 
            this.query_ststxt.Name = "query_ststxt";
            this.query_ststxt.Size = new System.Drawing.Size(10, 17);
            this.query_ststxt.Text = "-";
            // 
            // main_splitcontainer
            // 
            this.main_splitcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_splitcontainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.main_splitcontainer.Location = new System.Drawing.Point(0, 28);
            this.main_splitcontainer.Name = "main_splitcontainer";
            // 
            // main_splitcontainer.Panel1
            // 
            this.main_splitcontainer.Panel1.Controls.Add(this.splitContainer1);
            // 
            // main_splitcontainer.Panel2
            // 
            this.main_splitcontainer.Panel2.Controls.Add(this.rem_panel);
            this.main_splitcontainer.Size = new System.Drawing.Size(1020, 508);
            this.main_splitcontainer.SplitterDistance = 675;
            this.main_splitcontainer.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(675, 508);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.menuStrip2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(675, 47);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Table tools";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_user_btn,
            this.reloadDatabaseToolStripMenuItem,
            this.loading_box,
            this.edit_mode_button,
            this.toggleSearchToolStripMenuItem1,
            this.exportCurrentViewToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 17);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(669, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // add_user_btn
            // 
            this.add_user_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_user_btn.Image")));
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.add_user_btn.Size = new System.Drawing.Size(108, 23);
            this.add_user_btn.Text = "Add new client";
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_Click);
            // 
            // reloadDatabaseToolStripMenuItem
            // 
            this.reloadDatabaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadDatabaseToolStripMenuItem.Image")));
            this.reloadDatabaseToolStripMenuItem.Name = "reloadDatabaseToolStripMenuItem";
            this.reloadDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadDatabaseToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.reloadDatabaseToolStripMenuItem.Text = "Reload Database";
            // 
            // loading_box
            // 
            this.loading_box.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loading_box.Image = ((System.Drawing.Image)(resources.GetObject("loading_box.Image")));
            this.loading_box.Name = "loading_box";
            this.loading_box.Size = new System.Drawing.Size(76, 23);
            this.loading_box.Text = "Loading";
            this.loading_box.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.loading_box.Visible = false;
            // 
            // edit_mode_button
            // 
            this.edit_mode_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.edit_mode_button.BackColor = System.Drawing.Color.IndianRed;
            this.edit_mode_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_mode_button.Image")));
            this.edit_mode_button.Name = "edit_mode_button";
            this.edit_mode_button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.edit_mode_button.Size = new System.Drawing.Size(107, 23);
            this.edit_mode_button.Text = "Edit Mode (Off)";
            this.edit_mode_button.Click += new System.EventHandler(this.edit_mode_button_Click);
            // 
            // toggleSearchToolStripMenuItem1
            // 
            this.toggleSearchToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toggleSearchToolStripMenuItem1.Image")));
            this.toggleSearchToolStripMenuItem1.Name = "toggleSearchToolStripMenuItem1";
            this.toggleSearchToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.toggleSearchToolStripMenuItem1.Size = new System.Drawing.Size(102, 23);
            this.toggleSearchToolStripMenuItem1.Text = "Toggle Search";
            this.toggleSearchToolStripMenuItem1.Click += new System.EventHandler(this.toggleSearchToolStripMenuItem1_Click);
            // 
            // exportCurrentViewToolStripMenuItem
            // 
            this.exportCurrentViewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportCurrentViewToolStripMenuItem.Image")));
            this.exportCurrentViewToolStripMenuItem.Name = "exportCurrentViewToolStripMenuItem";
            this.exportCurrentViewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.exportCurrentViewToolStripMenuItem.Size = new System.Drawing.Size(130, 23);
            this.exportCurrentViewToolStripMenuItem.Text = "Export current view";
            this.exportCurrentViewToolStripMenuItem.Click += new System.EventHandler(this.exportCurrentViewToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(675, 457);
            this.splitContainer2.SplitterDistance = 54;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simple Search";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.comboBox1,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.textBox1,
            this.button2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(52, 24);
            this.toolStripLabel3.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 27);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(67, 24);
            this.toolStripLabel4.Text = "Search term:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 24);
            this.button2.Text = "Search";
            this.button2.ToolTipText = "Search";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data window";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 379);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 379);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.client_basic_datagrid);
            this.splitContainer3.Panel1.Controls.Add(this.menuStrip5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer3.Size = new System.Drawing.Size(669, 379);
            this.splitContainer3.SplitterDistance = 244;
            this.splitContainer3.TabIndex = 1;
            // 
            // client_basic_datagrid
            // 
            this.client_basic_datagrid.AllowUserToAddRows = false;
            this.client_basic_datagrid.AllowUserToDeleteRows = false;
            this.client_basic_datagrid.AllowUserToOrderColumns = true;
            this.client_basic_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.client_basic_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.client_basic_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.client_basic_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.client_basic_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_basic_datagrid.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.client_basic_datagrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.client_basic_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.client_basic_datagrid.Location = new System.Drawing.Point(0, 24);
            this.client_basic_datagrid.MultiSelect = false;
            this.client_basic_datagrid.Name = "client_basic_datagrid";
            this.client_basic_datagrid.ReadOnly = true;
            this.client_basic_datagrid.RowHeadersVisible = false;
            this.client_basic_datagrid.RowHeadersWidth = 51;
            this.client_basic_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.client_basic_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.client_basic_datagrid.ShowCellErrors = false;
            this.client_basic_datagrid.ShowCellToolTips = false;
            this.client_basic_datagrid.ShowEditingIcon = false;
            this.client_basic_datagrid.ShowRowErrors = false;
            this.client_basic_datagrid.Size = new System.Drawing.Size(669, 220);
            this.client_basic_datagrid.TabIndex = 2;
            this.client_basic_datagrid.ReadOnlyChanged += new System.EventHandler(this.client_basic_datagrid_ReadOnlyChanged);
            this.client_basic_datagrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.client_basic_datagrid_CellMouseClick);
            this.client_basic_datagrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.client_basic_datagrid_CellValidated);
            this.client_basic_datagrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.client_basic_datagrid_CellValueChanged);
            this.client_basic_datagrid.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.client_basic_datagrid_ColumnDisplayIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteSelectedToolStripMenuItem,
            this.copyCellValueToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 88);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.iDToolStripMenuItem.Text = "ID:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.deleteSelectedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteSelectedToolStripMenuItem.Image")));
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
            // 
            // copyCellValueToolStripMenuItem
            // 
            this.copyCellValueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyCellValueToolStripMenuItem.Image")));
            this.copyCellValueToolStripMenuItem.Name = "copyCellValueToolStripMenuItem";
            this.copyCellValueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.copyCellValueToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.copyCellValueToolStripMenuItem.Text = "Copy cell value";
            this.copyCellValueToolStripMenuItem.Click += new System.EventHandler(this.copyCellValueToolStripMenuItem_Click);
            // 
            // menuStrip5
            // 
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decrease_font_btn,
            this.increase_font_btn});
            this.menuStrip5.Location = new System.Drawing.Point(0, 0);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(669, 24);
            this.menuStrip5.TabIndex = 3;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel4);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(669, 131);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Query builder";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.statusStrip2);
            this.panel4.Controls.Add(this.menuStrip4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 111);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(663, 61);
            this.panel5.TabIndex = 3;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.query_ststxt});
            this.statusStrip2.Location = new System.Drawing.Point(0, 89);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(663, 22);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // menuStrip4
            // 
            this.menuStrip4.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeCommandToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.savedQueriesToolStripMenuItem,
            this.saveCurrentQueryToolStripMenuItem});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(663, 28);
            this.menuStrip4.TabIndex = 1;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // rem_panel
            // 
            this.rem_panel.Controls.Add(this.panel2);
            this.rem_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rem_panel.Location = new System.Drawing.Point(0, 0);
            this.rem_panel.Name = "rem_panel";
            this.rem_panel.Size = new System.Drawing.Size(341, 508);
            this.rem_panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rem_split_container);
            this.panel2.Controls.Add(this.menuStrip3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 508);
            this.panel2.TabIndex = 3;
            // 
            // rem_split_container
            // 
            this.rem_split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rem_split_container.Location = new System.Drawing.Point(0, 28);
            this.rem_split_container.Name = "rem_split_container";
            this.rem_split_container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rem_split_container.Panel1
            // 
            this.rem_split_container.Panel1.Controls.Add(this.groupBox3);
            // 
            // rem_split_container.Panel2
            // 
            this.rem_split_container.Panel2.Controls.Add(this.groupBox5);
            this.rem_split_container.Size = new System.Drawing.Size(339, 478);
            this.rem_split_container.SplitterDistance = 205;
            this.rem_split_container.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.today_rem_datagrid);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 205);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Today\'s Reminders";
            // 
            // today_rem_datagrid
            // 
            this.today_rem_datagrid.AllowUserToAddRows = false;
            this.today_rem_datagrid.AllowUserToOrderColumns = true;
            this.today_rem_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.today_rem_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.today_rem_datagrid.ColumnHeadersVisible = false;
            this.today_rem_datagrid.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.today_rem_datagrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.today_rem_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.today_rem_datagrid.Location = new System.Drawing.Point(3, 17);
            this.today_rem_datagrid.MultiSelect = false;
            this.today_rem_datagrid.Name = "today_rem_datagrid";
            this.today_rem_datagrid.ReadOnly = true;
            this.today_rem_datagrid.RowHeadersVisible = false;
            this.today_rem_datagrid.RowHeadersWidth = 51;
            this.today_rem_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.today_rem_datagrid.Size = new System.Drawing.Size(333, 185);
            this.today_rem_datagrid.TabIndex = 1;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.upcoming_rem_datagrid);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 269);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "All Reminders";
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
            this.upcoming_rem_datagrid.Location = new System.Drawing.Point(3, 17);
            this.upcoming_rem_datagrid.MultiSelect = false;
            this.upcoming_rem_datagrid.Name = "upcoming_rem_datagrid";
            this.upcoming_rem_datagrid.ReadOnly = true;
            this.upcoming_rem_datagrid.RowHeadersVisible = false;
            this.upcoming_rem_datagrid.RowHeadersWidth = 51;
            this.upcoming_rem_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.upcoming_rem_datagrid.Size = new System.Drawing.Size(333, 249);
            this.upcoming_rem_datagrid.TabIndex = 1;
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
            // menuStrip3
            // 
            this.menuStrip3.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remindersToolStripMenuItem1,
            this.addNewToolStripMenuItem2});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(339, 28);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // remindersToolStripMenuItem1
            // 
            this.remindersToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.remindersToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("remindersToolStripMenuItem1.Image")));
            this.remindersToolStripMenuItem1.Name = "remindersToolStripMenuItem1";
            this.remindersToolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.remindersToolStripMenuItem1.Text = "Reminders";
            // 
            // addNewToolStripMenuItem2
            // 
            this.addNewToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addNewToolStripMenuItem2.AutoToolTip = true;
            this.addNewToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("addNewToolStripMenuItem2.Image")));
            this.addNewToolStripMenuItem2.Name = "addNewToolStripMenuItem2";
            this.addNewToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.addNewToolStripMenuItem2.Size = new System.Drawing.Size(32, 24);
            this.addNewToolStripMenuItem2.Text = "Add new";
            this.addNewToolStripMenuItem2.ToolTipText = "Add new";
            this.addNewToolStripMenuItem2.Click += new System.EventHandler(this.addNewToolStripMenuItem2_Click);
            // 
            // create_backup_worker
            // 
            this.create_backup_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.create_backup_worker_DoWork);
            this.create_backup_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.create_backup_worker_RunWorkerCompleted);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "view_export";
            this.saveFileDialog1.Title = "Select location to export";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // query_builder_worker
            // 
            this.query_builder_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.query_builder_worker_DoWork);
            this.query_builder_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.query_builder_worker_RunWorkerCompleted);
            // 
            // update_query
            // 
            this.update_query.WorkerSupportsCancellation = true;
            this.update_query.DoWork += new System.ComponentModel.DoWorkEventHandler(this.update_query_DoWork);
            this.update_query.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.update_query_RunWorkerCompleted);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*.db";
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Rajja Logistics";
            this.notifyIcon1.Visible = true;
            // 
            // check_reminders
            // 
            this.check_reminders.Enabled = true;
            this.check_reminders.Interval = 1800000;
            this.check_reminders.Tick += new System.EventHandler(this.check_reminders_Tick);
            // 
            // get_reminders
            // 
            this.get_reminders.WorkerSupportsCancellation = true;
            this.get_reminders.DoWork += new System.ComponentModel.DoWorkEventHandler(this.get_reminders_DoWork);
            this.get_reminders.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.get_reminders_RunWorkerCompleted);
            // 
            // sts_txt
            // 
            this.sts_txt.Name = "sts_txt";
            this.sts_txt.Size = new System.Drawing.Size(10, 17);
            this.sts_txt.Text = "-";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sts_txt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1020, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // active_remiders
            // 
            this.active_remiders.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.active_remiders.Image = ((System.Drawing.Image)(resources.GetObject("active_remiders.Image")));
            this.active_remiders.Name = "active_remiders";
            this.active_remiders.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.active_remiders.Size = new System.Drawing.Size(90, 24);
            this.active_remiders.Text = "Reminders";
            this.active_remiders.Click += new System.EventHandler(this.active_remiders_Click);
            // 
            // accessModeToolStripMenuItem
            // 
            this.accessModeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.accessModeToolStripMenuItem.Name = "accessModeToolStripMenuItem";
            this.accessModeToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.accessModeToolStripMenuItem.Text = "Access mode:";
            // 
            // changelogsToolStripMenuItem
            // 
            this.changelogsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changelogsToolStripMenuItem.Image")));
            this.changelogsToolStripMenuItem.Name = "changelogsToolStripMenuItem";
            this.changelogsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.changelogsToolStripMenuItem.Text = "Changelogs";
            this.changelogsToolStripMenuItem.Click += new System.EventHandler(this.changelogsToolStripMenuItem_Click);
            // 
            // shortcutsListToolStripMenuItem
            // 
            this.shortcutsListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shortcutsListToolStripMenuItem.Image")));
            this.shortcutsListToolStripMenuItem.Name = "shortcutsListToolStripMenuItem";
            this.shortcutsListToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.shortcutsListToolStripMenuItem.Text = "Shortcuts list";
            this.shortcutsListToolStripMenuItem.Click += new System.EventHandler(this.shortcutsListToolStripMenuItem_Click);
            // 
            // connectivityCheckToolStripMenuItem
            // 
            this.connectivityCheckToolStripMenuItem.Enabled = false;
            this.connectivityCheckToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectivityCheckToolStripMenuItem.Image")));
            this.connectivityCheckToolStripMenuItem.Name = "connectivityCheckToolStripMenuItem";
            this.connectivityCheckToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.connectivityCheckToolStripMenuItem.Text = "Connectivity check";
            this.connectivityCheckToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectivityCheckToolStripMenuItem,
            this.aboutApplicationToolStripMenuItem,
            this.shortcutsListToolStripMenuItem,
            this.changelogsToolStripMenuItem});
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutApplicationToolStripMenuItem
            // 
            this.aboutApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutApplicationToolStripMenuItem.Image")));
            this.aboutApplicationToolStripMenuItem.Name = "aboutApplicationToolStripMenuItem";
            this.aboutApplicationToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.aboutApplicationToolStripMenuItem.Text = "About Application";
            this.aboutApplicationToolStripMenuItem.Click += new System.EventHandler(this.aboutApplicationToolStripMenuItem_Click);
            // 
            // bigToolStripMenuItem
            // 
            this.bigToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bigToolStripMenuItem.Image")));
            this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
            this.bigToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.bigToolStripMenuItem.ShowShortcutKeys = false;
            this.bigToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.bigToolStripMenuItem.Text = "Big";
            this.bigToolStripMenuItem.Click += new System.EventHandler(this.bigToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("defaultToolStripMenuItem.Image")));
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.defaultToolStripMenuItem.ShowShortcutKeys = false;
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // uISizeToolStripMenuItem
            // 
            this.uISizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.bigToolStripMenuItem});
            this.uISizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uISizeToolStripMenuItem.Image")));
            this.uISizeToolStripMenuItem.Name = "uISizeToolStripMenuItem";
            this.uISizeToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.uISizeToolStripMenuItem.Text = "UI size";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.ToolTipText = "Application settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // backupManagerToolStripMenuItem
            // 
            this.backupManagerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backupManagerToolStripMenuItem.Image")));
            this.backupManagerToolStripMenuItem.Name = "backupManagerToolStripMenuItem";
            this.backupManagerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backupManagerToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.backupManagerToolStripMenuItem.Text = "Backup Manager";
            this.backupManagerToolStripMenuItem.ToolTipText = "Create and manage your backups";
            this.backupManagerToolStripMenuItem.Click += new System.EventHandler(this.backupManagerToolStripMenuItem_Click);
            // 
            // queryBuilderToolStripMenuItem
            // 
            this.queryBuilderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("queryBuilderToolStripMenuItem.Image")));
            this.queryBuilderToolStripMenuItem.Name = "queryBuilderToolStripMenuItem";
            this.queryBuilderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.queryBuilderToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.queryBuilderToolStripMenuItem.Text = "Query Builder";
            this.queryBuilderToolStripMenuItem.Click += new System.EventHandler(this.queryBuilderToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryBuilderToolStripMenuItem,
            this.backupManagerToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.uISizeToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.accessModeToolStripMenuItem,
            this.active_remiders});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // increase_font_btn
            // 
            this.increase_font_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.increase_font_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increase_font_btn.Image = ((System.Drawing.Image)(resources.GetObject("increase_font_btn.Image")));
            this.increase_font_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increase_font_btn.Name = "increase_font_btn";
            this.increase_font_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.increase_font_btn.Size = new System.Drawing.Size(28, 20);
            this.increase_font_btn.Text = "toolStripButton2";
            this.increase_font_btn.ToolTipText = "Increase font size";
            this.increase_font_btn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // decrease_font_btn
            // 
            this.decrease_font_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.decrease_font_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decrease_font_btn.Image = ((System.Drawing.Image)(resources.GetObject("decrease_font_btn.Image")));
            this.decrease_font_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decrease_font_btn.Name = "decrease_font_btn";
            this.decrease_font_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.decrease_font_btn.Size = new System.Drawing.Size(28, 20);
            this.decrease_font_btn.Text = "toolStripButton3";
            this.decrease_font_btn.ToolTipText = "Decrease font size";
            this.decrease_font_btn.Click += new System.EventHandler(this.decrease_font_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 558);
            this.Controls.Add(this.main_splitcontainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.MainMenuStrip = this.menuStrip5;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.main_splitcontainer.Panel1.ResumeLayout(false);
            this.main_splitcontainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_splitcontainer)).EndInit();
            this.main_splitcontainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.client_basic_datagrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.rem_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.rem_split_container.Panel1.ResumeLayout(false);
            this.rem_split_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rem_split_container)).EndInit();
            this.rem_split_container.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.today_rem_datagrid)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upcoming_rem_datagrid)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox2;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker check_connectivity;
        private System.ComponentModel.BackgroundWorker get_data;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savedQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel query_ststxt;
        private System.Windows.Forms.SplitContainer main_splitcontainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem add_user_btn;
        private System.Windows.Forms.ToolStripMenuItem reloadDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loading_box;
        private System.Windows.Forms.ToolStripMenuItem edit_mode_button;
        private System.Windows.Forms.ToolStripMenuItem toggleSearchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentViewToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox comboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox textBox1;
        private System.Windows.Forms.ToolStripButton button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        public System.Windows.Forms.DataGridView client_basic_datagrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCellValueToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.Panel rem_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer rem_split_container;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView today_rem_datagrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.DataGridView upcoming_rem_datagrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem remindersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem2;
        private System.ComponentModel.BackgroundWorker create_backup_worker;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker query_builder_worker;
        private System.ComponentModel.BackgroundWorker update_query;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sts_txt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem queryBuilderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uISizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectivityCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem active_remiders;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer check_reminders;
        private System.ComponentModel.BackgroundWorker get_reminders;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem decrease_font_btn;
        private System.Windows.Forms.ToolStripMenuItem increase_font_btn;
    }
}

