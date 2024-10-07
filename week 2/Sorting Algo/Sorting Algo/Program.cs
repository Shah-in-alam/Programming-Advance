using System;
namespace Sorting_Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array= { 2, 9, 5, 12, 4, 7, 18, 3 };
            Console.WriteLine(String.Join(" ",array));

            Sort sort = new Sort();
            sort.Bubble(array);
            Console.WriteLine($"Bubble: "+String.Join(" ",array));
            string[] frut = { "banana", "apple", "kiwi", "pinapple", "lemon"};
            Console.WriteLine($"Bubble: "+String.Join(" ", frut));
            sort.Bubble(frut);
            Console.WriteLine($"Bubble: " + String.Join(" ", frut));

            // soting the same array again :     


            array = new int []{ 2, 9, 5, 12, 4, 7, 18, 3 };
            Console.WriteLine($"Selection: "+String.Join(" ", array));
            sort.Selection(array);
            Console.WriteLine($"Selection: " + String.Join(" ", array));
            
            sort.Insertion(array);
            Console.WriteLine($"Insertation: " + String.Join(" ", frut));
        }
    }
}
