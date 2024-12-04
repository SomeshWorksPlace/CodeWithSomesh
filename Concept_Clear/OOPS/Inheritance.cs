using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.Concept_Clear.OOPS
{
    Base class
class GFG
    {

        // data members
        public string name;
        public string subject;

        // public method of base class 
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("My name is : " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    // inheriting the GFG class using : 
    class GeeksforGeeks : GFG
    {

        // constructor of derived class
        public GeeksforGeeks()
        {
            Console.WriteLine("This is Human and ");
        }
    }

    // Driver class
    class Sudo
    {

        // Main Method
        static void Main(string[] args)
        {

            // creating object of derived class
            GeeksforGeeks g = new GeeksforGeeks();

            // calling the method of base class 
            // using the derived class object

            g.readers("Kirti", "C#");
        }
    }
}
