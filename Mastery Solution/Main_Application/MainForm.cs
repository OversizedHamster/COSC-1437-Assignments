using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using CoreLibrary;

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
            lbFileOutput.Items.Clear();
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Comma Separated Values|*.csv|Text File|*.txt",
                Title = @"Select the Hundred Names database",
                FileName = Properties.Settings.Default.PreviousFilePath
            };
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    openFileDialog.SafeFileName,
                    @"You Selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtFileName.Text = openFileDialog.SafeFileName;

                Properties.Settings.Default.PreviousFilePath = openFileDialog.FileName;
                Properties.Settings.Default.Save();

                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    var oneLineOfText = "";
                    while((oneLineOfText = sr.ReadLine()) != null)
                    {
                        var parsedArrayOfStrings = Regex.Split(oneLineOfText, "\\n");

                        lbFileOutput.Items.AddRange(parsedArrayOfStrings);
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Properties.Settings.Default.PreviousFilePath;
        }

        private void btnWriteEncryptedFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Comma Separated Values|*.csv|Text File|*.txt|All Files|*.*",
                Title = @"Select a file, preferable a plain text file",
                FileName = Properties.Settings.Default.PreviousFilePath
            };
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.SafeFileName;

                Properties.Settings.Default.PreviousFilePath = openFileDialog.FileName;
                Properties.Settings.Default.Save();

                string inputFilePath = openFileDialog.FileName;

                FileStream sourceFileStream =
                    new FileStream(inputFilePath,
                        FileMode.Open,
                        FileAccess.Read);

                Debug.WriteLine($"Property 'Name' : {sourceFileStream.Name}");
                Debug.WriteLine($"Property 'CanRead' : {sourceFileStream.CanRead}");

                StreamReader sr = new StreamReader(sourceFileStream);

                Debug.WriteLine($"Property 'EndOfStream' : {sr.EndOfStream}");

                string sourceFileContent = sr.ReadToEnd();

                Debug.WriteLine($"Property 'EndOfStream' : {sr.EndOfStream}");
                Debug.WriteLine(sourceFileContent.Left(25));

                string outPutFilePath =
                    Path.ChangeExtension(openFileDialog.FileName, "encrypted");

                Debug.WriteLine($"outputFilePath : {outPutFilePath}");

                WriteEncrypt(outPutFilePath, sourceFileContent);
            }
        }

        private static void WriteEncrypt(string outputFilePath, string msg)
        {
            FileStream outputFileStream =
                new FileStream(outputFilePath,
                    FileMode.Create,
                    FileAccess.Write);

            Debug.WriteLine($"Property 'Name' : {outputFileStream.Name}");
            Debug.WriteLine($"Property 'CanRead' : {outputFileStream.CanRead}");

            DESCryptoServiceProvider crypt = new DESCryptoServiceProvider();
            crypt.Key = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
            crypt.IV = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };

            CryptoStream cs =
                new CryptoStream(outputFileStream,
                    crypt.CreateEncryptor(),
                    CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cs);

            sw.Write(msg);
            sw.Close();
            cs.Close();
        }

        private static string ReadEncrypt(string inputFilePath)
        {
            FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
            Debug.WriteLine($"Property 'Name' : {inputFileStream.Name}");
            Debug.WriteLine($"Property 'CanRead' : {inputFileStream.CanRead}");
            // (1) Create Data Encryption Standard (DES) object.
            DESCryptoServiceProvider crypt = new DESCryptoServiceProvider();
            // (2) Create a key and Initialization Vector
            crypt.Key = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
            crypt.IV = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
            // (3) Create CryptoStream stream object
            CryptoStream cs =
                new CryptoStream(inputFileStream,
                    crypt.CreateDecryptor(),
                    CryptoStreamMode.Read);
            // (4) Create StreamReader using CryptoStream
            StreamReader sr = new StreamReader(cs);
            string msg = sr.ReadToEnd();
            sr.Close();
            cs.Close();
            return msg;
        }

        private void btnReadEncryptedFile_Click(object sender, EventArgs e)
        {
            lbFileOutput.Items.Clear();
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Comma Separated Values|*.csv|Text File|*.txt|All Files|*.*",
                Title = @"Select the Hundred Names database",
                FileName = Properties.Settings.Default.PreviousFilePath
            };
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                txtFileName.Text = openFileDialog.SafeFileName;

                Properties.Settings.Default.PreviousFilePath = openFileDialog.FileName;
                Properties.Settings.Default.Save();

                string fileContent = ReadEncrypt(openFileDialog.FileName);

                var parsedArrayOfStrings = Regex.Split(fileContent, "\\n");

                lbFileOutput.Items.AddRange(parsedArrayOfStrings);
            }
        }
    }
}
