using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a Class Program which would be used to accepts two  Strings -FirstName and LastName and call the static method Display()
//that displays the first name in one line and the LastName in the second line after converting the same to upper case.

namespace Assignment_3_Solution
{
    class First_Question_Code
    {
        public static void display() //creating the public static function
        {
            string firstName, lastName;

            Console.Write("Enter First name: ");
            firstName =Console.ReadLine(); //storing firstname

            Console.Write("Enter Last name: ");
            lastName =Console.ReadLine(); //storing lastname

            Console.WriteLine($"First name: {firstName.ToUpper()}"); //converting to upper case and print
            Console.WriteLine($"First name: {lastName.ToUpper()}"); //converting to upper case and print

        }
    }
}
