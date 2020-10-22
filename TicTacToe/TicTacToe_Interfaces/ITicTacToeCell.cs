//Ethan Smith

namespace TicTacToe_Interfaces
{
    public interface ITicTacToeCell
    {
        int RowID { get; set; }
        int ColID { get; set; }
        TicTacToeEnums.CellOwners CellOwner { get; set; }
    }
}