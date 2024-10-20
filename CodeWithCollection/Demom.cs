using System;
using System.Collections.Generic;

namespace Demo
{
    public class Demom
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter numbers separated by spaces:");
            // Accept user input and split the string into an array of strings
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');

            // Convert the string array to an integer array
            int[] arr = Array.ConvertAll(inputArr, int.Parse);

            var d = new Dictionary<int, int>();

            foreach (var res in arr)
            {
                if (d.ContainsKey(res))
                    d[res]++;
                else
                    d[res] = 1;
            }

            foreach (var val in d)
                Console.WriteLine("{0} occurred {1} times", val.Key, val.Value);

        }
    }
}
