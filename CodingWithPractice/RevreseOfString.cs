using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.CodingWithPractice
{
    //WAP to revrese the string 
    internal class RevreseOfString
    {

          public void Revrese(String input)
          {
            
                    var strlogic = input.ToCharArray();

                    //bo=elow this line of code it will revrese the charachter of line into the revese order 
                    Array.Reverse(strlogic);

            //finally we will conver the Character into String type to we will create object
                    String result = new string (strlogic);

                    Console.WriteLine("Your Reverse of string is "+result);


                }
        public static void Main(string[] args)
        {

            RevreseOfString obj= new RevreseOfString();
            obj.Revrese("SOMESHWAR");

            Console.ReadLine();

          
        }

    }
    }

/*
----------------------------------------------------------------------------------------------------------
//using normal Loop 

 string str, revstring = "";

            Console.WriteLine("Enter the String :: ");
            str = Console.ReadLine();
            Console.WriteLine("Yuo have Enter :::  " + str);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstring += str[i];

            }
            Console.WriteLine("The Reverse of string is {0} \n" + revstring);
            Console.ReadLine();

 --------------------------------------------------------------------------------------------------------------

USing Revese MEthod 

public void Revrese(String input)
          {
            
                    var strlogic = input.ToCharArray();

                    //bo=elow this line of code it will revrese the charachter of line into the revese order 
                    Array.Reverse(strlogic);

            //finally we will conver the Character into String type to we will create object
                    String result = new string (strlogic);

                    Console.WriteLine("Your Reverse of string is "+result);


                }
        public static void Main(string[] args)
        {

            RevreseOfString obj= new RevreseOfString();
            obj.Revrese("SOMESHWAR");

            Console.ReadLine();

          
        }

-----------------------------------------------------------------------------------------------------------
Using String or String Builder



 
 
 
 */









