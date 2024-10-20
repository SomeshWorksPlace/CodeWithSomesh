using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSomesh.Concept_Clear.OOPS
{
    internal class Object
    {
        public class Dog
        {
            //instance variable
            string name;
            int age;
            string color;
            string behaviour;
            string breed;
            string purpose;
            //creating an constructor
            public Dog(string name, int age, string color, string behaviour, string breed, string purpose)
            {
                this.name = name;
                this.age = age;
                this.color = color;
                this.behaviour = behaviour; 
                this.breed=breed;
                this.purpose = purpose; 
            }

            public string Getname()
            {
                return name;
            }

            public int Getage()
            {
                return age;
            }
            public string Getcolor()
            {
                return color;   
            }
            public string Getbehaviour()
            {
                return behaviour;
            }
            public string Getbreed()
            {
                return breed;
            }
            public string Getpurpose()
            {
                return purpose;
            }

            public string ToString()
            {
                Console.WriteLine("Full information of the dog is :::");
                return ("Hi I'm the Owner of this dog, His name is  " + this.Getname()+ "  his age is  "+this.Getage()+"  & his color is "+this.Getcolor() + "His Bredd is " + Getbreed()+ " Breed. He is well train for " + this.Getbehaviour()+ " Purpose, His behaviour is " + this.Getbehaviour()+". ");
            }

            public static void Main()
            {
                Console.WriteLine("Enter the details and Serach for the dog information.");


                Console.WriteLine("Enter the name of dog");
                string name=Console.ReadLine();

                Console.WriteLine("Enter the age of dog");
                int age=int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the color of dog");
                string color=Console.ReadLine();

                Console.WriteLine("Enter the breed of dog");
                string breed=Console.ReadLine();
                
                Console.WriteLine("Enter the purpose of dog");
                string purpose = Console.ReadLine();

                Console.WriteLine("Enter the behiour of dog");
                string behaviour= Console.ReadLine();   

                Dog dog = new Dog(name, age, color ,breed, purpose, behaviour);
                Console.WriteLine( dog.ToString());
            }
        }
       
       
    }
}
