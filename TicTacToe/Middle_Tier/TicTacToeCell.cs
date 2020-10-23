using System;
using System.Diagnostics;
using TicTacToe_Interfaces;

//Ethan Smith

namespace Middle_Tier
{
    public class TicTacToeCell : ITicTacToeCell
    {
        public int RowID
        {
            get => RowID;
            set
            {
                if (value < 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    RowID = value;
                }
            }
        }

        public int ColID
        {
            get => ColID;
            set
            {
                if (value < 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    ColID = value;
                }
            }
        }

        public TicTacToeEnums.CellOwners CellOwner { get; set; } = TicTacToeEnums.CellOwners.Open;
    }
}
