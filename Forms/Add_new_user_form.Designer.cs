
namespace HariOmImpex_LMS.Forms
{
    partial class Add_new_user_form
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_txtbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.af_bm_checkBox = new System.Windows.Forms.CheckBox();
            this.af_al_checkBox = new System.Windows.Forms.CheckBox();
            this.af_qb_checkBox = new System.Windows.Forms.CheckBox();
            this.af_set_checkBox = new System.Windows.Forms.CheckBox();
            this.af_ad_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.do_anc_checkBox = new System.Windows.Forms.CheckBox();
            this.do_dr_checkBox = new System.Windows.Forms.CheckBox();
            this.do_dce_checkBox = new System.Windows.Forms.CheckBox();
            this.do_anr_checkBox = new System.Windows.Forms.CheckBox();
            this.do_ecd_checkBox = new System.Windows.Forms.CheckBox();
            this.do_mcd_checkBox = new System.Windows.Forms.CheckBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(279, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 349);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.password_txtbx);
            this.groupBox1.Controls.Add(this.username_txtbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User details";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(8, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Access points";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // username_txtbx
            // 
            this.username_txtbx.Location = new System.Drawing.Point(77, 19);
            this.username_txtbx.Name = "username_txtbx";
            this.username_txtbx.Size = new System.Drawing.Size(173, 21);
            this.username_txtbx.TabIndex = 3;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(77, 47);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(173, 21);
            this.password_txtbx.TabIndex = 4;
            // 
            // af_bm_checkBox
            // 
            this.af_bm_checkBox.AutoSize = true;
            this.af_bm_checkBox.Location = new System.Drawing.Point(12, 20);
            this.af_bm_checkBox.Name = "af_bm_checkBox";
            this.af_bm_checkBox.Size = new System.Drawing.Size(104, 17);
            this.af_bm_checkBox.TabIndex = 0;
            this.af_bm_checkBox.Text = "Backup manager";
            this.af_bm_checkBox.UseVisualStyleBackColor = true;
            // 
            // af_al_checkBox
            // 
            this.af_al_checkBox.AutoSize = true;
            this.af_al_checkBox.Location = new System.Drawing.Point(12, 43);
            this.af_al_checkBox.Name = "af_al_checkBox";
            this.af_al_checkBox.Size = new System.Drawing.Size(76, 17);
            this.af_al_checkBox.TabIndex = 1;
            this.af_al_checkBox.Text = "Activity log";
            this.af_al_checkBox.UseVisualStyleBackColor = true;
            // 
            // af_qb_checkBox
            // 
            this.af_qb_checkBox.AutoSize = true;
            this.af_qb_checkBox.Location = new System.Drawing.Point(135, 43);
            this.af_qb_checkBox.Name = "af_qb_checkBox";
            this.af_qb_checkBox.Size = new System.Drawing.Size(90, 17);
            this.af_qb_checkBox.TabIndex = 2;
            this.af_qb_checkBox.Text = "Query builder";
            this.af_qb_checkBox.UseVisualStyleBackColor = true;
            // 
            // af_set_checkBox
            // 
            this.af_set_checkBox.AutoSize = true;
            this.af_set_checkBox.Location = new System.Drawing.Point(12, 66);
            this.af_set_checkBox.Name = "af_set_checkBox";
            this.af_set_checkBox.Size = new System.Drawing.Size(62, 17);
            this.af_set_checkBox.TabIndex = 3;
            this.af_set_checkBox.Text = "Settings";
            this.af_set_checkBox.UseVisualStyleBackColor = true;
            // 
            // af_ad_checkBox
            // 
            this.af_ad_checkBox.AutoSize = true;
            this.af_ad_checkBox.Location = new System.Drawing.Point(135, 20);
            this.af_ad_checkBox.Name = "af_ad_checkBox";
            this.af_ad_checkBox.Size = new System.Drawing.Size(109, 17);
            this.af_ad_checkBox.TabIndex = 4;
            this.af_ad_checkBox.Text = "Admin dashboard";
            this.af_ad_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.af_bm_checkBox);
            this.groupBox3.Controls.Add(this.af_ad_checkBox);
            this.groupBox3.Controls.Add(this.af_al_checkBox);
            this.groupBox3.Controls.Add(this.af_set_checkBox);
            this.groupBox3.Controls.Add(this.af_qb_checkBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 93);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application features";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.do_mcd_checkBox);
            this.groupBox4.Controls.Add(this.do_anc_checkBox);
            this.groupBox4.Controls.Add(this.do_dr_checkBox);
            this.groupBox4.Controls.Add(this.do_dce_checkBox);
            this.groupBox4.Controls.Add(this.do_anr_checkBox);
            this.groupBox4.Controls.Add(this.do_ecd_checkBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 95);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database operations";
            // 
            // do_anc_checkBox
            // 
            this.do_anc_checkBox.AutoSize = true;
            this.do_anc_checkBox.Location = new System.Drawing.Point(12, 20);
            this.do_anc_checkBox.Name = "do_anc_checkBox";
            this.do_anc_checkBox.Size = new System.Drawing.Size(95, 17);
            this.do_anc_checkBox.TabIndex = 0;
            this.do_anc_checkBox.Text = "Add new client";
            this.do_anc_checkBox.UseVisualStyleBackColor = true;
            // 
            // do_dr_checkBox
            // 
            this.do_dr_checkBox.AutoSize = true;
            this.do_dr_checkBox.Location = new System.Drawing.Point(135, 20);
            this.do_dr_checkBox.Name = "do_dr_checkBox";
            this.do_dr_checkBox.Size = new System.Drawing.Size(109, 17);
            this.do_dr_checkBox.TabIndex = 4;
            this.do_dr_checkBox.Text = "Delete reminders";
            this.do_dr_checkBox.UseVisualStyleBackColor = true;
            // 
            // do_dce_checkBox
            // 
            this.do_dce_checkBox.AutoSize = true;
            this.do_dce_checkBox.Location = new System.Drawing.Point(12, 43);
            this.do_dce_checkBox.Name = "do_dce_checkBox";
            this.do_dce_checkBox.Size = new System.Drawing.Size(114, 17);
            this.do_dce_checkBox.TabIndex = 1;
            this.do_dce_checkBox.Text = "Delete client entry";
            this.do_dce_checkBox.UseVisualStyleBackColor = true;
            // 
            // do_anr_checkBox
            // 
            this.do_anr_checkBox.AutoSize = true;
            this.do_anr_checkBox.Location = new System.Drawing.Point(135, 43);
            this.do_anr_checkBox.Name = "do_anr_checkBox";
            this.do_anr_checkBox.Size = new System.Drawing.Size(112, 17);
            this.do_anr_checkBox.TabIndex = 3;
            this.do_anr_checkBox.Text = "Add new reminder";
            this.do_anr_checkBox.UseVisualStyleBackColor = true;
            // 
            // do_ecd_checkBox
            // 
            this.do_ecd_checkBox.AutoSize = true;
            this.do_ecd_checkBox.Location = new System.Drawing.Point(135, 66);
            this.do_ecd_checkBox.Name = "do_ecd_checkBox";
            this.do_ecd_checkBox.Size = new System.Drawing.Size(109, 17);
            this.do_ecd_checkBox.TabIndex = 2;
            this.do_ecd_checkBox.Text = "Export client data";
            this.do_ecd_checkBox.UseVisualStyleBackColor = true;
            // 
            // do_mcd_checkBox
            // 
            this.do_mcd_checkBox.AutoSize = true;
            this.do_mcd_checkBox.Location = new System.Drawing.Point(12, 66);
            this.do_mcd_checkBox.Name = "do_mcd_checkBox";
            this.do_mcd_checkBox.Size = new System.Drawing.Size(111, 17);
            this.do_mcd_checkBox.TabIndex = 5;
            this.do_mcd_checkBox.Text = "Modify client data";
            this.do_mcd_checkBox.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // Add_new_user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.Name = "Add_new_user_form";
            this.Text = "Add new user";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox af_ad_checkBox;
        private System.Windows.Forms.CheckBox af_set_checkBox;
        private System.Windows.Forms.CheckBox af_qb_checkBox;
        private System.Windows.Forms.CheckBox af_al_checkBox;
        private System.Windows.Forms.CheckBox af_bm_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox do_mcd_checkBox;
        private System.Windows.Forms.CheckBox do_anc_checkBox;
        private System.Windows.Forms.CheckBox do_dr_checkBox;
        private System.Windows.Forms.CheckBox do_dce_checkBox;
        private System.Windows.Forms.CheckBox do_anr_checkBox;
        private System.Windows.Forms.CheckBox do_ecd_checkBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}