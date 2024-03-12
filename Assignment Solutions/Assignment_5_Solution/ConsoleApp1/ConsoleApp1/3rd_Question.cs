using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Create an Employee class with Empid int, Empname string, Salary float. Pass values to the members through Constructor.
Create a derived class called ParttimeEmployee with Wages as a data member. 
Instantiate the base class through the derived class constructor 
 */

namespace ConsoleApp1
{
    //Creating class Employee
    class Employee
    {
        //initializing members
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }

        public Employee(int empId, string empName, float salary) // constructor with parameters
        {
            Empid = empId;
            Empname = empName;
            Salary = salary;
        }
    }

    // Derived class-> ParttimeEmployee
    class PartTimeEmployee : Employee
    {
        public float Wages { get; set; }

        public PartTimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary) // Calling the base class constructor -> Employee
        {
            Wages = wages;
        }
    }

    class Program3
    {
        static void Main()
        {
            // Creating object with name partTimeEmp
            PartTimeEmployee partTimeEmp = new PartTimeEmployee(101, "Alice", 25000.0f, 20.0f);

            // Display employee details
            Console.WriteLine($"Employee ID: {partTimeEmp.Empid}");
            Console.WriteLine($"Employee Name: {partTimeEmp.Empname}");
            Console.WriteLine($"Base Salary: {partTimeEmp.Salary:C}");
            Console.WriteLine($"Wages (Part-time): {partTimeEmp.Wages:C}");
            Console.Read();
        }
    }
}
