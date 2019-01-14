using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe;

namespace TicTacTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestForWinner()
        {
            Game game = new Game(new Player(), new Player());
            game.Board.GameBoard = new string[,]
            {
                { "X", "2", "3" },
                { "4", "X", "6" },
                {"7", "8", "X" }
            };
            Assert.True(game.CheckForWinner(game.Board));
        }

        [Fact]
        public void TestNoWinner()
        {
            Game game = new Game(new Player(), new Player());
            game.Board.GameBoard = new string[,]
            {
                { "X", "O", "X" },
                { "4", "5", "6" },
                {"7", "X", "O" }
            };
            Assert.False(game.CheckForWinner(game.Board));
        }

        [Fact]
        public void TestSwitchPlayers()
        {
            Game game = new Game(new Player(), new Player());
            game.PlayerOne.IsTurn = true;
            bool playerOneStarted = game.PlayerOne.IsTurn;
            bool playerTwoStarted = game.PlayerTwo.IsTurn;
            game.SwitchPlayer();
            Assert.True(playerOneStarted && !playerTwoStarted && !game.PlayerOne.IsTurn && game.PlayerTwo.IsTurn);
        }

        [Theory]
        [InlineData(new int[] { 0, 0 }, 1)]
        [InlineData(new int[] { 0, 2 }, 3)]
        [InlineData(new int[] { 2, 1 }, 8)]
        [InlineData(new int[] { 1, 1 }, 5)]
        public void TestPositions(int[] coords, int num)
        {
            Position expectedPosition = new Position(coords[0], coords[1]);
            Position returnedPosition = Player.PositionForNumber(num);
            Assert.True(expectedPosition.Row == returnedPosition.Row && expectedPosition.Column == returnedPosition.Column);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(-1)]
        [InlineData(1000000000)]
        public void TestNullPosition(int badPosition)
        {
            Assert.True(Player.PositionForNumber(badPosition) == null);
        }
    }
}
