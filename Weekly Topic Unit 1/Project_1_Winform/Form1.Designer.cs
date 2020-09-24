namespace Project_1_Winform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnMessageBoxPopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(221, 256);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(152, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit the Application";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnMessageBoxPopup
            // 
            this.btnMessageBoxPopup.Location = new System.Drawing.Point(12, 149);
            this.btnMessageBoxPopup.Name = "btnMessageBoxPopup";
            this.btnMessageBoxPopup.Size = new System.Drawing.Size(200, 23);
            this.btnMessageBoxPopup.TabIndex = 2;
            this.btnMessageBoxPopup.Text = "Message Box Popup";
            this.btnMessageBoxPopup.UseVisualStyleBackColor = true;
            this.btnMessageBoxPopup.Click += new System.EventHandler(this.btnMessageBoxPopup_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMessageBoxPopup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(385, 291);
            this.Controls.Add(this.btnMessageBoxPopup);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Project 1 - Ethan Smith";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btnMessageBoxPopup;
    }
}

