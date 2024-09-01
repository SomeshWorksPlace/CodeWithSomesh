using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.CodingWithPractice
{

    //How do you swap two numbers without using a third variable in C#?
    internal class swapNumbers
    {
        static void Main(string[] args)
        {
            

            int x = 10;
            int y = 5;

            Console.WriteLine("Before swapping:"
                              + " x = " + x + ", y = " + y);

            Console.WriteLine("---------------------------------------------------------------------");

            if (y == 0)
            {

                y = x;
                x = 0;

            }
            else if (x == 0)
            {
                x = y;
                y = 0;
            }
            //code to swap the element
            else
            {
                x = x + y;
                y = x - y;
                x = x - y;
            }

            Console.WriteLine("After swapping In the Addition :"
                              + " x = " + x + ", y = " + y);


            if (y == 0)
            {
                y = x;
                x = 0;
            }
            else if (x == 0)
            {
                x = y;
                y = 0;
            }
            // Code to swap 'x' and 'y'
            else
            {
                x = x * y; // x now becomes 50
                y = x / y; // y becomes 10
                x = x / y; // x becomes 5
            }

            Console.WriteLine("After swapping iIn The Multiplication:"
                              + " x = " + x + ", y = " + y);
            Console.ReadLine();
        }
    }
}
