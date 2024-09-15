using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class RemoveWovel
    {

        static String Vowel_Conditioning(String str)
        {
            //we are declaring the cowel character inside the char array having vowel 
            char[] chars = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            List<char> Char_list = chars.OfType<char>().ToList(); //this is coming form the Linq mehtod which ia havinf IEnumerable
           

            StringBuilder sb = new StringBuilder(str);

            for
                (int i = 0; i <=sb.Length; i++)
            {
                chars.Contains[i];
            }



         }
        static void Main(string[] args)
        {
            

        }



        /*
         // C# program to remove vowels from a String 
        using System; 
        using System.Text; 
        using System.Linq; 
        using System.Collections.Generic; 
        public class Test 
        {	 
            static String remVowel(String str) 
            { 
                char []vowels = {'a', 'e', 'i', 'o', 'u','A','E','I','O','U'}; 

                List<char> al = vowels.OfType<char>().ToList();; 

                StringBuilder sb = new StringBuilder(str); 

                for (int i = 0; i < sb.Length; i++) { 

                    if(al.Contains(sb[i])){ 
                        sb.Replace(sb[i].ToString(), "") ; 
                        i--; 
                    } 
                } 


                return sb.ToString(); 
            } 
            // Driver method to test the above function 
            public static void Main() 
            { 
                String str = "GeeeksforGeeks - A Computer Science Portal for Geeks"; 

                Console.Write(remVowel(str)); 
            } 
        } 
        //This code is contributed by Rajput-Ji 

         */
    }
}
