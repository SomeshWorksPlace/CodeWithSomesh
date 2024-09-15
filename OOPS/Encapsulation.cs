using System;

public class Encapsulation
{
	class Employee
	{
	public int EmpId;
	public string Name;
	public double GrossPay; 
	double TaxDeduction=0.1: //10%
	double netSalary; //the left 

        public Employee(int EmpId, string Name, double GrossPay)
    {
            this.EmpI= EmpId;
			this.Name= Name;
			this.GrossPay= GrossPay;

    }
//this method having no modifier so it is private by default 
		void ClaculateSalary()  
		{
			if (GrossPay > 35000)
			{
				netSalary = GrossPay - (TaxDeduction * GrossPay);
				Console.WriteLine("The Net salary is {0}" + netSalary);
			}
			else
			{
				Console.WriteLine("Your salary is {0}",netSalary);
			}
		}

		//and i will call the above method 
		//by calling above method it will not show any implimentation 
		public void ShowEmployeeDetails()
		{
			this.ClaculateSalary();	
		}
		///Now i want to show the Employee datails and want to hide the Calculate salary code

    }
	class result
	{
        static void Main(string[] args)
        {
			Employee somesh = new Employee(12,"Somesh",18000);

			somesh.ShowEmployeeDetails();

            Employee Rahi = new Employee(12, "Ganesg", 48000);
			Rahi.ShowEmployeeDetails();
            AllDetails.ShowEmployeeDetails();
        }
    }



}
