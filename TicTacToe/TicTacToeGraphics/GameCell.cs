using System;
using System.Windows.Forms;
using TicTacToe_Interfaces;

//Ethan Smith

namespace TicTacToeGraphics
{
    public partial class GameCell : UserControl
    {
        private CellOwners _cellOwner = CellOwners.Error;

        public CellOwners GameCellOwner
        {
            get { return _cellOwner; }
            set
            {
                _cellOwner = value;
                switch (value)
                {
                    case CellOwners.Error:
                        this.BackgroundImage = Properties.Resources.
                }
            }
        }

        public delegate void CellOwnerChangedHandler(object sender);

        public event CellOwnerChangedHandler CellOwnerChanged;
        public int GameCellRow { get; set; }
        public int GameCellCol { get; set; }

        public GameCell()
        {
            InitializeComponent();
        }

        private void GameCell_Load(object sender, EventArgs e)
        {

        }

        private void GameCell_Click(object sender, EventArgs e)
        {
            CellOwnerChanged?.Invoke(this);
        }
    }
}
