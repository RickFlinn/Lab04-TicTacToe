using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game nugame = new Game(new Player(), new Player());
            Player winner = nugame.Play();
            if (winner != null)
            {
                Console.WriteLine($"{winner.Name} wins!");
            }
        }
    }
}
