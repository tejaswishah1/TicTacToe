using System;
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
       
        }
    }

    

