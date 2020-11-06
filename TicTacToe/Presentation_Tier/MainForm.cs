using System;
using System.Windows.Forms;

namespace Presentation_Tier
{
    //Ethan Smith

    public partial class MainForm : Form
    {
        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();
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
            //MessageBox.Show("btnStartNewGame", "ButtonClick");

            if (sender is Button btn)
            {
                btn.Text = "?";
            }
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("btnGoComputer", "ButtonClick");

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }

        private void btnCell00_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell00", "ButtonClick");
        }

        private void btnCell01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell01", "ButtonClick");
        }

        private void btnCell02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell02", "ButtonClick");
        }

        private void btnCell10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell10", "ButtonClick");
        }

        private void btnCell11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell11", "ButtonClick");
        }

        private void btnCell12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell12", "ButtonClick");
        }

        private void btnCell20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell20", "ButtonClick");
        }

        private void btnCell21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell21", "ButtonClick");
        }

        private void btnCell22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell22", "ButtonClick");
        }
    }
}
