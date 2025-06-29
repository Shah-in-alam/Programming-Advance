using System;
using System.Collections.Generic;
/*Simplify a given algebraic string of characters, ‘+’, ‘-‘ operators and parentheses.
 * Output the simplified string without parentheses.
 */
namespace remove_brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1 = "(a-(b+c)+d)";
            String S2 = "a-(b-c-(d+e)) -f";
            Console.WriteLine(simplify(s1));
            Console.WriteLine(simplify(S2));
        }
        // function to simplify the string
        static String simplify(string str)
        {
            int len = str.Length;
            // resultant string of max length equal
            // to length of the string
            char[] res= new char[len];
            int index = 0, i=0;

            // create empty stack
            Stack<int> s = new Stack<int>();
            s.Push(0);
            while (i < len)
            {
                if(str[i] == '(' && i ==0)
                {
                    i++;
                    continue;
                }
                if (str[i] =='+')
                {
                    // if top is 1 flip the operatof
                    if(s.Peek() == 1 )
                    {
                        res[index ++] = '-';

                    }
                    // if top is  0 append the same operator
                    if(s.Peek() == 0)
                    {
                        res[index ++] = '+';
                    }
                }
                else if(str[i] =='-')
                {
                    if(s.Peek() == 1 )
                    {
                        res[index++] = '+';

                    }
                    else if(s.Peek() == 0)
                    {
                        res[index++] = '-';
                    }
                }
                else if (str[i] =='(' && i>0)
                {
                    if (str[i-1] == '-')
                    {
                        // x is opposite to the top of stack
                        int x = (s.Peek() == 1) ? 0 : 1;
                        s.Push(x);
                    }
                    else if (str[i-1] =='+')
                    {
                        s.Push(s.Peek());
                    }
                }
                // if closing parentheses pop the stack once 
                else if (str[i] == ')')
                {
                    s.Pop();
                }
                // copy the character to the result
                else
                {
                    res[index++] = str[i];

                }
                i++;
            }
            return new String(res);
        }
    }
}
