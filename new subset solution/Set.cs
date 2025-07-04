using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_subset_solution
{
    internal class Set
    {
        public List<List<int>> Solve(List<int> nums)
        {
            List<List<int>> result = new List<List<int>>();
            GenerateSubsets(0, nums, new List<int>(), result);
            return result;
        }

        private void GenerateSubsets(int index, List<int> nums, List<int> current, List<List<int>> result)
        {
            if (index == nums.Count)
            {
               result.Add(new List<int>(current));
               Console.WriteLine($"Adding subset:{string.Join(",", current)}");
                
                return;
            }

            
            current.Add(nums[index]);
            Console.WriteLine($"Including {nums[index]}: {string.Join(",", current)}");

            GenerateSubsets(index + 1, nums, current, result);
            current.RemoveAt(current.Count - 1);
            Console.WriteLine($"Backtrack after including {nums[index]}: {string.Join(",", current)}");

            GenerateSubsets(index + 1, nums, current, result);
            Console.WriteLine($"After excluding {nums[index]}: {string.Join(",", current)}");
        }
    }
}
