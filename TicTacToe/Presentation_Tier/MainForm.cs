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
        // ProfReynolds - I made this readonly. Not required, just demonstrating
        private readonly Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();

        public MainForm()
        {
            InitializeComponent();
        }

        /*
         * ProfReynolds
         * I rearranged the methods. Does not change the operation but makes it easier to follow:
         * 1) constructor (MainForm) and never put anything other than InitializeComponent in the method
         * 2) form events especially the load event
         * 3) control events especially the click events
         * 4) other event handlers such as the _ticTacToeGame.CellOwnerChanged
         * 5) misc necessary methods (since very, very little implementation belongs in the UI, this should be limited)
         */

        // ProfReynolds - I can see a big problem right here - the MainForm_Load event method is not 'connected'
        // to the form. In the MainForm, you need top use the Event Properties to connect this event to the Load event.
        // (click the Load event, look for the pull-down in the blank to the right)
        private void MainForm_Load(object sender, EventArgs e)
        {
            _ticTacToeGame.CellOwnerChanged += this.CellOwnerChangedHandler;
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
            var playerNameIsValid = (txtPlayerName.Text.Length >= 3); // ProfReynolds - use var

            btnStartNewGame.Enabled = playerNameIsValid;
            btnGoComputer.Enabled = playerNameIsValid;
            panel1.Enabled = playerNameIsValid;
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            //when the focus leaves the text box, this event is triggered
            // ProfReynolds - at this point, you need to assign the text box Text to the PlayerName
            _ticTacToeGame.PlayerName = txtPlayerName.Text;

        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("btnStartNewGame", "ButtonClick");

            // ProfReynolds - in real life, you do not need the conditional because this method can ONLY
            // be reacedif the sender is a button. We did it this way to reinforce the syntax
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
                MessageBox.Show("Computer", "The Winner!");
                // ProfReynolds - this would be better: MessageBox.Show("Computer","The Winner!");
            }
        }

        private void btnCellxx_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != TicTacToeEnums.CellOwners.Open) return;

            //var btn = sender as Button;

            //int rowID = btn.Name.Substring(7, 1).ToInt();

            //int colID = btn.Name.Substring(8, 1).ToInt();

            //Debug.WriteLine($"Button click: row={rowID} col={colID}");

            // _ticTacToeGame.AssignCellOwner(rowID, colID, TicTacToeEnums.CellOwners.Human);

            //btn.Text = "X";



            // ProfReynolds: This is even better than the above:
            if (sender is Button btn)
            {
                var rowID = btn.Name.Substring(7, 1).ToInt();
                var colID = btn.Name.Substring(8, 1).ToInt();
                Debug.WriteLine($"Button click: row={rowID} col={colID}");
                _ticTacToeGame.AssignCellOwner(rowID, colID, TicTacToeEnums.CellOwners.Human);
                //btn.Text = "X"; // ProfReynolds - do not assign the X here. The CellOwnerChangedHandler will take care of it
            }

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show(_ticTacToeGame.PlayerName, "The Winner!");
                // ProfReynolds - this would be better: MessageBox.Show(_ticTacToeGame.PlayerName,"The Winner!");
            }
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

    }
}
