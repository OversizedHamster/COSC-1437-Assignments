//Ethan Smith

namespace TicTacToe_Interfaces
{
    public interface ITicTacToeGame
    {
        string PlayerName { get; set; }

        /*
         * ProfReynolds2
         * see notes in TicTacToeGame - i removed these two and added the two below
        TicTacToeEnums.CellOwners IdentifyCellOwners(int CellRow, int CellCol);
        void SetCellOwner(int CellRow, int CellCol, TicTacToeEnums.CellOwners CellOwner);
         */

        CellOwners IdentifyCellOwner(int CellRow, int CellCol);
        void AssignCellOwner(int CellRow, int CellCol, CellOwners CellOwner);

    }
}