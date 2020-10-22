using TicTacToe_Interfaces;

//Ethan Smith

namespace Business_Layer_CSharp
{
    public class TicTacToeCell : ITicTacToeCell
    {
        public int RowID { get; set; }
        public int ColID { get; set; }
        public TicTacToeEnums.CellOwners CellOwner { get; set; } = TicTacToeEnums.CellOwners.Open;
    }
}
