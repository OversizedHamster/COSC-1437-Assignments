using System;
using System.Collections.ObjectModel;
using System.Linq;
using TicTacToe_Interfaces;
using static TicTacToe_Interfaces.TicTacToeEnums;

//Ethan Smith

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "The Human";
        public CellOwners Winner { get; private set; }
        private readonly Collection<TicTacToeCell> _ticTacToeCells = new Collection<TicTacToeCell>();

        public void ResetGrid()
        {
            _ticTacToeCells.Clear(); // resets the collection to empty

            Winner = CellOwners.Open;

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

        public CellOwners IdentifyCellOwner(int CellRow, int CellCol)
        {
            if (_ticTacToeCells.Count == 0)
                return CellOwners.Error;

            var targetCell = _ticTacToeCells
                .FirstOrDefault(tttc => tttc.RowID == CellRow & tttc.ColID == CellCol);

            if (targetCell == null)
                return CellOwners.Error;

            return targetCell.CellOwner;
        }

        public void AssignCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {
            if (_ticTacToeCells.Count == 0)
                return;

            var targetCell = _ticTacToeCells
                .FirstOrDefault(tttc => tttc.RowID == CellRow & tttc.ColID == CellCol);

            if (targetCell == null)
                return;

            targetCell.CellOwner = CellOwner;
        }

        public void AutoPlayComputer()
        {
            throw new NotImplementedException();
        }

        public bool CheckForWinner()
        {
            if (IdentifyCellOwner(0, 0) == CellOwners.Human &&
                IdentifyCellOwner(0, 1) == CellOwners.Human &&
                IdentifyCellOwner(0, 2) == CellOwners.Human)
            {
                Winner = CellOwners.Human;
                return true;
            }

            if (IdentifyCellOwner(1, 0) == CellOwners.Human &&
                IdentifyCellOwner(1, 1) == CellOwners.Human &&
                IdentifyCellOwner(1, 2) == CellOwners.Human)
            {
                Winner = CellOwners.Human;
                return true;
            }

            if (IdentifyCellOwner(2, 0) == CellOwners.Human &&
                IdentifyCellOwner(2, 1) == CellOwners.Human &&
                IdentifyCellOwner(2, 2) == CellOwners.Human)
            {
                Winner = CellOwners.Human;
                return true;
            }

            if (IdentifyCellOwner(0, 0) == CellOwners.Human &&
                IdentifyCellOwner(1, 0) == CellOwners.Human &&
                IdentifyCellOwner(2, 0) == CellOwners.Human)
            {
                Winner = CellOwners.Human;
                return true;
            }

            if (IdentifyCellOwner(0, 1) == CellOwners.Human &&
                IdentifyCellOwner(1, 1) == CellOwners.Human &&
                IdentifyCellOwner(2, 1) == CellOwners.Human)
            {
                Winner = CellOwners.Human;
                return true;
            }

            if (IdentifyCellOwner(0, 2) == CellOwners.Human &&
                IdentifyCellOwner(1, 2) == CellOwners.Human &&
                IdentifyCellOwner(2, 2) == CellOwners.Human)
            {
                Winner = CellOwners.Human;
                return true;
            }

            if (IdentifyCellOwner(0, 0) == CellOwners.Human &&
                IdentifyCellOwner(1, 1) == CellOwners.Human &&
                IdentifyCellOwner(2, 2) == CellOwners.Human)
            {
                Winner = CellOwners.Human;
                return true;
            }

            if (IdentifyCellOwner(0, 2) == CellOwners.Human &&
                IdentifyCellOwner(1, 1) == CellOwners.Human &&
                IdentifyCellOwner(2, 0) == CellOwners.Human)
            {
                Winner = CellOwners.Human;
                return true;
            }

            if (IdentifyCellOwner(0, 0) == CellOwners.Computer &&
                IdentifyCellOwner(0, 1) == CellOwners.Computer &&
                IdentifyCellOwner(0, 2) == CellOwners.Computer)
            {
                Winner = CellOwners.Computer;
                return true;
            }

            if (IdentifyCellOwner(1, 0) == CellOwners.Computer &&
                IdentifyCellOwner(1, 1) == CellOwners.Computer &&
                IdentifyCellOwner(1, 2) == CellOwners.Computer)
            {
                Winner = CellOwners.Computer;
                return true;
            }

            if (IdentifyCellOwner(2, 0) == CellOwners.Computer &&
                IdentifyCellOwner(2, 1) == CellOwners.Computer &&
                IdentifyCellOwner(2, 2) == CellOwners.Computer)
            {
                Winner = CellOwners.Computer;
                return true;
            }

            if (IdentifyCellOwner(0, 0) == CellOwners.Computer &&
                IdentifyCellOwner(1, 0) == CellOwners.Computer &&
                IdentifyCellOwner(2, 0) == CellOwners.Computer)
            {
                Winner = CellOwners.Computer;
                return true;
            }

            if (IdentifyCellOwner(0, 1) == CellOwners.Computer &&
                IdentifyCellOwner(1, 1) == CellOwners.Computer &&
                IdentifyCellOwner(2, 1) == CellOwners.Computer)
            {
                Winner = CellOwners.Computer;
                return true;
            }

            if (IdentifyCellOwner(0, 2) == CellOwners.Computer &&
                IdentifyCellOwner(1, 2) == CellOwners.Computer &&
                IdentifyCellOwner(2, 2) == CellOwners.Computer)
            {
                Winner = CellOwners.Computer;
                return true;
            }

            if (IdentifyCellOwner(0, 0) == CellOwners.Computer &&
                IdentifyCellOwner(1, 1) == CellOwners.Computer &&
                IdentifyCellOwner(2, 2) == CellOwners.Computer)
            {
                Winner = CellOwners.Computer;
                return true;
            }

            if (IdentifyCellOwner(0, 2) == CellOwners.Computer &&
                IdentifyCellOwner(1, 1) == CellOwners.Computer &&
                IdentifyCellOwner(2, 0) == CellOwners.Computer)
            {
                Winner = CellOwners.Computer;
                return true;
            }

            return false;
        }

        public string IdentifyWinner()
        {
            switch (Winner)
            {
                case CellOwners.Computer:
                    return "Computer";

                case CellOwners.Human:
                    return PlayerName == "" ? "Unnamed Human" : PlayerName;

                case CellOwners.Open:
                    return string.Empty;

                default:
                    return "Error";
            }
        }

        public CellOwners IdentifyCellOwners(int CellRow, int CellCol)
        {
            throw new NotImplementedException();
        }

        public void SetCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {
            throw new NotImplementedException();
        }
    }
}
