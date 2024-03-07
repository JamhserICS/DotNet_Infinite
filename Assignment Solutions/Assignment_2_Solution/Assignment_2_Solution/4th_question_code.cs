using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 4. Create a class called Customer with Customerid, Name, Age, Phone,City. Write a constructor with no arguments and another constructor with all information.  
Write a method called DisplayCustomer(), which is called directly without any object. Also  include destructor
 */


namespace Assignment_2_Solution
{
    class Q4Customer //creating class
    {
        private int customerId;
        private string name;
        private int age;
        private string phone;
        private string city;

        // Constructor with no arguments
        public Q4Customer()
        {
            this.customerId = 0;
            this.name = "";
            this.age = 0;
            this.phone = "";
            this.city = "";
        }

        // Constructor with all information
        public Q4Customer(int customerId, string name, int age, string phone, string city)
        {
            this.customerId = customerId;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;
        }

        // Method called DisplayCustomer()
        public static void DisplayCustomer()
        {
            Q4Customer cust = new Q4Customer(1, "John", 30, "123456789", "India");
            Console.WriteLine("Customer ID: " + cust.customerId);
            Console.WriteLine("Name: " + cust.name);
            Console.WriteLine("Age: " + cust.age);
            Console.WriteLine("Phone: " + cust.phone);
            Console.WriteLine("City: " + cust.city);
        }

        // Destructor
        ~Q4Customer()
        {
            Console.WriteLine("Destructor called for Customer object with ID: " + this.customerId);
        }

        static void Main()
        {
            Q4Customer.DisplayCustomer();
            Console.Read();
        }
    }
}
