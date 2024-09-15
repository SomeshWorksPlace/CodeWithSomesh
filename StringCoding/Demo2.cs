using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.StringCoding
{
    internal class Demo2
    {

        static void Main(string[] args)
        {
            //Array syntaxt 
            //  DataTpe[] arr_Var = new DataType[Size];
            //string [] arr=new {'s','o','m',,,,,,};



            //String 
            //1st approch

            /* String[] str_arr = new String[100];
             str_arr[0] = "someshwar";
             str_arr[1] = "Suhakar";
             str_arr[2] = "Neware";

             for (int i =0; i<str_arr.Length;i++)
             {
                 Console.WriteLine(str_arr[i]);
             }*/



            //2nd approch
            /* String str = "Someshwar sudhakar Neware ";


             Console.WriteLine(str);

             Console.ReadLine();

             Console.WriteLine("Hira SOmesh Love Each Other ");

             String str=Console.ReadLine();
             Console.WriteLine(str);

 */

            StringDemoClass testString;
            Console.Write("Enter a string - ");
            testString = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", testString);
        Console.ReadLine();
        }



        /*


        String Name; //Class
        Name = "Geek";

        string id;  //variable
        id = "33";

        string mrk;  //variable
        mrk = "97";

        string rank = "1"; //variavble


        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Id: {0}", id);
        Console.WriteLine("Marks: {0}", mrk);
        Console.WriteLine("Rank: {0}", rank);
    Console.ReadLine();
    */
    }
}
   