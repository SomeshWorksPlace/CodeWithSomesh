using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;


namespace ConsoleApp2.Hackerrank
{
    internal class Demo_Cirtificate
    {
   


class Result
    {

        /*
         * Complete the 'fizzBuzz' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void fizzBuzz(int n)
        {

            

            for (int i = 0; i <= n; i++)
            {

             if(i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine("Fizz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("fizzBuzz");

                }
                else
                {
                    Console.WriteLine(i);

                }
            }
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.fizzBuzz(n);
        }
    }

}
}
