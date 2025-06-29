using System;
using System.Collections.Generic;

/*Given a sequence of n strings, 
 * the task is to check if any two similar words come together
 * and then destroy each other then print the number of words left in 
 * the sequence after this pairwise destruction.
 */
namespace Delet_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>v = new List<string>();
            v.Add("ab");
            v.Add("aa");
            v.Add("aa");
            v.Add("bcd");
            v.Add("ab");
            Console.WriteLine(removeConsecutiveSum(v)); 
        }
        public static int removeConsecutiveSum(List<string> v)
        {
            int n = v.Count;
            // Start traversing the sequence  
            for (int i = 0;i<n-1;)
            {
                // Compare the current string with  
                // next one Erase both if equal 
                if (v[i].Equals(v[i+1]))
                {
                    // Erase function delete the element and  
                    // also shifts other element that's why  
                    // i is not updated 
                    v.RemoveAt(i);
                    v.RemoveAt(i);

                    // Update i, as to check from 
                    // previous element again
                     if(i>0)
                    {
                        i--;
                    }
                    // Reduce sequence 
                    n = n - 2;

                }
                else
                {
                    // Increment i, if not equal 
                    i++;
                }

            }
            // return modified size
            return v.Count;
        }
    }
}
