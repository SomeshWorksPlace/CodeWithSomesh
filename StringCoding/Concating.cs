using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.StringCoding
{
    //C# Program to Concatenate Two Strings

    /*
     C# Program to Concatenate Two Strings
     C# Program to Convert Upper case to Lower Case
     C# Program to Convert Characters of a String to Opposite Case
     C# Program to Perform Searching using Predefined Functions
     C# Program to Trim the Given String
     C# Program to Find the Length of a String
     C# Program to Find All Substrings in a String
     C# Program to Encrypt/Decrypt a String using Rijndael Key

     */

    internal class Concating

    {
        static void Main(string[] args)
        {
            //for making the concatenate programm sucessful we have to intialize two variable

            string str = "Someshwar";
            string st1 = "Neware";

            //new we will make the concatinate with each other
            //solution for  the frist COndition
            string concat = String.Concat(str , st1);

            //Concept for the second Condition

            string upper=str.ToUpper();
            
            //Solution for the Third Condition

            
            //

            Console.WriteLine (concat);
            Console.ReadLine();

            
        }
    }
}
