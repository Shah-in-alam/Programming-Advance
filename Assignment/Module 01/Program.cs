using System;
using System.IO;
using System.Text;


namespace Module_01
{
    public class Assignment
    {
       public string NthCharacter(int number , string filename)
        
        {
            try
            {
                string allText = File.ReadAllText(filename);
              if( number <= 0 || number >allText.Length)
                {
                    return "Invalid input";
                }
              return allText[number- 1].ToString();
            }
            catch (Exception e){
                return "Error: " + e.Message;
            
            }
        }
        public string NthCharacterOptimized(int number , string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    int currentIndex = 0;
                    int targetIndex = number - 1;
                    while (!reader.EndOfStream)
                    {
                       char ch = (char)reader.Read();
                        if (currentIndex == targetIndex )
                        {
                            return ch.ToString();
                        }
                        currentIndex++;

                    }
                    return "Invalid input";
                }
            }
            catch(Exception e)
            {
                return "Error: "+ e.Message;
            }
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            string filePath = "words.txt";
            int position = Convert.ToInt32(Console.ReadLine());
            Assignment assignment = new Assignment();
            Console.WriteLine("Brute Force Approach: ");
            string resultBruteForce = assignment.NthCharacter(position, filePath);
            Console.WriteLine($"The character at position {position} is: {resultBruteForce}");

          
            Console.WriteLine("\nOptimized Approach:");
            string resultOptimized = assignment.NthCharacterOptimized(position, filePath);
            Console.WriteLine($"The character at position {position} is: {resultOptimized}");
        }
    }
}

