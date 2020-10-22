using System;
using TicTacToe_Interfaces;

//Ethan Smith

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "The Human";

        public TicTacToeEnums.CellOwners IdentifyCellOwners(int CellRow, int CellCol)
        {
            throw new NotImplementedException();
        }

        public void SetCellOwner(int CellRow, int CellCol, TicTacToeEnums.CellOwners CellOwner)
        {
            throw new NotImplementedException();
        }
    }
}
