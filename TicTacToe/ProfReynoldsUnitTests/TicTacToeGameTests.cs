using Microsoft.VisualStudio.TestTools.UnitTesting;
using Middle_Tier;
using Shouldly;
using static TicTacToe_Interfaces.TicTacToeEnums;

namespace ProfReynoldsUnitTests
{
    [TestClass]
    public class TicTacToeGameTests
    {

        [TestMethod]
        public void Verify_TicTacToeGame_Instantiation()
        {
            // arrange

            // act
            var ticTacToeGame = new TicTacToeGame();

            // assert instantiation
            ticTacToeGame.ShouldNotBeNull(); // class successfully instantiated
            ticTacToeGame.ShouldBeOfType<TicTacToeGame>();

            // assert player name behavior (before ResetGrid method executed)
            ticTacToeGame.PlayerName.ShouldBe("The Human"); // player name property properly initialized
            ticTacToeGame.PlayerName = "Prof Reynolds";
            ticTacToeGame.PlayerName.ShouldBe("Prof Reynolds");

            // assert winner methods behavior (before ResetGrid method executed)
            ticTacToeGame.CheckForWinner().ShouldBeFalse();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Error);
            ticTacToeGame.IdentifyCellOwner(0, 0).ShouldBe(CellOwners.Error);
            ticTacToeGame.IdentifyWinner().ShouldBe("Error");
        }

        [TestMethod]
        public void ResetGridTest()
        {
            // ResetGrid is necessary and must preceed everything except PlayerName
            var ticTacToeGame = new TicTacToeGame();

            // act
            ticTacToeGame.ResetGrid();

            // assert
            ticTacToeGame.PlayerName.ShouldBe("The Human");
            ticTacToeGame.CheckForWinner().ShouldBeFalse(); // no winner yet
            ticTacToeGame.Winner.ShouldBe(CellOwners.Open); // winner property should now be Open
            ticTacToeGame.IdentifyCellOwner(0, 0).ShouldBe(CellOwners.Open); // _ticTacToeCells should now be initialized to open
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

            // act and assert - assign a cell and check that it is changed
            ticTacToeGame.AssignCellOwner(0, 0, CellOwners.Human);
            ticTacToeGame.IdentifyCellOwner(0, 0).ShouldBe(CellOwners.Human);

            // act and assert - assign a cell as a computer
            ticTacToeGame.AssignCellOwner(0, 1, CellOwners.Computer);
            ticTacToeGame.IdentifyCellOwner(0, 1).ShouldBe(CellOwners.Computer);

            // act and assert - no fault when bad assignment is attempted
            ticTacToeGame.AssignCellOwner(0, 11, CellOwners.Computer); // should not do anything
            ticTacToeGame.AssignCellOwner(0, -1, CellOwners.Computer); // should not do anything
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
             *      X O X
             *      O X O
             */
            ticTacToeGame.AssignCellOwner(0, 0, CellOwners.Human);
            ticTacToeGame.AssignCellOwner(0, 1, CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(0, 2, CellOwners.Human);
            ticTacToeGame.AssignCellOwner(2, 0, CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(2, 1, CellOwners.Human);
            ticTacToeGame.AssignCellOwner(2, 2, CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(1, 0, CellOwners.Human);
            ticTacToeGame.AssignCellOwner(1, 1, CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(1, 2, CellOwners.Human);

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeFalse(); // no winner
            ticTacToeGame.Winner.ShouldBe(CellOwners.Open); // winner property should be Open
            ticTacToeGame.IdentifyWinner().ShouldBeEmpty(); // there is no winner
        }

        [TestMethod]
        public void WinnerHuman()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            /*
             *      X O X
             *      O X O
             *      X
             */
            ticTacToeGame.AssignCellOwner(0, 0, CellOwners.Human);
            ticTacToeGame.AssignCellOwner(0, 1, CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(0, 2, CellOwners.Human);
            ticTacToeGame.AssignCellOwner(1, 0, CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(1, 1, CellOwners.Human);
            ticTacToeGame.AssignCellOwner(1, 2, CellOwners.Computer);
            ticTacToeGame.CheckForWinner().ShouldBeFalse(); // no winner --- yet

            ticTacToeGame.AssignCellOwner(2, 0, CellOwners.Human);
            ticTacToeGame.CheckForWinner().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Human); // winner property should be Human
            ticTacToeGame.IdentifyWinner().ShouldBe(ticTacToeGame.PlayerName);

            ticTacToeGame.PlayerName = ""; // should not happen, but it could!
            ticTacToeGame.IdentifyWinner().ShouldBe("Unnamed Human");
        }

        [TestMethod]
        public void WinnerComputer()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            /*
             *      X O X
             *        O X
             *        O
             */
            ticTacToeGame.AssignCellOwner(0, 0, CellOwners.Human);
            ticTacToeGame.AssignCellOwner(0, 1, CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(0, 2, CellOwners.Human);
            ticTacToeGame.AssignCellOwner(1, 1, CellOwners.Computer);
            ticTacToeGame.AssignCellOwner(1, 2, CellOwners.Human);
            ticTacToeGame.CheckForWinner().ShouldBeFalse(); // no winner --- yet

            ticTacToeGame.AssignCellOwner(2, 1, CellOwners.Computer);
            ticTacToeGame.CheckForWinner().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Computer);
            ticTacToeGame.IdentifyWinner().ShouldBe("Computer");
        }

        [TestMethod]
        public void SimpleAutoPlayComputerWinnerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act and assert - two cells have been played, no winner
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.CheckForWinner().ShouldBeFalse();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Open);

            // act and assert - winner should occur
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.CheckForWinner().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Computer);
        }

        [TestMethod]
        public void AutoPlayComputerWinnerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(0, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(2, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(1, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Human);
        }

        [TestMethod]
        public void AutoPlayComputerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AssignCellOwner(0, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(2, 2, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(2, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AssignCellOwner(1, 0, CellOwners.Human);

            // assert
            ticTacToeGame.CheckForWinner().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Human);
            ticTacToeGame.IdentifyWinner().ShouldBe("The Human");
        }
    }
}
