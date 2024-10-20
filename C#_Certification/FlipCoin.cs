using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.C__Certification
{
    internal class FlipCoin
    {
      public class HelloWorld
      {
        public static void Main(string[] args)
        {

            //Random coin = new Random();
            //int flip = coin.Next(0, 2);
            //Console.WriteLine((flip == 0) ? "heads" : "tails");

                Random coin = new Random();
                Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails"); //when we change here 2 in 1 the result will be diffrent 
            }
      }
    }
}
