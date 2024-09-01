using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.CodingWithPractice
{
    // Write a C# program to check if a vowel is present in a string.

    internal class VowelChceking
    {
        static void Main(string[] args)
        {
            /*char[] arr = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', "O", 'U' };*/

            string str ;
            Console.WriteLine("Enter the string ");
            str=Console.ReadLine();
            Console.WriteLine(str);


            int vcount = 0, cCount = 0, other = 0;

            foreach (var vowel in str)
            {
                if( (vowel >= 'a' && vowel <= 'z' ) || (vowel >= 'A' && vowel <= 'Z') )
                {
                    if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                    {
                        vcount++;
                    }

                    else if (vowel == 'A' || vowel == 'E' || vowel == 'I' || vowel == 'O' || vowel == 'U')
                    {
                        vcount++;
                    }
                    else
                        cCount++;
                }
                else 
                {
                        other++;    
                }
            
                   
                }
            Console.WriteLine("Total Length of the String:: " + str.Length);
            Console.WriteLine("Total Length the After vowel present :: " + vcount);
            Console.WriteLine("Total Length the  Constraint present :: " + cCount);
            Console.WriteLine("Total Length the Othr Vlaue present :: " + other);


            Console.ReadLine();
        }
    }
}
