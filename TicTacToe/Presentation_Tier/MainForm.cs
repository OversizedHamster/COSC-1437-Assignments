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

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ticTacToeGame.CellOwnerChanged += this.CellOwnerChangedHandler;
        }

        private void CellOwnerChangedHandler(object sender, Middle_Tier.TicTacToeGame.CellOwnerChangedArgs e)
        {
            var buttonName = $"btnCell{e.RowID}{e.ColID}";
            foreach (var control in panel1.Controls)
            {
                if (control is Button button)
                {
                    if (button.Name == buttonName)
                    {
                        switch (e.CellOwner)
                        {
                            case TicTacToeEnums.CellOwners.Error:
                                button.Text = "#";
                                break;
                            case TicTacToeEnums.CellOwners.Open:
                                button.Text = "?";
                                break;
                            case TicTacToeEnums.CellOwners.Human:
                                button.Text = "X";
                                break;
                            case TicTacToeEnums.CellOwners.Computer:
                                button.Text = "O";
                                break;

                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                }
            }
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
                _ticTacToeGame.ResetGrid();
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
