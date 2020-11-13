//Ethan Smith

namespace Main_Application
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exitApplicationBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReadEncryptedFile = new System.Windows.Forms.Button();
            this.btnWriteEncryptedFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbFileOutput = new System.Windows.Forms.ListBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReadFromSql = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitApplicationBtn
            // 
            this.exitApplicationBtn.Location = new System.Drawing.Point(676, 407);
            this.exitApplicationBtn.Name = "exitApplicationBtn";
            this.exitApplicationBtn.Size = new System.Drawing.Size(112, 31);
            this.exitApplicationBtn.TabIndex = 0;
            this.exitApplicationBtn.Text = "Exit Application";
            this.exitApplicationBtn.UseVisualStyleBackColor = true;
            this.exitApplicationBtn.Click += new System.EventHandler(this.exitApplicationBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReadFromSql);
            this.panel1.Controls.Add(this.btnReadEncryptedFile);
            this.panel1.Controls.Add(this.btnWriteEncryptedFile);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 335);
            this.panel1.TabIndex = 4;
            // 
            // btnReadEncryptedFile
            // 
            this.btnReadEncryptedFile.Location = new System.Drawing.Point(22, 180);
            this.btnReadEncryptedFile.Name = "btnReadEncryptedFile";
            this.btnReadEncryptedFile.Size = new System.Drawing.Size(131, 42);
            this.btnReadEncryptedFile.TabIndex = 1;
            this.btnReadEncryptedFile.Text = "Read Encrypted File";
            this.btnReadEncryptedFile.UseVisualStyleBackColor = true;
            this.btnReadEncryptedFile.Click += new System.EventHandler(this.btnReadEncryptedFile_Click);
            // 
            // btnWriteEncryptedFile
            // 
            this.btnWriteEncryptedFile.Location = new System.Drawing.Point(22, 121);
            this.btnWriteEncryptedFile.Name = "btnWriteEncryptedFile";
            this.btnWriteEncryptedFile.Size = new System.Drawing.Size(131, 42);
            this.btnWriteEncryptedFile.TabIndex = 1;
            this.btnWriteEncryptedFile.Text = " Write Encrypted File";
            this.btnWriteEncryptedFile.UseVisualStyleBackColor = true;
            this.btnWriteEncryptedFile.Click += new System.EventHandler(this.btnWriteEncryptedFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(22, 69);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(131, 37);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open CSV File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbFileOutput);
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 335);
            this.panel2.TabIndex = 5;
            // 
            // lbFileOutput
            // 
            this.lbFileOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFileOutput.FormattingEnabled = true;
            this.lbFileOutput.ItemHeight = 15;
            this.lbFileOutput.Location = new System.Drawing.Point(0, 23);
            this.lbFileOutput.Name = "lbFileOutput";
            this.lbFileOutput.Size = new System.Drawing.Size(605, 312);
            this.lbFileOutput.TabIndex = 1;
            // 
            // txtFileName
            // 
            this.txtFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFileName.Location = new System.Drawing.Point(0, 0);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(605, 23);
            this.txtFileName.TabIndex = 0;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExitApplication.Location = new System.Drawing.Point(51, 282);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(230, 37);
            this.btnExitApplication.TabIndex = 6;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnExitApplication);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(487, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 335);
            this.panel3.TabIndex = 7;
            // 
            // ReadFromSql
            // 
            this.ReadFromSql.Location = new System.Drawing.Point(22, 237);
            this.ReadFromSql.Name = "ReadFromSql";
            this.ReadFromSql.Size = new System.Drawing.Size(131, 42);
            this.ReadFromSql.TabIndex = 1;
            this.ReadFromSql.Text = "Read From Sql";
            this.ReadFromSql.UseVisualStyleBackColor = true;
            this.ReadFromSql.Click += new System.EventHandler(this.btnReadFromSql_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitApplicationBtn;
            this.ClientSize = new System.Drawing.Size(780, 357);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exitApplicationBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.Text = "Master Assignment - Ethan Smith";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitApplicationBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ListBox lbFileOutput;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnReadEncryptedFile;
        private System.Windows.Forms.Button btnWriteEncryptedFile;
        private System.Windows.Forms.Button ReadFromSql;
    }
}

