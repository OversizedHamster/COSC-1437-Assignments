using System;
using System.Windows.Forms;

namespace UI_Layer_CSharp
{
    //Ethan Smith

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var newForm = new AboutBox();
            newForm.Show();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            //as the content changes, this event will trigger as each character changes
            bool playerNameIsValid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = playerNameIsValid;
            btnGoComputer.Enabled = playerNameIsValid;
            panel1.Enabled = playerNameIsValid;
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            //when the focus leaves the text box, this event is triggered
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            //on click of this button a new game will start
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            //on click a new game should start where 2 AIs face off against each other
        }

        private void btnCell00_Click(object sender, EventArgs e)
        {

        }

        private void btnCell01_Click(object sender, EventArgs e)
        {

        }

        private void btnCell02_Click(object sender, EventArgs e)
        {

        }

        private void btnCell10_Click(object sender, EventArgs e)
        {

        }

        private void btnCell11_Click(object sender, EventArgs e)
        {

        }

        private void btnCell12_Click(object sender, EventArgs e)
        {

        }

        private void btnCell20_Click(object sender, EventArgs e)
        {

        }

        private void btnCell21_Click(object sender, EventArgs e)
        {

        }

        private void btnCell22_Click(object sender, EventArgs e)
        {

        }
    }
}
