using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Player
    {
		public string Name { get; set; }
		/// <summary>
		///     P1 is X and P2 will be O
		/// </summary>
		public string Marker { get; set; }

		/// <summary>
		///     Flag to determine if it is the user's turn
		/// </summary>
		public bool IsTurn { get; set; }

        /// <summary>
        ///     Asks the player to select a board location to play on. Prompts and reads user input from the console
        ///     until the user enters a valid play location, then returns a new Position object containing
        ///     coordinates corresponding to the selected play space. 
        ///     
        ///     Called within the TakeTurn method to determine the user's desired turn action.
        /// </summary>
        /// <param name="board"></param>
        /// <returns>Number corresponding to a board space coordinate</returns>
		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location");
				if (Int32.TryParse(Console.ReadLine(), out int position))
                {
                    desiredCoordinate = PositionForNumber(position);
                } else
                {
                    return GetPosition(board);
                }
			}
			return desiredCoordinate;

		}


        /// <summary>
        ///     Takes in an integer, that represents a space on the game board. If that 
        ///     integer is between 1 and 9, a Position object corresponding to the chosen space is returned.
        ///     If the integer is outside of this range, no position is returned. 
        ///     
        ///     This method is called by the GetPosition function, and serves to convert the user's input
        ///     into a usable Position object.
        /// </summary>
        /// <param name="position">integer representing a space on the game board</param>
        /// <returns>Position object for given coordinate if position is valid; otherwise returns null</returns>
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); // Top Left
				case 2: return new Position(0, 1); // Top Middle
				case 3: return new Position(0, 2); // Top Right
				case 4: return new Position(1, 0); // Middle Left
				case 5: return new Position(1, 1); // Middle Middle
				case 6: return new Position(1, 2); // Middle Right
				case 7: return new Position(2, 0); // Bottom Left
				case 8: return new Position(2, 1); // Bottom Middle 
				case 9: return new Position(2, 2); // Bottom Right

				default: return null;
			}
		}

	    /// <summary>
        ///     This method performs the process of a player taking their turn.
        ///     First, the player's turn status is set to true. Then, the player is informed
        ///     it is their turn and they are prompted to select a gamespace to play on.
        ///     Once they select a space they would like to play on, the position on the gameboard
        ///     is checked. If it contains an integer, i.e. it has not been played on, it is a valid move
        ///     and the player's marker is placed on that space. If it has been played on, the game
        ///     informs the player that the selected space is occupied and they are prompted to choose another
        ///     space.
        ///     
        ///     Called within the Game class's method, Play(), every time a player is to take a turn.
        /// </summary>
        /// <param name="board"></param>
		public void TakeTurn(Board board)
		{
			IsTurn = true;

			Console.WriteLine($"{Name} it is your turn");

			Position position = GetPosition(board);

			if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
			{
				board.GameBoard[position.Row, position.Column] = Marker;
			}
			else
			{
				Console.WriteLine("This space is already occupied");
                TakeTurn(board);
			}
		}
	}
}
