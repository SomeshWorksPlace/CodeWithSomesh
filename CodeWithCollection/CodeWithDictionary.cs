using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWithSomesh.CodeWithCollection
{
    internal class CodeWithDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> disclist = new Dictionary<int, string>();

            disclist.Add(1, "C");
            disclist.Add(2, "C++");
            disclist.Add(3, "C#");
            disclist.Add(4, "java");
            disclist.Add(5, "PHP");
            disclist.Add(6, "Python");
            //in the above field we declaire the dictionary by the Key and Value pair
            //Always dictionary declaire with key and value pair
            Console.WriteLine("Count of the dictionary is :: "+disclist.Count);

            //for using for loop it will return the record of dictionary
           foreach (KeyValuePair<int,String> item in disclist) { 
            
                Console.WriteLine("Key : {0}, value:{1} ", item.Key, item.Value );
             
               
            }

            //To get the Key only we need below condtion whcih is gives Key type retun
            Dictionary<int, string>.KeyCollection keyreturn = disclist.Keys;


            foreach (int num in keyreturn)
            {
                Console.WriteLine(" The return of keys is  :{0}", num);
            }


            //To get the values only we need below condtion whcih is gives value type retun
            Dictionary<int, string>.ValueCollection Valuereturn = disclist.Values;

            foreach (string values in Valuereturn)
            {
                Console.WriteLine(" The return of keys is  :{0}", values);
            }


            Console.ReadLine();
        }
    }
}
