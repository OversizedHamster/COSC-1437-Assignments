using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Ethan Smith
 */

namespace Project_1_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMessageBoxPopup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    text: "This is a message box",
                    caption: "this is the title bar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
