using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 2. Write a console program that uses delegates to call Calculator Functionalities like 1. Addition, 2. Subtraction and 3. Multiplication by 
taking 2 integers and returns the answer to the user. You should display all the return values accordingly.
 */

namespace _14_March_Test_Solution
{

    public delegate int DelegateCalculator(int number1, int number2); //creating delegatge name DelegateCalculator
    class _2nd_Program
    {
        static void Main()
        {

            while (true)
            {
                // taking 1st input from the user
                Console.Write("Enter the 1st number:");
                int n1 = int.Parse(Console.ReadLine());

                // taking 2nd input from the user
                Console.Write("Enter the 2nd number:");
                int n2 = int.Parse(Console.ReadLine());

                // Creating instances of the delegate for addition, subtraction, and multiplication and passing the required mathod like: Add(), Subtract() and Multiply()
                DelegateCalculator addition = new DelegateCalculator(Add);
                DelegateCalculator subtraction = new DelegateCalculator(Subtract);
                DelegateCalculator multiplication = new DelegateCalculator(Multiply);

                // creating integer variable and storing the addition result
                int resultAddition = addition(n1, n2);
                Console.WriteLine($"Addition Result: {n1} + {n2} = {resultAddition}");

                // creating integer variable and storing the addition result
                int resultSubtraction = subtraction(n1, n2);
                Console.WriteLine($"Subtraction Result: {n1} - {n2} = {resultSubtraction}");

                // creating integer variable and storing the addition result
                int resultMultiplication = multiplication(n1, n2);
                Console.WriteLine($"Multiplication Result: {n1} * {n2} = {resultMultiplication}");

                Console.WriteLine();
                Console.Write("Wanna perform another calculation? Please type (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                    break;

            }

            Console.Read();
        }

        // creating method for addition
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        // creating method for subtraction
        static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        // creating method for multiplication
        static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
