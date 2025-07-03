using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaktracking
{
    internal class my
    {
        public bool helper(char[][] board, int row, int col)
        {
            if (row == board.Length) return true; // Solution found
            int nRow = 0, nCol = 0;

            if (col != board.Length - 1)
            {
                nRow = row;
                nCol = col + 1;
            }
            else
            {
                nRow = row + 1;
                nCol = 0;
            }

            if (board[row][col] != '.')
            {
                return helper(board, nRow, nCol);
            }
            else
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (IsSafe(board, row, col, i))
                    {
                        board[row][col] = (char)(i + '0');
                        if (helper(board, nRow, nCol)) return true;
                        board[row][col] = '.'; // Backtrack
                    }
                }
            }

            return true;
        }
        public bool IsSafe(char[][] board, int row, int col,int number)
        {
            //row and col 
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][col] == (char)(number + '0') || board[row][i] == (char)(number + '0'))
                {
                    return false;
                }
            }
            //grid check is it safe to place the digit
            int sr = (row / 3) * 3; // 
            int sc = (col / 3) * 3;

            for (int i = sr; i < sr + 3; i++)
            {
                for (int j = sc; j < sc + 3; j++)
                {
                    if (board[i][j] == (char)(number + '0')) return false;
                }
            }
            return true;
        }
         public static void printBoard(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    Console.Write(board[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        // multifiation table method
        public static  void PrintTable(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for(int j = 1; j < n; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }
       
    }
}
