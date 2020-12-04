using System;
using System.Windows.Forms;
using TicTacToe_Interfaces;
using System.Drawing;

//Ethan Smith

namespace TicTacToeGraphics
{
    public partial class GameCell : UserControl
    {
        private CellOwners _cellOwner = CellOwners.Error;

        //public CellOwners GameCellOwner
        //{
        //    get { return _cellOwner; }
        //    set
        //    {
        //        _cellOwner = value;
        //        switch (value)
        //        {
        //        //    case CellOwners.Error:
        //        //        this.BackgroundImage = Properties.Resources.smiley;
        //        //        break;
        //        //    case CellOwners.Open:
        //        //        this.BackgroundImage = Properties.Resources.OpenCell;
        //        //        break;
        //        //    case CellOwners.Human:
        //        //        this.BackgroundImage = Properties.Resources.Player_X;
        //        //        break;
        //        //    case CellOwners.Computer:
        //        //        this.BackgroundImage = Properties.Resources.Player_O;
        //        //        break;
        //        //    default:
        //        //        this.BackgroundImage = Properties.Resources.smiley;
        //        //        break;
        //        //}
        //    }
        //}

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
