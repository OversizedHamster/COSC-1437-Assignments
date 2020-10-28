﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

//Ethan Smith

namespace Main_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            pictureBox1.Image = (Image)(RotateImg(bitmap, 270.0f));
        }

        private void exitApplicationBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static Bitmap RotateImg(Bitmap bmp, float angle)

        {

            int w = bmp.Width;

            int h = bmp.Height;

            Bitmap tempImg = new Bitmap(w, h);

            Graphics g = Graphics.FromImage(tempImg);

            g.DrawImageUnscaled(bmp, 1, 1);

            g.Dispose();

            GraphicsPath path = new GraphicsPath();

            path.AddRectangle(new RectangleF(0f, 0f, w, h));

            Matrix mtrx = new Matrix();

            mtrx.Rotate(angle);

            RectangleF rct = path.GetBounds(mtrx);

            Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height));

            g = Graphics.FromImage(newImg);

            g.TranslateTransform(-rct.X, -rct.Y);

            g.RotateTransform(angle);

            g.InterpolationMode = InterpolationMode.HighQualityBilinear;

            g.DrawImageUnscaled(tempImg, 0, 0);

            g.Dispose();

            tempImg.Dispose();

            return newImg;

        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Comma Separated Values|*.csv|Text File|*.txt",
                Title = @"Select the Hundred Names database"
            };

            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    openFileDialog.SafeFileName,
                    @"You Selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtFileName.Text = openFileDialog.SafeFileName;

                using(StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    var oneLineOfText = "";
                    while((oneLineOfText = sr.ReadLine()) != null)
                    {
                        lbFileOutput.Items.Add(oneLineOfText);
                    }
                }
            }
        }
    }
}
