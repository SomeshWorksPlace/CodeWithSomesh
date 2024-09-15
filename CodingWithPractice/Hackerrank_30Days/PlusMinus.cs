using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

Example

There are  elements, two positive, two negative and one zero. Their ratios are ,  and . Results are printed as:
0.400000
0.400000
0.200000

 Function Description

Complete the plusMinus function in the editor below.

plusMinus has the following parameter(s):

int arr[n]: an array of integers
Print
Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with  digits after the decimal. The function should not return a value.

Input Format

The first line contains an integer, , the size of the array.
The second line contains  space-separated integers that describe 


Output Format

Print the following  lines, each to  decimals:

proportion of positive values
proportion of negative values
proportion of zeros

Sample Input
 STDIN           Function
-----           --------
6               arr[] size n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]

 Sample Output

0.500000
0.333333
0.166667*/
namespace CodeWithSomesh.Hackerrank_30Days
{
    internal class PlusMinus
    {
        class Result
        {

            /*
             * Complete the 'plusMinus' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static void plusMinus(List<int> arr)
            {
                int positiveCount = 0;
                int negativeCount = 0;
                int zeroCount = 0;

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] > 0)
                    {
                        positiveCount++;

                    }
                    else if (arr[i] < 0)
                    {
                        negativeCount++;
                    }
                    else
                    {
                        zeroCount++;
                    }
                }

                double totalarray = arr.Count;
                Console.WriteLine((positiveCount / totalarray).ToString("f6"));
                Console.WriteLine((negativeCount / totalarray).ToString("f6"));
                Console.WriteLine((zeroCount / totalarray).ToString("f6"));
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                Result.plusMinus(arr);
            }
        }

    }
}
