using System;
using System.Collections.ObjectModel;
using TicTacToe_Interfaces;

//Ethan Smith

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "The Human";
        public TicTacToeEnums.CellOwners Winner { get; private set; }
        private readonly Collection<TicTacToeCell> _ticTacToeCells = new Collection<TicTacToeCell>();

        public void ResetGrid()
        {
            _ticTacToeCells.Clear(); // resets the collection to empty

            Winner = TicTacToeEnums.CellOwners.Open;

            // create the 9 cells
            for (var rowNo = 0; rowNo < 3; rowNo++)
            for (var colNo = 0; colNo < 3; colNo++)
            {
                _ticTacToeCells.Add(new TicTacToeCell
                {
                    RowID = rowNo,
                    ColID = colNo
                });
            }

        }

        public TicTacToeEnums.CellOwners IdentifyCellOwner(int CellRow, int CellCol)
        {
            throw new NotImplementedException();
        }

        public void AssignCellOwner(int CellRow, int CellCol, TicTacToeEnums.CellOwners CellOwner)
        {
            throw new NotImplementedException();
        }

        public void AutoPlayComputer()
        {
            throw new NotImplementedException();
        }

        public bool CheckForWinner()
        {
            return false;
        }

        public string IdentifyWinner()
        {
            return "";
        }

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
