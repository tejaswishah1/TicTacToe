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
            game.Input();
            game.ShowBoard();
            Console.WriteLine("Enter the position starting from top left you want to enter your next character");
            int input = int.Parse(Console.ReadLine());
            game.Move(input);


        }
       
    }
}
