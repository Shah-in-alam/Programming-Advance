using System;
using System.ComponentModel.Design;
using System.IO;
namespace Breaktracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queens queens = new Queens(4);
            //queens.Solve(0);
            //Console.WriteLine(queens);

            //Subset subset = new Subset();
            //List<int> input = new List<int> { 7,10,4};
            //foreach (var item in subset.Solve(input))
            //{
            //    Console.WriteLine(String.Join(" ",item));
            //}
            //


            /// sudoko board: 
            char[][] board = new char[][]
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };
            my solver = new my();
            if (solver.helper(board, 0, 0))
            {
                Console.WriteLine("Solved Sudoku:");
                Console.WriteLine();
                my.printBoard(board);
            }
            else 
            {
                Console.WriteLine("No solution fond.");
            }

            /// Multifiaction table:
            Console.WriteLine(" Enter the size of the table: ");
            int n = int.Parse(Console.ReadLine());
            my.PrintTable(n);

        }
        

    }
}
