using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic Tac Toe game");
            TikTakToeGame game = new TikTakToeGame();
            game.CreateBoard();
        }
    }
}
