using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS_Everyting
{
    internal class Constructor_concept
    {

        static void Main(string[] args)
        {
        pizza pizza_ref = new pizza("StruffCrust Pizza", "red sauce","mozzarella","pepperoni","2 Coke");

            //without without sauce
            pizza pizzaWithoutSauce = new pizza("StruffCrust Pizza", "Pesto Sauce", "cheddar");
            //pizza without topings
            pizza pizzaWithoutToping = new pizza("StruffCrust Pizza", "mozzarella", " Onions", "3 cokes");

            Console.ReadKey();
            
        }
    }

class pizza
    {
        //Here we are taking the pizza as a class and I need all the things inside the pizza as the constructor
        //intialize aal the substance in the pizza
        String bread;
        String sauce;
        String cheese;
        String toping;
        String coke;

        public pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            /*this.toping = toping;
            this.coke = coke;*/

        }
        public pizza(String bread, String sauce, String toping, String coke)
        {
            this.bread = bread;
            this.sauce = sauce;
           /* this.cheese = cheese;*/
            this.toping = toping;
            this.coke = coke;

        }

        public pizza(String bread, String sauce, String cheese, String toping, String coke)
        {
            this.bread = bread;
            this.sauce= sauce;
            this.cheese = cheese;
            this.toping = toping;   
            this.coke = coke;   

        }


    }
}
