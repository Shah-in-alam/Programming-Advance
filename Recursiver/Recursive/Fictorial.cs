using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class Fictorial
    {   
        // iterative way
        public int Algorithm1(int n)
        {
            int value = 1;
            for(int i = 1; i < n; i++)
            {
                 value *= i;
                
            }
            return value;
        }
        public int Algorithm2(int n)
        {    
            Console.WriteLine("Call with "+n);
            if (n <= 1) return 1;
            int value = n * Algorithm2(n - 1);
            Console.WriteLine(value);
             return value;

            /* actual code can be like this
             if(n <=1) return 1;
            return n* Algorithm2(n-1);
             */
            
        }
    }
}
