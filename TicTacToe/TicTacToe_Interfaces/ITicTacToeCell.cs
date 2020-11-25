//Ethan Smith

namespace TicTacToe_Interfaces
{
    public interface ITicTacToeCell
    {
        int RowID { get; set; }
        int ColID { get; set; }

        // ProfReynolds2 removed the TicTacToeEnums. since that class is no longer used
        CellOwners CellOwner { get; set; }
    }
}