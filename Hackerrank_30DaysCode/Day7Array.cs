using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.Hackerrank_30DaysCode
{
    internal class Day7Array
    {
        class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                // Read the list of integers, split by space, and convert to a list of integers
                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
                // Print the array in reverse order
                for (int i = n - 1; i >  0; i--)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

    }
}
//using this code dont use above line of code
/* int n = int.Parse(Console.ReadLine());

// Create an array of integers
int[] arr = new int[n];
*/
// Populate the array with input
/*  for (int i = 0; i < n; i++)
  {
      arr[i] = int.Parse(Console.ReadLine());
  }
*/