using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Middle_Tier;
using Shouldly;
using TicTacToe_Interfaces;

//Ethan Smith

namespace Middle_Tier_Tests
{
    [TestClass]
    public class TicTacToeCell_Tests
    {
        [TestMethod]
        public void TicTacToeCell_Initializes_Properly()
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action

            // assert
            ticTacToeCell.RowID.ShouldBe(0);
            ticTacToeCell.ColID.ShouldBe(0);
            ticTacToeCell.CellOwner.ShouldBe(CellOwners.Open);
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        public void Verify_Assignment_Of_RowID(int attemptedAssignment, int expectedResult)
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            ticTacToeCell.RowID = attemptedAssignment;

            // assert
            ticTacToeCell.RowID.ShouldBe(expectedResult);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(3)]
        [DataRow(999)]
        public void Assignment_Of_RowID_Outside_Range_Should_Fault(int attemptedAssignment)
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            // na

            // assert
            Should.Throw<ArgumentOutOfRangeException>(() =>
            {
                ticTacToeCell.RowID = attemptedAssignment;
            });
        }


        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        public void Verify_Assignment_Of_ColID(int attemptedAssignment, int expectedResult)
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            ticTacToeCell.ColID = attemptedAssignment;

            // assert
            ticTacToeCell.ColID.ShouldBe(expectedResult);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(3)]
        [DataRow(999)]
        public void Assignment_Of_ColID_Outside_Range_Should_Fault(int attemptedAssignment)
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            // na

            // assert
            Should.Throw<ArgumentOutOfRangeException>(() =>  ticTacToeCell.ColID = attemptedAssignment );
        }


        [DataTestMethod]
        [DataRow(CellOwners.Error, CellOwners.Error)]
        [DataRow(CellOwners.Open, CellOwners.Open)]
        [DataRow(CellOwners.Human, CellOwners.Human)]
        [DataRow(CellOwners.Computer, CellOwners.Computer)]
        public void Verify_Assignment_Of_CellOwner(CellOwners attemptedAssignment, CellOwners expectedResult)
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            ticTacToeCell.CellOwner = attemptedAssignment;

            // assert
            ticTacToeCell.CellOwner.ShouldBe(expectedResult);
        }

        /*
         * this unit test makes no since because the enum prevents illegal assignment
         * public void Assignment_Of_CellOwner_Outside_Range_Should_Fault(int attemptedAssignment)
         */
    }
}