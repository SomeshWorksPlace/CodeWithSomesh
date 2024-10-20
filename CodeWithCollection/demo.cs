using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.CodeWithCollection
{
    internal class demo
    {
        public static void main()
        {
            string name = "somesh neware india";
            string revstring = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                revstring = revstring + name[i];
            }
            Console.WriteLine(revstring);
            Console.ReadLine();
        }
        
    }
}
