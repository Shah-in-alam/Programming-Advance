using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Breaktracking
{
    internal class Queens
    {
        char[,] board;
        int nrOfQueens;
        // bord print 
        public Queens(int n)
        {
            nrOfQueens = n;
            board = new char[nrOfQueens, nrOfQueens];

            for (int i = 0; i < nrOfQueens; i++)
            {
                for (int j = 0; j < nrOfQueens; j++)
                {
                    board[i, j] = '-';
                }
            }
        }
        // checking place is safe for queens
        private bool IsSafe(int row, int col)
        {
            //check column
            for (int i = row; i >= 0; i--)
            {
                if (board[i, col] == 'Q') return false;
            }

            //check row
            for (int i = col; i >= 0; i--)
            {
                if (board[row, i] == 'Q') return false;
            }

            //check upper diagonal
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 'Q') return false;
            }

            //check lower diagonal
            for (int i = row, j = col; i < nrOfQueens && j >= 0; i++, j--)
            {
                if (board[i, j] == 'Q') return false;
            }
            return true;
        }

        // solve the code 
        internal bool Solve(int column)
        {
            //Console.WriteLine(this);

            if (column == nrOfQueens)
            {
                return true;
            }
            for (int i = 0; i < nrOfQueens; i++)
            {
                if (IsSafe(i, column))
                {
                    board[i, column] = 'Q';
                    if (Solve(column + 1)) return true;
                    board[i, column] = '-';
                }
            }
            return false;

        }
        // re write the   whole solution 
        public override string ToString()
        {
            string s = "";// at first it is empty
            for (int i = 0; i < nrOfQueens; i++) // then it 
            {
                for (int j = 0; j < nrOfQueens; j++)
                {
                    s += board[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
