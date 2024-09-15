using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.StringCoding
{
    internal class StringDemoClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi User...Enter the String.");

            String str=Console.ReadLine();


            /*Console.WriteLine("Hi User...Enter the Secong String.");

            String str1=Console.ReadLine();
*/
            String End = str.ToUpper();

            Console.WriteLine(End);

            Console.ReadLine();





        }
    }
}
