using System;
using System.Collections.Generic;
using TM.ProgrammingAdvanced;
using System.IO;
using System.Globalization;
namespace Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {   Algo_1 algo_1 = new Algo_1();
            string basedFolder = "3orhyvogped"; // just file name i need no other extra i don't need bcz file are already in the bin 
            Algo_2 algo_2 = new Algo_2();

            Console.WriteLine(algo_1.Algorithm1(basedFolder));
            Console.WriteLine(algo_2.Algorithm2(basedFolder));





            Fictorial factorial = new Fictorial();
            Console.WriteLine(factorial.Algorithm1(7));
            Console.WriteLine(factorial.Algorithm2(7));
            Extra_exercise extra = new Extra_exercise();
            Console.WriteLine(extra.Sum(7));
            Console.WriteLine(extra.CountDigit(2347));
            Console.WriteLine(extra.Reverse("Shahin"));
            Console.WriteLine(extra.Reverse2("Shahin"));

            //1.Multification 
            Multification multification = new Multification();

            //string input = Console.ReadLine();

            //string[] numbers = input.Split(' ');

            //int num1 = int.Parse(numbers[0]); // also possible other way =>|Convert.ToInt32|
            //int num2 = int.Parse(numbers[1]);

            //int result = multification.Multifly(num1, num2);
            //Console.WriteLine($"Multification:{result}");

            //2.Sum
            string[] inputStrings = Console.ReadLine().Split(' ');
            int[] numbers = new int[inputStrings.Length];
            
            New ja = new New();
            ja.ConvertToIntArray(inputStrings, numbers, 0);
            int result2 = ja.SumPrimes(numbers,0);
            Console.WriteLine($"Sum: {result2}");
            

            //3.Second largest number
            //if(inputLo.Length < 2)
            //{
            //    Console.WriteLine("tumse nahi ho paiya ga");
            //}
            //else
            //{
            //    int largest = int.MinValue;
            //    int secondlargest = int.MinValue;
            //    int result3 =multification.SecondLargest(inputLo,0, largest,secondlargest);
            //    Console.WriteLine($"Second Largest: {result3}");
            //}

            // 4.Occurance: 
            //int targe = int.Parse(Console.ReadLine());
            //string[] inputStrings2 = Console.ReadLine().Split(' ');
            //int[] inputL = Array.ConvertAll(inputStrings2, int.Parse);
            //int result4 =multification.Occurance(inputL,targe,0,0);
            //Console.WriteLine($"Occurances: {result4}");

            //5.Unique
            //string array = Console.ReadLine();
            //List<char> enco= new List<char>();
            //int result5 = multification.Unique(array, 0, enco);
            //Console.WriteLine($"Unique: {result5}");

            //6.Vowels
            //string vow = Console.ReadLine().Trim().ToLower();
            //int result6 = multification.Vowels(vow,0);
            //Console.WriteLine($"Vowels: "+ result6);

            //
        }
        
    }
}
