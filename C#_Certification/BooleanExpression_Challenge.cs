using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.C__Certification
{
    internal class BooleanExpression_Challenge
    {

        public static void Main(string[] args)
        {
            string permission = "Admin|Manager";
            int level = 56;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        
    }
    }
}
