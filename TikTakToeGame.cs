﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{

    public class TikTakToeGame
    {
        char[] board = new char[10];
      
        public void CreateBoard()
        {
            int i = 0;
            char[] board = new char[10];
            for (i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
        }
        public void Input()
        {
            int i = 1;
            Console.WriteLine("What do you want to input(X or O)?");
            char input = char.Parse(Console.ReadLine());
            board[i] = input;
            i++;
        }
        public void ShowBoard()
        {
            int c = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(board[c] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
    

    

