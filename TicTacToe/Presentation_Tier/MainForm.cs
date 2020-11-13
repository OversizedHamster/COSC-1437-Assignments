using System;
using System.Diagnostics;
using System.Windows.Forms;
using CoreLibrary;
using TicTacToe_Interfaces;

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
            if (_ticTacToeGame.Winner != TicTacToeEnums.CellOwners.Open) return;

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }

        private void btnCell00_Click(object sender, EventArgs e)
        {
            btnCellxx_Click(sender, e);
        }

        private void btnCell01_Click(object sender, EventArgs e)
        {
            btnCellxx_Click(sender, e);
        }

        private void btnCell02_Click(object sender, EventArgs e)
        {
            btnCellxx_Click(sender, e);
        }

        private void btnCell10_Click(object sender, EventArgs e)
        {
            btnCellxx_Click(sender, e);
        }

        private void btnCell11_Click(object sender, EventArgs e)
        {
            btnCellxx_Click(sender, e);
        }

        private void btnCell12_Click(object sender, EventArgs e)
        {
            btnCellxx_Click(sender, e);
        }

        private void btnCell20_Click(object sender, EventArgs e)
        {
            btnCellxx_Click(sender, e);
        }

        private void btnCell21_Click(object sender, EventArgs e)
        {
            btnCellxx_Click(sender, e);
        }

        private void btnCell22_Click(object sender, EventArgs e)
        {
            btnCellxx_Click(sender, e);
        }

        private void btnCellxx_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != TicTacToeEnums.CellOwners.Open) return;

            var btn = sender as Button;

            int rowID = btn.Name.Substring(7, 1).ToInt();

            int colID = btn.Name.Substring(8, 1).ToInt();

            Debug.WriteLine($"Button click: row={rowID} col={colID}");

            _ticTacToeGame.AssignCellOwner(rowID, colID, TicTacToeEnums.CellOwners.Human);
            btn.Text = "X";

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }
    }
}
