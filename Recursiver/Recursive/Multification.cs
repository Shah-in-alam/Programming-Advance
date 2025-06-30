using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class Multification
    {
        // Multifly 
        public int Multifly(int a, int b)
        {
            if (b == 0) return 0;

            return a + Multifly(a, b - 1);
        }
        // Sum of 2 int numbers
        public int Sum(int a, int b)
        {
            if (b == 0) return 0;
            
            return Sum(a^b, (a & b) << 1);
        }
        // Sum of int[] 
        //public int SumPrimes(int[] numbers)
        //{
        //    if (numbers.Length == 0) return 0;
        //    int firstNumbres = numbers[0];
        //    int sumOfRest = 0;
        //    if(numbers.Length > 1)
        //    {
        //        sumOfRest = SumPrimes(RemoveFirst(numbers));
        //    }
        //    return IsPrime(firstNumbres)? firstNumbres+ sumOfRest:sumOfRest;
        //}
        //public bool IsPrime(int number, int divisor = 2)
        //{

        //    if (number <= 1) return false;
        //    if (divisor * divisor > number) return true;
        //    if (number % divisor == 0) return false;
        //    return IsPrime(number, divisor + 1);
        //}
        //public int[]RemoveFirst(int [] numbers)
        //{
        //    if(numbers.Length <=1) return new int[0];
        //    int[] outcome = new int[numbers.Length-1];
        //    Copy(numbers, outcome, 1, 0);
        //    return outcome;
            
        //}
        //private void Copy(int[] source, int[] destination, int sourceIndex,int destIndex)
        //{
        //    if(destIndex>= destination.Length) return;
        //    destination[destIndex] = source[sourceIndex];
        //    Copy(source, destination,sourceIndex+1,sourceIndex+1);
        //}
        //public  void ConvertToIntArray(string[] inputStrings, int[] resultArray, int index)
        //{
        //    if (index >= inputStrings.Length) return;
        //    resultArray[index] = int.Parse(inputStrings[index]);
        //    ConvertToIntArray(inputStrings, resultArray, index + 1);
        //}
        // Second largest numbers.
        public int SecondLargest(int[]arr, int index, int largest, int secondLar)
        {
            if (index>=arr.Length) return secondLar;
            int current = arr[index];
            if (current > largest)
            {
                secondLar = largest;
                largest = current;
            }
            else if(current>secondLar && current<largest) 
            { 
                secondLar = current;
            }

            return SecondLargest(arr,index+1,largest,secondLar); 
        }
       // Occurance 
       public int Occurance(int[] arr, int target, int index, int count)
        {
            if (index == arr.Length) return count;
            if(arr[index] == target)
            {
                count = count + 1;
            }

            return Occurance(arr,target,index+1,count);
        }
        // Unique 
        public  int Unique( string str,int index, List<char>encounted)
        {
            if(index==str.Length) return encounted.Count;
            char Current_char = str[index];
            if (!encounted.Contains(Current_char))
            {
                encounted.Add(Current_char);
            }
            return Unique(str,index+1,encounted); 
        }
        // vowels 
        public int Vowels(string str,int index)
        {
            if (index == str.Length) return 0;
            char vowel = char.ToLower(str[index]);
            int count = 0;
            if ("aeiou".Contains(vowel))
            {
                count = 1;   
            }
            return count+Vowels(str,index+1);
        }
        
    } 
}
