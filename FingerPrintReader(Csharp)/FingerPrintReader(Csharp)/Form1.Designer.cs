namespace FingerPrintReader
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFingerPrint = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnAttandance = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.attendanceUC1 = new FingerPrintReader.UserControlUI.AttendanceUC();
            this.usersUC1 = new FingerPrintReader.UsersUC();
            this.fingerPrintViewerUC1 = new FingerPrintReader.FingerPrintViewerUC();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1147, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "welcome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFingerPrint);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalary);
            this.splitContainer1.Panel1.Controls.Add(this.btnAttandance);
            this.splitContainer1.Panel1.Controls.Add(this.btnUsers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.attendanceUC1);
            this.splitContainer1.Panel2.Controls.Add(this.usersUC1);
            this.splitContainer1.Panel2.Controls.Add(this.fingerPrintViewerUC1);
            this.splitContainer1.Size = new System.Drawing.Size(1147, 531);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnFingerPrint
            // 
            this.btnFingerPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFingerPrint.Location = new System.Drawing.Point(3, 101);
            this.btnFingerPrint.Name = "btnFingerPrint";
            this.btnFingerPrint.Size = new System.Drawing.Size(108, 50);
            this.btnFingerPrint.TabIndex = 3;
            this.btnFingerPrint.Text = "Finger Print";
            this.btnFingerPrint.UseVisualStyleBackColor = true;
            this.btnFingerPrint.Click += new System.EventHandler(this.btnFingerPrint_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalary.Location = new System.Drawing.Point(3, 150);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(108, 50);
            this.btnSalary.TabIndex = 4;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnAttandance
            // 
            this.btnAttandance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttandance.Location = new System.Drawing.Point(3, 52);
            this.btnAttandance.Name = "btnAttandance";
            this.btnAttandance.Size = new System.Drawing.Size(108, 50);
            this.btnAttandance.TabIndex = 2;
            this.btnAttandance.Text = "Attendace";
            this.btnAttandance.UseVisualStyleBackColor = true;
            this.btnAttandance.Click += new System.EventHandler(this.btnAttandance_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsers.Location = new System.Drawing.Point(3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(108, 50);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // attendanceUC1
            // 
            this.attendanceUC1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceUC1.Location = new System.Drawing.Point(65, 303);
            this.attendanceUC1.Margin = new System.Windows.Forms.Padding(4);
            this.attendanceUC1.Name = "attendanceUC1";
            this.attendanceUC1.Size = new System.Drawing.Size(323, 175);
            this.attendanceUC1.TabIndex = 2;
            // 
            // usersUC1
            // 
            this.usersUC1.Location = new System.Drawing.Point(434, 50);
            this.usersUC1.Name = "usersUC1";
            this.usersUC1.Size = new System.Drawing.Size(243, 226);
            this.usersUC1.TabIndex = 1;
            // 
            // fingerPrintViewerUC1
            // 
            this.fingerPrintViewerUC1.Location = new System.Drawing.Point(27, 16);
            this.fingerPrintViewerUC1.Name = "fingerPrintViewerUC1";
            this.fingerPrintViewerUC1.Size = new System.Drawing.Size(361, 260);
            this.fingerPrintViewerUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 577);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFingerPrint;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnAttandance;
        private System.Windows.Forms.Button btnUsers;
        private UsersUC usersUC1;
        private FingerPrintViewerUC fingerPrintViewerUC1;
        private UserControlUI.AttendanceUC attendanceUC1;
    }
}

