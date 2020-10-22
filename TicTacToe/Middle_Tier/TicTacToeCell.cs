using TicTacToe_Interfaces;

//Ethan Smith

namespace Middle_Tier
{
    public class TicTacToeCell : ITicTacToeCell
    {
        public int RowID { get; set; }
        public int ColID { get; set; }
        public TicTacToeEnums.CellOwners CellOwner { get; set; } = TicTacToeEnums.CellOwners.Open;
    }
}
