using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class Extra_exercise
    {
        //sum of the natural number
        public int Sum(int n)
        {
            if( n==0) return 0;
            return n+Sum(n-1);
        }
        public int CountDigit(int number)
        {
          // return number.ToString().Length;
          if (number==0) return 0;
            return 1 + CountDigit(number / 10);
        
            
        }
        public string Reverse(string text)
        {
            if (text.Length==0) return "";
            return text[text.Length-1] + Reverse(text.Substring(0,text.Length-1));

        }
        public string Reverse2(string text)
        {
            if (text.Length == 0) return "";
            return Reverse2(text.Substring(1))+text[0];

        }
    }
}
