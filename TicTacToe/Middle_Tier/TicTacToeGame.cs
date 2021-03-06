﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using TicTacToe_Interfaces;

// ProfReynolds2 - no longer require this, removed
// using static TicTacToe_Interfaces.TicTacToeEnums;

//Ethan Smith

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "The Human";
        public CellOwners Winner { get; private set; }
        private readonly Collection<TicTacToeCell> _ticTacToeCells = new Collection<TicTacToeCell>();
        private Collection<TicTacToeCell> _goodNextMove = new Collection<TicTacToeCell>();
        private Collection<Collection<TicTacToeCell>> _winningCombinations = new Collection<Collection<TicTacToeCell>>();

        public delegate void CellOwnerChangedHandler(object sender, CellOwnerChangedArgs e);

        public event CellOwnerChangedHandler CellOwnerChanged;


        /*
         * ProfReynolds
         * I moved the CellOwnerChangedArgs event to the bottom - personal preference - not wrong, just easier for me to follow
         */

        public void ResetGrid()
        {
            _ticTacToeCells.Clear(); // resets the collection to empty

            Winner = CellOwners.Open;

            // create the 9 cells
            for (var rowNo = 0; rowNo < 5; rowNo++)
            for (var colNo = 0; colNo < 5; colNo++)
            {
                _ticTacToeCells.Add(new TicTacToeCell
                {
                    RowID = rowNo,
                    ColID = colNo
                });
            }


            _goodNextMove = new Collection<TicTacToeCell>()
            {
                //4 corners
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==4),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==4),

                //middle boxes on sides
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==4),

                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==3),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==3),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==3),
                _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==3),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==3),


                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==4),
                _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==4),

            };

            _winningCombinations = new Collection<Collection<TicTacToeCell>>()
            {
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==0)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==1)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==3)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==4)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==4),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==3),
                    _ticTacToeCells.First(tttc => tttc.RowID==3 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==4 && tttc.ColID==0)
                }
            };

            Debug.WriteLine("\nMethod: Reset()");
        }

        public CellOwners IdentifyCellOwner(int CellRow, int CellCol)
        {
            if (_ticTacToeCells.Count == 0)
                return CellOwners.Error;

            var cellOwner =
                _ticTacToeCells
                    .FirstOrDefault(tttc => tttc.RowID == CellRow && tttc.ColID == CellCol)
                    ?.CellOwner
                ?? CellOwners.Error;

            Debug.WriteLine($"Method: IdentifyCellOwner {CellRow}-{CellCol} --> {cellOwner}");

            return cellOwner;
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
            Debug.WriteLine($"Method: AssignCellOwner {CellRow}-{CellCol} --> {CellOwner}");

            var eventArgs = new CellOwnerChangedArgs(CellRow, CellCol, CellOwner);

            CellOwnerChanged?.Invoke(this, eventArgs);
        }

        public void AutoPlayComputer()
        {
            if (Winner != CellOwners.Open)
                return;

            /*
             * ProfReynolds1205
             * each combination will have 4 or 5 elements. so the previous logic is woefully incomplete.
             * recommend you replace this method with the one below
             */
            foreach (var combination in _winningCombinations)
            {
                if (combination[0].CellOwner == CellOwners.Open)
                {
                    if (combination.Count == 5)
                    {
                        if (combination[1].CellOwner == CellOwners.Computer &&
                            combination[2].CellOwner == CellOwners.Computer &&
                            combination[3].CellOwner == CellOwners.Computer &&
                            combination[4].CellOwner == CellOwners.Computer)
                        {
                            AssignCellOwner(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                            return;
                        }
                    }

                    if (combination[1].CellOwner == CellOwners.Computer &&
                        combination[2].CellOwner == CellOwners.Computer &&
                        combination[3].CellOwner == CellOwners.Computer)
                    {
                        AssignCellOwner(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[1].CellOwner == CellOwners.Open)
                {
                    if (combination.Count == 5)
                    {
                        if (combination[0].CellOwner == CellOwners.Computer &&
                            combination[2].CellOwner == CellOwners.Computer &&
                            combination[3].CellOwner == CellOwners.Computer &&
                            combination[4].CellOwner == CellOwners.Computer)
                        {
                            AssignCellOwner(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                    else
                    {
                        if (combination[0].CellOwner == CellOwners.Computer &&
                            combination[2].CellOwner == CellOwners.Computer &&
                            combination[3].CellOwner == CellOwners.Computer)
                        {
                            AssignCellOwner(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                }
                if (combination[2].CellOwner == CellOwners.Open)
                {
                    if (combination.Count == 5)
                    {
                        if (combination[0].CellOwner == CellOwners.Computer &&
                            combination[1].CellOwner == CellOwners.Computer &&
                            combination[3].CellOwner == CellOwners.Computer &&
                            combination[4].CellOwner == CellOwners.Computer)
                        {
                            AssignCellOwner(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                    else
                    {
                        if (combination[0].CellOwner == CellOwners.Computer &&
                            combination[1].CellOwner == CellOwners.Computer &&
                            combination[3].CellOwner == CellOwners.Computer)
                        {
                            AssignCellOwner(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                }
                if (combination[3].CellOwner == CellOwners.Open)
                {
                    if (combination.Count == 5)
                    {
                        if (combination[0].CellOwner == CellOwners.Computer &&
                            combination[1].CellOwner == CellOwners.Computer &&
                            combination[2].CellOwner == CellOwners.Computer &&
                            combination[4].CellOwner == CellOwners.Computer)
                        {
                            AssignCellOwner(combination[3].RowID, combination[3].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                    else
                    {
                        if (combination[0].CellOwner == CellOwners.Computer &&
                            combination[1].CellOwner == CellOwners.Computer &&
                            combination[2].CellOwner == CellOwners.Computer)
                        {
                            AssignCellOwner(combination[3].RowID, combination[3].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                }
                if (combination.Count == 5 && combination[4].CellOwner == CellOwners.Open)
                {
                    if (combination[0].CellOwner == CellOwners.Computer &&
                        combination[1].CellOwner == CellOwners.Computer &&
                        combination[2].CellOwner == CellOwners.Computer &&
                        combination[3].CellOwner == CellOwners.Computer)
                    {
                        AssignCellOwner(combination[4].RowID, combination[4].ColID, CellOwners.Computer);
                        return;
                    }
                }
            }

            foreach (var combination in _winningCombinations)
            {
                if (combination[0].CellOwner == CellOwners.Open)
                {
                    if (combination.Count == 5)
                    {
                        if (combination[1].CellOwner == CellOwners.Human &&
                            combination[2].CellOwner == CellOwners.Human &&
                            combination[3].CellOwner == CellOwners.Human &&
                            combination[4].CellOwner == CellOwners.Human)
                        {
                            AssignCellOwner(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                    else
                    {
                        if (combination[1].CellOwner == CellOwners.Human &&
                            combination[2].CellOwner == CellOwners.Human &&
                            combination[3].CellOwner == CellOwners.Human)
                        {
                            AssignCellOwner(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                }
                if (combination[1].CellOwner == CellOwners.Open)
                {
                    if (combination.Count == 5)
                    {
                        if (combination[0].CellOwner == CellOwners.Human &&
                            combination[2].CellOwner == CellOwners.Human &&
                            combination[3].CellOwner == CellOwners.Human &&
                            combination[4].CellOwner == CellOwners.Human)
                        {
                            AssignCellOwner(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                    else
                    {
                        if (combination[0].CellOwner == CellOwners.Human &&
                            combination[2].CellOwner == CellOwners.Human &&
                            combination[3].CellOwner == CellOwners.Human)
                        {
                            AssignCellOwner(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                }
                if (combination[2].CellOwner == CellOwners.Open)
                {
                    if (combination.Count == 5)
                    {
                        if (combination[0].CellOwner == CellOwners.Human &&
                            combination[1].CellOwner == CellOwners.Human &&
                            combination[3].CellOwner == CellOwners.Human &&
                            combination[4].CellOwner == CellOwners.Human)
                        {
                            AssignCellOwner(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                    else
                    {
                        if (combination[0].CellOwner == CellOwners.Human &&
                            combination[1].CellOwner == CellOwners.Human &&
                            combination[3].CellOwner == CellOwners.Human)
                        {
                            AssignCellOwner(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                }
                if (combination[3].CellOwner == CellOwners.Open)
                {
                    if (combination.Count == 5)
                    {
                        if (combination[0].CellOwner == CellOwners.Human &&
                            combination[1].CellOwner == CellOwners.Human &&
                            combination[2].CellOwner == CellOwners.Human &&
                            combination[4].CellOwner == CellOwners.Human)
                        {
                            AssignCellOwner(combination[3].RowID, combination[3].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                    else
                    {
                        if (combination[0].CellOwner == CellOwners.Human &&
                            combination[1].CellOwner == CellOwners.Human &&
                            combination[2].CellOwner == CellOwners.Human)
                        {
                            AssignCellOwner(combination[3].RowID, combination[3].ColID, CellOwners.Computer);
                            return;
                        }
                    }
                }
                if (combination.Count == 5 && combination[4].CellOwner == CellOwners.Open)
                {
                    if (combination[0].CellOwner == CellOwners.Human &&
                        combination[1].CellOwner == CellOwners.Human &&
                        combination[2].CellOwner == CellOwners.Human &&
                        combination[3].CellOwner == CellOwners.Human)
                    {
                        AssignCellOwner(combination[4].RowID, combination[4].ColID, CellOwners.Computer);
                        return;
                    }
                }
            }

            foreach (var targetCell in _goodNextMove)
            {
                if (targetCell.CellOwner == CellOwners.Open)
                {
                    AssignCellOwner(targetCell.RowID, targetCell.ColID, CellOwners.Computer);
                    return;
                }
            }
        }

        /*
         * ProfReynolds1205
         * this is a rather advanced solution but you will learn if you study it.

        public void AutoPlayComputer()
        {
            bool SearchForPlayerReadyToWin(CellOwners checkingCellOwner)
            {
                foreach (var combination in _winningCombinations)
                foreach (var targetCell in combination.Where(tttc => tttc.CellOwner == CellOwners.Open))
                {
                    if (combination
                        .Count(tttc =>
                            tttc != targetCell &&
                            tttc.CellOwner != checkingCellOwner) > 0)
                        break;

                    AssignCellOwner(targetCell.RowID, targetCell.ColID, CellOwners.Computer);
                    return true;
                }

                return false;
            }

            if (_ticTacToeCells.Count == 0) return;

            if (Winner == CellOwners.Computer || Winner == CellOwners.Human) return;


            if (SearchForPlayerReadyToWin(CellOwners.Computer)) return;
            if (SearchForPlayerReadyToWin(CellOwners.Human)) return;

            var winningCell = _goodNextMove
                .FirstOrDefault(tttc => tttc.CellOwner == CellOwners.Open);
            if (winningCell != null)
                AssignCellOwner(winningCell.RowID, winningCell.ColID, CellOwners.Computer);
        }

        */

        
        public bool CheckForWinner()
        {
            foreach (var combination in _winningCombinations)
            {
                var firstCell = combination[0];
                if ((firstCell.CellOwner != CellOwners.Computer) &&
                    (firstCell.CellOwner != CellOwners.Human)) continue;

                if (combination.Count == 5)
                {
                    if ((firstCell.CellOwner != combination[1].CellOwner) ||
                        (firstCell.CellOwner != combination[2].CellOwner) ||
                        (firstCell.CellOwner != combination[3].CellOwner) ||
                        (firstCell.CellOwner != combination[4].CellOwner)) continue;
                }
                else
                {
                    if ((firstCell.CellOwner != combination[1].CellOwner) ||
                        (firstCell.CellOwner != combination[2].CellOwner) ||
                        (firstCell.CellOwner != combination[3].CellOwner)) continue;
                }

                Winner = firstCell.CellOwner;

                Debug.WriteLine($"Method: CheckForWinnder {Winner}");
                return true;
            }

            /*
             * ProfReynolds1205
             * The above is complicated due to the combinations being 4 or 5
             * replace the above with this
             *
            if (combination.Any(tttc => tttc.CellOwner != firstCell.CellOwner))
                continue;

            Winner = firstCell.CellOwner;
             *
             */

            Debug.WriteLine($"Method: CheckForWinnder {Winner}");
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

        /*
         * ProfReynolds2
         * these two methods were replaced by
         *      CellOwners IdentifyCellOwner(int CellRow, int CellCol)
         *      void AssignCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
         * I removed these methods and corrected the ITicTavToeGame interface
        public CellOwners IdentifyCellOwners(int CellRow, int CellCol)
        {
            throw new NotImplementedException();
        }

        public void SetCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {
            throw new NotImplementedException();
        }
         */

        public class CellOwnerChangedArgs : EventArgs
        {
            public CellOwnerChangedArgs(int rowID, int colID, CellOwners cellOwner)
            {
                RowID = rowID;
                ColID = colID;
                CellOwner = cellOwner;
            }

            public int RowID { get; }
            public int ColID { get; }
            public CellOwners CellOwner { get; }
        }
    }
}
