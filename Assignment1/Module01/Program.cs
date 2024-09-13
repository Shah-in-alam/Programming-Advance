using System;


namespace Module01
{
     class Program
    {
        static void Main(string[] args)
        {
            // 1st approach : brute force
            Assignment assignment = new Assignment();
            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();
            string result = assignment.FindMissingNumberBruteForce(arr);
            Console.WriteLine(result);

            // 2nd approach: optimized 
            string resultOptimized = assignment.FindMissingNumberOptimized(arr);    
            Console.WriteLine(resultOptimized);
        }
    }
    public class Assignment
    {
        public string FindMissingNumberBruteForce(int[] arr)
        {
            int supposed = arr[0];
            for(int i =0; i<arr.Length; i++)
            {
                if(arr[i] != supposed)
                {
                    return $"Missing number is: {supposed}";
                }
                supposed++;
            }
            return "No Missing number.";
        }
        public string FindMissingNumberOptimized(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left +(right - left) /2;
                if (arr[mid] != arr[0] + mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            if (left < arr.Length && arr[0] + left != arr[left])
            {
                return $"Missing number is : {arr[0] + left}";
            }
            return "No missing number.";

        }
    }
}
