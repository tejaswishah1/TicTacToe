﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
                Console.WriteLine("-------------------");
            }
        }
        public void Move(int input)
        {
            int count = 1;
            if (board[input] != ' ')
            {
                Console.WriteLine("Position already occupied. Enter new position");
                count = 0;
                return count;
                
            }
            Console.WriteLine("What do you want to enter (X or O)");
            char inputChar = char.Parse(Console.ReadLine());
            board[input] = inputChar;
            return count;
        }
        public void Toss()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            if (toss == 0)
            {
                Console.WriteLine("Computer's turn");
                return 0;
            }
            else
            {
                Console.WriteLine("Player's turn");
                return 1;
            }
        }
        public int CheckWinner(char ch)
        {
                if ((board[1] == ch && board[2] == ch && board[3] == ch) ||
                    (board[4] == ch && board[5] == ch && board[6] == ch) ||
                    (board[7] == ch && board[8] == ch && board[9] == ch) ||
                    (board[1] == ch && board[4] == ch && board[7] == ch) ||
                    (board[2] == ch && board[5] == ch && board[8] == ch) ||
                    (board[3] == ch && board[6] == ch && board[9] == ch) ||
                    (board[1] == ch && board[5] == ch && board[9] == ch) ||
                    (board[3] == ch && board[5] == ch && board[7] == ch)
                    )
                {
                    Console.WriteLine("Congrats, You won the game!");
                    ShowBoard();
                    return 1;
                }
                return 0;

            }
        public char ComputerPlay()
        {
            Random random = new Random();
        PlayAgain:
            int compPos = random.Next(1, 9);
            if (board[compPos] == ' ')
            {
                int move = random.Next(0, 2);
                if (move == 0)
                {
                    board[compPos] = 'X';
                    return 'X';
                }
                else
                {
                    board[compPos] = 'O';
                    return 'O';
                }

            }
            else
            {
                goto PlayAgain;
            }
        }
        public int CheckWinningPosition(char compInput)
        {
            int winningPos = 0;
            for (winningPos = 1; winningPos < 10; winningPos++)
            {
                if (board[winningPos] == ' ')
                {
                    board[winningPos] = compInput;
                    int q = CheckWinner(compInput);
                    if (q == 1)
                    {
                        board[winningPos] = ' ';
                        return winningPos;
                    }
                    else
                    {
                        board[winningPos] = ' ';
                        return 0;
                    }
                }
            }
            return 0;
        }
    }
        

    

