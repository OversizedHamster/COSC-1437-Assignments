﻿using System;
using TicTacToe_Interfaces;

//Ethan Smith

namespace Middle_Tier
{
    public class TicTacToeCell : ITicTacToeCell
    {
        /*
         * ProfReynolds
         * It took a little head scratching to find out why your tests were unable to run.
         * but here is the answer. You were setting the property from within the property
         * RowID = value;
         * see solution below
         */
        //public int RowID
        //{
        //    get => RowID;
        //    set
        //    {
        //        if (value < 0 || value > 2)
        //        {
        //            throw new ArgumentOutOfRangeException();
        //        }
        //        else
        //        {
        //            RowID = value;
        //        }
        //    }
        //}

        //public int ColID
        //{
        //    get => ColID;
        //    set
        //    {
        //        if (value < 0 || value > 2)
        //        {
        //            throw new ArgumentOutOfRangeException();
        //        }
        //        else
        //        {
        //            ColID = value;
        //        }
        //    }
        //}

        private int _rowID;
        public int RowID
        {
            get => _rowID; // ProfReynolds - fixed this
            set
            {
                if (value < 0 || value > 4)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _rowID = value; // ProfReynolds - fixed this
                }
            }
        }

        private int _colID;
        public int ColID
        {
            get => _colID; // ProfReynolds - fixed this
            set
            {
                if (value < 0 || value > 4)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _colID = value; // ProfReynolds - fixed this
                }
            }
        }

        // ProfReynolds2 removed the TicTacToeEnums. since that class is no longer used
        public CellOwners CellOwner { get; set; } = CellOwners.Open;
    }
}
