using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Objective
In this challenge, you will work with arithmetic operators. Check out the Tutorial tab for learning materials and an instructional video.

Task
Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip), and tax percent (the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost. Round the result to the nearest integer.

Example



A tip of 15% * 100 = 15, and the taxes are 8% * 100 = 8. Print the value  and return from the function.

Function Description
Complete the solve function in the editor below.

solve has the following parameters:

int meal_cost: the cost of food before tip and tax
int tip_percent: the tip percentage
int tax_percent: the tax percentage
Returns The function returns nothing. Print the calculated value, rounded to the nearest integer.

Note: Be sure to use precise values for your calculations, or you may end up with an incorrectly rounded result.

Input Format

There are  lines of numeric input:
The first line has a double,  (the cost of the meal before tax and tip).
The second line has an integer,  (the percentage of  being added as tip).
The third line has an integer,  (the percentage of  being added as tax).

Sample Input

12.00
20
8
Sample Output

15
Explanation

Given:
, , 

Calculations:




We round  to the nearest integer and print the result, .

Language
C#
More
3031323334353637383940414243444546474849505152
}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());


Line: 39 Col: 15

Test against custom input
Congratulations
You solved this challenge. Would you like to challenge your friends?Share on FacebookShare on TwitterShare on LinkedIn

Test case 0

Test case 1

Test case 2

Test case 3
Compiler Message
Success
Input (stdin)
12.00
20
8
Expected Output
15

 */
namespace CodeWithSomesh.Hackerrank_30DaysCode
{
    internal class Day2Operator
    {

        class Result
        {
            /*
             * Complete the 'solve' function below.
             *
             * The function accepts following parameters:
             *  1. DOUBLE meal_cost
             *  2. INTEGER tip_percent
             *  3. INTEGER tax_percent
             */
            double meal_cost;
            int tip_percent;
            int tax_percent;
            public static void solve(double meal_cost, int tip_percent, int tax_percent)
            {
                // Calculate the total cost
                double totalCost = meal_cost + meal_cost * tip_percent / 100 + meal_cost * tax_percent / 100;

                // Round the total cost to the nearest integer and print it
                Console.WriteLine(Math.Round(totalCost));
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

                int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

                int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

                Result.solve(meal_cost, tip_percent, tax_percent);
            }
        }

    }
}
