

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
        public class Reverse_WordString
        {
            public static void Main()
            {
                Console.WriteLine("Enter the String :");
                string s = Console.ReadLine();
                string[] a = s.Split(' ');

                Array.Reverse(a);

                Console.WriteLine("--------------------------------");
                Console.Write("The reverse of string is ::");
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    Console.Write(a[i] + ' ');
                }
                Console.ReadKey();
            }
        }
}

