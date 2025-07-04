using System;

namespace new_subset_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>ints = new List<int> { 1, 2, 3 };
            Set set = new Set();
            List<List<int>> list = set.Solve(ints);
            foreach(var subset  in list) 
            {
                Console.WriteLine(string.Join(" ",subset));
            }
        }
    }
}
