using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In main, show example board");
            Game nugame = new Game(new Player(), new Player());
            Player winner = nugame.Play();
            Console.WriteLine($"{winner.Name}");
        }
    }
}
