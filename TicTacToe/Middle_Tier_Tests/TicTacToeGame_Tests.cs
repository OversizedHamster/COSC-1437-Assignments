using Microsoft.VisualStudio.TestTools.UnitTesting;
using Middle_Tier;
using Shouldly;
using TicTacToe_Interfaces;

//Ethan Smith

namespace Middle_Tier_Tests
{
    [TestClass]
    public class TicTacToeGame_Tests
    {
        [TestMethod]
        public void TestClassInstantiation()
        {
            // acting that the class will instantiate

            // arrange

            // act
            var ticTacToeGame = new TicTacToeGame();

            // assert
            ticTacToeGame.ShouldNotBeNull(); // ie. class successfully instantiated
            ticTacToeGame.PlayerName.ShouldBe("The Human"); // ie. player name property properly initialized
            ticTacToeGame.CheckForWinner().ShouldBeFalse(); // ie. no winner, yet
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Error); // winner property is not initialized (defaults to Error)
            ticTacToeGame.IdentifyWinner().ShouldBeEmpty();
        }

        [TestMethod]
        public void PlayerNameTest()
        {
            // Player name property is a holding bin. This is the only testable anything prior to ResetGrid

            // arrange
            var ticTacToeGame = new TicTacToeGame();

            // act
            ticTacToeGame.PlayerName = "Prof Reynolds";

            // assert
            ticTacToeGame.PlayerName.ShouldBe("Prof Reynolds");
        }

        [TestMethod]
        public void ResetGridTest()
        {
            // ResetGrid is necessary and must preceed everything except PlayerName
            var ticTacToeGame = new TicTacToeGame();

            // arrange

            // act
            ticTacToeGame.ResetGrid();

            // assert
            ticTacToeGame.ShouldNotBeNull(); // class sucessfully instantiated
            ticTacToeGame.PlayerName.ShouldBe("The Human"); // player name property propery initialized
            ticTacToeGame.CheckForWinner().ShouldBeFalse(); // no winner yet
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Open); // winner property should now be Open
            ticTacToeGame.IdentifyWinner().ShouldBeEmpty(); // there is no winner
        }

        [TestMethod]
        public void AssignCellOwnerTest()
        {
            // make sure that a cell can be assigned as either computer or human
            // also be sure that only cell within range may be set
            // many TDD purists argue these are all separate tests

            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            ticTacToeGame.IdentifyCellOwner(0, 0).ShouldBe(TicTacToeEnums.CellOwners.Open); // _ticTacToeCells should now be initialized to open

            // act
            ticTacToeGame.AssignCellOwner(0, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AssignCellOwner(0, 1, TicTacToeEnums.CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(0, 11, TicTacToeEnums.CellOwners.Computer); // should not do anything
            ticTacToeGame.AssignCellOwner(0, -1, TicTacToeEnums.CellOwners.Computer); // should not do anything

            // assert
            ticTacToeGame.IdentifyCellOwner(0, 0).ShouldBe(TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.IdentifyCellOwner(0, 1).ShouldBe(TicTacToeEnums.CellOwners.Computer);
            ticTacToeGame.IdentifyCellOwner(0, 2).ShouldBe(TicTacToeEnums.CellOwners.Open);
            ticTacToeGame.IdentifyCellOwner(0, 11).ShouldBe(TicTacToeEnums.CellOwners.Error); // out of bounds
            ticTacToeGame.IdentifyCellOwner(0, -1).ShouldBe(TicTacToeEnums.CellOwners.Error);
            ticTacToeGame.IdentifyCellOwner(0, 3).ShouldBe(TicTacToeEnums.CellOwners.Error);
            ticTacToeGame.IdentifyCellOwner(3, 0).ShouldBe(TicTacToeEnums.CellOwners.Error);

            ticTacToeGame.CheckForWinner().ShouldBeFalse(); // no winner yet
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Open); // winner property should now be Open
            ticTacToeGame.IdentifyWinner().ShouldBeEmpty(); // there is no winner
        }

        [TestMethod]
        public void NoWinnerFound()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            /*
             *      X O X
             *      X X O
             *      O X O
             */
            ticTacToeGame.AssignCellOwner(0, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AssignCellOwner(1, 1, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AssignCellOwner(2, 2, TicTacToeEnums.CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(1, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AssignCellOwner(1, 2, TicTacToeEnums.CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(0, 1, TicTacToeEnums.CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(0, 2, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AssignCellOwner(2, 0, TicTacToeEnums.CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(2, 1, TicTacToeEnums.CellOwners.Human);

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeFalse(); // no winner
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Open); // winner property should be Open
            ticTacToeGame.IdentifyWinner().ShouldBeEmpty(); // there is no winner
        }

        public void WinnerHuman()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AssignCellOwner(0, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AssignCellOwner(1, 1, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AssignCellOwner(2, 2, TicTacToeEnums.CellOwners.Human);

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeTrue(); // winner !
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.IdentifyWinner().ShouldBe("Unnamed Human");
        }

        public void WinnerComputer()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AssignCellOwner(0, 2, TicTacToeEnums.CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(1, 1, TicTacToeEnums.CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(2, 0, TicTacToeEnums.CellOwners.Computer);

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeTrue(); // winner !
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Computer);
            ticTacToeGame.IdentifyWinner().ShouldBe("Computer");
        }

        [TestMethod]
        public void SimnpleAutoPlayComputerNoWinnerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AutoPlayComputer();

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeFalse();
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Open);
        }

        [TestMethod]
        public void SimnpleAutoPlayComputerWinnerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AutoPlayComputer();

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Computer);
        }

        [TestMethod]
        public void AutoPlayComputerWinnerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(0, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(2, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(1, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Computer);
        }

        [TestMethod]
        public void AutoPlayComputerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AssignCellOwner(0, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(2, 2, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(2, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(1, 0, TicTacToeEnums.CellOwners.Human);

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.IdentifyWinner().ShouldBe("Human");
        }

        [TestMethod]
        public void IdentifyWinnerHumanTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.PlayerName = "Prof Reynolds";
            ticTacToeGame.AssignCellOwner(0, 0, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AssignCellOwner(1, 1, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.AssignCellOwner(2, 2, TicTacToeEnums.CellOwners.Human);
            ticTacToeGame.CheckForWinner();

            // assert
            ticTacToeGame.IdentifyWinner().ShouldBe("Prof Reynolds");
        }
    }
}