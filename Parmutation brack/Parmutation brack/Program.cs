using System;
using System.Security.Cryptography;
/*QUESTION: Given a string S,
 * the task is to write a program to print all
 * permutations of a given string. 
 * input: S = “ABC”
Output: “ABC”, “ACB”, “BAC”, “BCA”, “CBA”, “CAB”


Input: S = “XY”
Output: “XY”, “YX”
 */
//https://media.geeksforgeeks.org/wp-content/uploads/20230607112555/file.png
namespace Parmutation_brack
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string s = Console.ReadLine();
            
            Permute(s);
            
            
        }
        static string Swap(string s, int i, int j)
        {
            char[] charArray =s.ToCharArray();
            char temp=charArray[i];
            charArray[i]=charArray[j];
            charArray[j]=temp;
            return new string(charArray);
        }
        static void PermuteRec(string s, int idx)
        {
            if (idx == s.Length - 1)
            {
                Console.WriteLine(s);
            }
            for(int i=idx;i<s.Length; i++)
            {
                s = Swap(s, idx, i);
                PermuteRec(s,idx+1);
                s = Swap(s, idx, i);
            }
        }
        static void Permute(string s)
        {
            PermuteRec(s,0);
           
        }
    }
}
