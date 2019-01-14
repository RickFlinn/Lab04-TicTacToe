# Lab04-TicTacToe
`Plays a game of Tic-Tac-Toe!`

This application plays a simple game of Tic-Tac-Toe by writing to, and reading from, the user's console. 
The game is played with two players. Each player takes turns using Console inputs to select a position they would like to place their
marker on by entering an integer from 1 to 9, corresponding to the nine spaces on the game board.
```
|1||2||3|

|4||5||6|

|7||8||9|

Player 1 it is your turn
Please select a location
```


If the position has not been played on already, and is a valid position on the game board, their 
marker is placed on that space.
The game ends when one player is able to place three of their markers in a row, making them the winner,
or until all game spaces have been played on. 

```
|X||O||3|

|4||X||6|

|X||O||9|

Player 2 it is your turn
Please select a location

4 // Player Two chooses space 4 using Console input

|X||O||3|

|O||X||6|

|X||O||9|

Player 1 it is your turn
Please select a location

9 // Player One chooses space 9 using Console input

|X||O||3|

|O||X||6|

|X||O||X|

Player One wins!
```
Players must choose a location that exists on the game board, and which does not have a player marker.
If the player attempts to place their marker on a claimed space, they will be prompted to choose another space.
```
|X||O||3|

|O||X||6|

|X||O||9|

Player 1 it is your turn
Please select a location

2 // Player One tries to choose space two, which has Player Two's marker on it already

This space is already occupied
Player 2 it is your turn
Please select a location
```


If all game spaces have been used, but neither player has three markers in a row, the game ends in a draw. 

```
|X||X||O|

|O||X||X|

|X||O||O|

Nobody wins!
```
