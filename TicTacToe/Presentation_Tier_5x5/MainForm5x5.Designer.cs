namespace Presentation_Tier_5x5
{
    //Ethan Smith

    partial class MainForm5x5
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartNewGame = new System.Windows.Forms.Button();
            this.btnGoComputer = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnCell00 = new System.Windows.Forms.Button();
            this.btnCell01 = new System.Windows.Forms.Button();
            this.btnCell02 = new System.Windows.Forms.Button();
            this.btnCell10 = new System.Windows.Forms.Button();
            this.btnCell11 = new System.Windows.Forms.Button();
            this.btnCell12 = new System.Windows.Forms.Button();
            this.btnCell20 = new System.Windows.Forms.Button();
            this.btnCell21 = new System.Windows.Forms.Button();
            this.btnWild = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCell04 = new System.Windows.Forms.Button();
            this.btnCell03 = new System.Windows.Forms.Button();
            this.btnCell23 = new System.Windows.Forms.Button();
            this.btnCell24 = new System.Windows.Forms.Button();
            this.btnCell13 = new System.Windows.Forms.Button();
            this.btnCell14 = new System.Windows.Forms.Button();
            this.btnCell30 = new System.Windows.Forms.Button();
            this.btnCell31 = new System.Windows.Forms.Button();
            this.btnCell32 = new System.Windows.Forms.Button();
            this.btnCell33 = new System.Windows.Forms.Button();
            this.btnCell34 = new System.Windows.Forms.Button();
            this.btnCell40 = new System.Windows.Forms.Button();
            this.btnCell41 = new System.Windows.Forms.Button();
            this.btnCell42 = new System.Windows.Forms.Button();
            this.btnCell43 = new System.Windows.Forms.Button();
            this.btnCell44 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit Tic Tac Toe";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.Location = new System.Drawing.Point(13, 53);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(132, 38);
            this.btnStartNewGame.TabIndex = 2;
            this.btnStartNewGame.Text = "Start New Game";
            this.btnStartNewGame.UseVisualStyleBackColor = true;
            this.btnStartNewGame.Click += new System.EventHandler(this.btnStartNewGame_Click);
            // 
            // btnGoComputer
            // 
            this.btnGoComputer.Location = new System.Drawing.Point(13, 107);
            this.btnGoComputer.Name = "btnGoComputer";
            this.btnGoComputer.Size = new System.Drawing.Size(132, 38);
            this.btnGoComputer.TabIndex = 3;
            this.btnGoComputer.Text = "GO! Computer";
            this.btnGoComputer.UseVisualStyleBackColor = true;
            this.btnGoComputer.Click += new System.EventHandler(this.btnGoComputer_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(13, 13);
            this.txtPlayerName.MaxLength = 25;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(287, 23);
            this.txtPlayerName.TabIndex = 4;
            this.txtPlayerName.Text = "Ethan";
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            this.txtPlayerName.Validated += new System.EventHandler(this.txtPlayerName_Validated);
            // 
            // btnCell00
            // 
            this.btnCell00.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell00.Location = new System.Drawing.Point(11, 0);
            this.btnCell00.Name = "btnCell00";
            this.btnCell00.Size = new System.Drawing.Size(75, 75);
            this.btnCell00.TabIndex = 5;
            this.btnCell00.Text = "?";
            this.btnCell00.UseVisualStyleBackColor = true;
            this.btnCell00.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell01
            // 
            this.btnCell01.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell01.Location = new System.Drawing.Point(105, 0);
            this.btnCell01.Name = "btnCell01";
            this.btnCell01.Size = new System.Drawing.Size(75, 75);
            this.btnCell01.TabIndex = 5;
            this.btnCell01.Text = "?";
            this.btnCell01.UseVisualStyleBackColor = true;
            this.btnCell01.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell02
            // 
            this.btnCell02.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell02.Location = new System.Drawing.Point(196, 0);
            this.btnCell02.Name = "btnCell02";
            this.btnCell02.Size = new System.Drawing.Size(75, 75);
            this.btnCell02.TabIndex = 5;
            this.btnCell02.Text = "?";
            this.btnCell02.UseVisualStyleBackColor = true;
            this.btnCell02.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell10
            // 
            this.btnCell10.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell10.Location = new System.Drawing.Point(11, 95);
            this.btnCell10.Name = "btnCell10";
            this.btnCell10.Size = new System.Drawing.Size(75, 75);
            this.btnCell10.TabIndex = 5;
            this.btnCell10.Text = "?";
            this.btnCell10.UseVisualStyleBackColor = true;
            this.btnCell10.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell11
            // 
            this.btnCell11.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell11.Location = new System.Drawing.Point(105, 95);
            this.btnCell11.Name = "btnCell11";
            this.btnCell11.Size = new System.Drawing.Size(75, 75);
            this.btnCell11.TabIndex = 5;
            this.btnCell11.Text = "?";
            this.btnCell11.UseVisualStyleBackColor = true;
            this.btnCell11.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell12
            // 
            this.btnCell12.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell12.Location = new System.Drawing.Point(196, 95);
            this.btnCell12.Name = "btnCell12";
            this.btnCell12.Size = new System.Drawing.Size(75, 75);
            this.btnCell12.TabIndex = 5;
            this.btnCell12.Text = "?";
            this.btnCell12.UseVisualStyleBackColor = true;
            this.btnCell12.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell20
            // 
            this.btnCell20.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell20.Location = new System.Drawing.Point(11, 190);
            this.btnCell20.Name = "btnCell20";
            this.btnCell20.Size = new System.Drawing.Size(75, 75);
            this.btnCell20.TabIndex = 5;
            this.btnCell20.Text = "?";
            this.btnCell20.UseVisualStyleBackColor = true;
            this.btnCell20.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell21
            // 
            this.btnCell21.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell21.Location = new System.Drawing.Point(105, 190);
            this.btnCell21.Name = "btnCell21";
            this.btnCell21.Size = new System.Drawing.Size(75, 75);
            this.btnCell21.TabIndex = 5;
            this.btnCell21.Text = "?";
            this.btnCell21.UseVisualStyleBackColor = true;
            this.btnCell21.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnWild
            // 
            this.btnWild.Enabled = false;
            this.btnWild.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWild.Location = new System.Drawing.Point(196, 190);
            this.btnWild.Name = "btnWild";
            this.btnWild.Size = new System.Drawing.Size(75, 75);
            this.btnWild.TabIndex = 5;
            this.btnWild.Text = "WILD";
            this.btnWild.UseVisualStyleBackColor = true;
            this.btnWild.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCell44);
            this.panel1.Controls.Add(this.btnCell43);
            this.panel1.Controls.Add(this.btnCell42);
            this.panel1.Controls.Add(this.btnCell41);
            this.panel1.Controls.Add(this.btnCell40);
            this.panel1.Controls.Add(this.btnCell34);
            this.panel1.Controls.Add(this.btnCell33);
            this.panel1.Controls.Add(this.btnCell32);
            this.panel1.Controls.Add(this.btnCell31);
            this.panel1.Controls.Add(this.btnCell30);
            this.panel1.Controls.Add(this.btnCell14);
            this.panel1.Controls.Add(this.btnCell13);
            this.panel1.Controls.Add(this.btnCell24);
            this.panel1.Controls.Add(this.btnCell23);
            this.panel1.Controls.Add(this.btnCell04);
            this.panel1.Controls.Add(this.btnCell03);
            this.panel1.Controls.Add(this.btnCell02);
            this.panel1.Controls.Add(this.btnCell20);
            this.panel1.Controls.Add(this.btnCell21);
            this.panel1.Controls.Add(this.btnWild);
            this.panel1.Controls.Add(this.btnCell00);
            this.panel1.Controls.Add(this.btnCell01);
            this.panel1.Controls.Add(this.btnCell12);
            this.panel1.Controls.Add(this.btnCell10);
            this.panel1.Controls.Add(this.btnCell11);
            this.panel1.Location = new System.Drawing.Point(246, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 471);
            this.panel1.TabIndex = 6;
            // 
            // btnCell04
            // 
            this.btnCell04.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell04.Location = new System.Drawing.Point(380, 0);
            this.btnCell04.Name = "btnCell04";
            this.btnCell04.Size = new System.Drawing.Size(75, 75);
            this.btnCell04.TabIndex = 5;
            this.btnCell04.Text = "?";
            this.btnCell04.UseVisualStyleBackColor = true;
            this.btnCell04.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell03
            // 
            this.btnCell03.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell03.Location = new System.Drawing.Point(290, 0);
            this.btnCell03.Name = "btnCell03";
            this.btnCell03.Size = new System.Drawing.Size(75, 75);
            this.btnCell03.TabIndex = 5;
            this.btnCell03.Text = "?";
            this.btnCell03.UseVisualStyleBackColor = true;
            this.btnCell03.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell23
            // 
            this.btnCell23.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell23.Location = new System.Drawing.Point(290, 190);
            this.btnCell23.Name = "btnCell23";
            this.btnCell23.Size = new System.Drawing.Size(75, 75);
            this.btnCell23.TabIndex = 5;
            this.btnCell23.Text = "?";
            this.btnCell23.UseVisualStyleBackColor = true;
            this.btnCell23.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell24
            // 
            this.btnCell24.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell24.Location = new System.Drawing.Point(380, 190);
            this.btnCell24.Name = "btnCell24";
            this.btnCell24.Size = new System.Drawing.Size(75, 75);
            this.btnCell24.TabIndex = 5;
            this.btnCell24.Text = "?";
            this.btnCell24.UseVisualStyleBackColor = true;
            this.btnCell24.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell13
            // 
            this.btnCell13.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell13.Location = new System.Drawing.Point(290, 95);
            this.btnCell13.Name = "btnCell13";
            this.btnCell13.Size = new System.Drawing.Size(75, 75);
            this.btnCell13.TabIndex = 5;
            this.btnCell13.Text = "?";
            this.btnCell13.UseVisualStyleBackColor = true;
            this.btnCell13.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell14
            // 
            this.btnCell14.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell14.Location = new System.Drawing.Point(380, 95);
            this.btnCell14.Name = "btnCell14";
            this.btnCell14.Size = new System.Drawing.Size(75, 75);
            this.btnCell14.TabIndex = 5;
            this.btnCell14.Text = "?";
            this.btnCell14.UseVisualStyleBackColor = true;
            this.btnCell14.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell30
            // 
            this.btnCell30.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell30.Location = new System.Drawing.Point(11, 287);
            this.btnCell30.Name = "btnCell30";
            this.btnCell30.Size = new System.Drawing.Size(75, 75);
            this.btnCell30.TabIndex = 5;
            this.btnCell30.Text = "?";
            this.btnCell30.UseVisualStyleBackColor = true;
            this.btnCell30.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell31
            // 
            this.btnCell31.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell31.Location = new System.Drawing.Point(105, 287);
            this.btnCell31.Name = "btnCell31";
            this.btnCell31.Size = new System.Drawing.Size(75, 75);
            this.btnCell31.TabIndex = 5;
            this.btnCell31.Text = "?";
            this.btnCell31.UseVisualStyleBackColor = true;
            this.btnCell31.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell32
            // 
            this.btnCell32.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell32.Location = new System.Drawing.Point(196, 287);
            this.btnCell32.Name = "btnCell32";
            this.btnCell32.Size = new System.Drawing.Size(75, 75);
            this.btnCell32.TabIndex = 5;
            this.btnCell32.Text = "?";
            this.btnCell32.UseVisualStyleBackColor = true;
            this.btnCell32.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell33
            // 
            this.btnCell33.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell33.Location = new System.Drawing.Point(290, 287);
            this.btnCell33.Name = "btnCell33";
            this.btnCell33.Size = new System.Drawing.Size(75, 75);
            this.btnCell33.TabIndex = 5;
            this.btnCell33.Text = "?";
            this.btnCell33.UseVisualStyleBackColor = true;
            this.btnCell33.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell34
            // 
            this.btnCell34.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell34.Location = new System.Drawing.Point(380, 287);
            this.btnCell34.Name = "btnCell34";
            this.btnCell34.Size = new System.Drawing.Size(75, 75);
            this.btnCell34.TabIndex = 5;
            this.btnCell34.Text = "?";
            this.btnCell34.UseVisualStyleBackColor = true;
            this.btnCell34.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell40
            // 
            this.btnCell40.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell40.Location = new System.Drawing.Point(11, 382);
            this.btnCell40.Name = "btnCell40";
            this.btnCell40.Size = new System.Drawing.Size(75, 75);
            this.btnCell40.TabIndex = 5;
            this.btnCell40.Text = "?";
            this.btnCell40.UseVisualStyleBackColor = true;
            this.btnCell40.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell41
            // 
            this.btnCell41.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell41.Location = new System.Drawing.Point(105, 382);
            this.btnCell41.Name = "btnCell41";
            this.btnCell41.Size = new System.Drawing.Size(75, 75);
            this.btnCell41.TabIndex = 5;
            this.btnCell41.Text = "?";
            this.btnCell41.UseVisualStyleBackColor = true;
            this.btnCell41.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell42
            // 
            this.btnCell42.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell42.Location = new System.Drawing.Point(196, 382);
            this.btnCell42.Name = "btnCell42";
            this.btnCell42.Size = new System.Drawing.Size(75, 75);
            this.btnCell42.TabIndex = 5;
            this.btnCell42.Text = "?";
            this.btnCell42.UseVisualStyleBackColor = true;
            this.btnCell42.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell43
            // 
            this.btnCell43.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell43.Location = new System.Drawing.Point(290, 382);
            this.btnCell43.Name = "btnCell43";
            this.btnCell43.Size = new System.Drawing.Size(75, 75);
            this.btnCell43.TabIndex = 5;
            this.btnCell43.Text = "?";
            this.btnCell43.UseVisualStyleBackColor = true;
            this.btnCell43.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell44
            // 
            this.btnCell44.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell44.Location = new System.Drawing.Point(380, 382);
            this.btnCell44.Name = "btnCell44";
            this.btnCell44.Size = new System.Drawing.Size(75, 75);
            this.btnCell44.TabIndex = 5;
            this.btnCell44.Text = "?";
            this.btnCell44.UseVisualStyleBackColor = true;
            this.btnCell44.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // MainForm5x5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(766, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnGoComputer);
            this.Controls.Add(this.btnStartNewGame);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm5x5";
            this.Text = "Tic Tac Toe CSharp Version - Ethan Smith";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartNewGame;
        private System.Windows.Forms.Button btnGoComputer;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnCell00;
        private System.Windows.Forms.Button btnCell01;
        private System.Windows.Forms.Button btnCell02;
        private System.Windows.Forms.Button btnCell10;
        private System.Windows.Forms.Button btnCell11;
        private System.Windows.Forms.Button btnCell12;
        private System.Windows.Forms.Button btnCell20;
        private System.Windows.Forms.Button btnCell21;
        private System.Windows.Forms.Button btnWild;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCell04;
        private System.Windows.Forms.Button btnCell03;
        private System.Windows.Forms.Button btnCell44;
        private System.Windows.Forms.Button btnCell43;
        private System.Windows.Forms.Button btnCell42;
        private System.Windows.Forms.Button btnCell41;
        private System.Windows.Forms.Button btnCell40;
        private System.Windows.Forms.Button btnCell34;
        private System.Windows.Forms.Button btnCell33;
        private System.Windows.Forms.Button btnCell32;
        private System.Windows.Forms.Button btnCell31;
        private System.Windows.Forms.Button btnCell30;
        private System.Windows.Forms.Button btnCell14;
        private System.Windows.Forms.Button btnCell13;
        private System.Windows.Forms.Button btnCell24;
        private System.Windows.Forms.Button btnCell23;
    }
}

