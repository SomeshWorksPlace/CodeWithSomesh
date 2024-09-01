using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            list.Add("Hira");
            list.Add("Hirendra");
            list.Add("Hireshwar");
            list.Add("Hirabai");


            Console.WriteLine("The Count of the List is ::"+list.Count);
            Console.WriteLine("Capacity Is: " + list.Capacity);

            list.Add("Hirali");
            list.Add("Hirai");

            Console.WriteLine("New The Count of the List is ::" + list.Count);
            Console.WriteLine("New Capacity Is: " + list.Capacity);

            Console.WriteLine("Reading Is: " + list.AsReadOnly());


            Console.WriteLine("Hira is there or not only true or false::::  "+ list.Contains("Hira"));

            Console.WriteLine("Elements Present in List is :: \n");


            int p = 0;
            foreach (string AllList in list)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(AllList);
                p++;
            }








            Console.ReadLine();
        }
    }
}
