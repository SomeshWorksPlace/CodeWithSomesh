using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.Hackerrank_30DaysCode
{
    internal class Day6Lets_Review
    {
class Solution
    {
        public static void Main(String[] args)
        {
                int N;
                if (int.TryParse(Console.ReadLine().Trim(), out N))
                {
                    // If parsing succeeds, proceed with the rest of the logic
                    for (int i = 0; i < N; i++)
                    {
                        string input = Console.ReadLine();
                        char[] charArray = input.ToCharArray();

                        StringBuilder evenChar = new StringBuilder();
                        StringBuilder oddChar = new StringBuilder();

                        for (int j = 0; j < charArray.Length; j++)
                        {
                            if (j % 2 == 0)
                            {
                                evenChar.Append(charArray[j]);
                            }
                            else
                            {
                                oddChar.Append(charArray[j]);
                            }
                        }
                        Console.WriteLine($"{evenChar} {oddChar}");
                    }
                }
                else
                {
                    // Handle invalid input (e.g., not a valid integer)
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
    }
}
}
