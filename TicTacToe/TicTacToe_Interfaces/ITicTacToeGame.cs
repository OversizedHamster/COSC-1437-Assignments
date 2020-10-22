//Ethan Smith

namespace TicTacToe_Interfaces
{
    public interface ITicTacToeGame
    {
        string PlayerName { get; set; }
        TicTacToeEnums.CellOwners IdentifyCellOwners(int CellRow, int CellCol);
        void SetCellOwner(int CellRow, int CellCol, TicTacToeEnums.CellOwners CellOwner);
    }
}