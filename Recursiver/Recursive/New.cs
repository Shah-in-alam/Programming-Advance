using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class New
    {
        public void ConvertToIntArray(string[] inputStrings, int[] resultArray, int index)
        {
            if (index >= inputStrings.Length) return;
            resultArray[index] = int.Parse(inputStrings[index]);
            ConvertToIntArray(inputStrings, resultArray, index + 1);
        }

        
        public int SumPrimes(int[] numbers, int index)
        {
            if (index >= numbers.Length) return 0;

            int currentNumber = numbers[index];
            int sumOfRest = SumPrimes(numbers, index + 1);

            return IsPrime(currentNumber) ? currentNumber + sumOfRest : sumOfRest;
        }

       
        public bool IsPrime(int number, int divisor = 2)
        {
            if (number <= 1) return false;
            if (divisor * divisor > number) return true;
            if (number % divisor == 0) return false;
            return IsPrime(number, divisor + 1);
        }
    }
}
