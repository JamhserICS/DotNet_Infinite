using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26FebProject_Test_
{
    class Program_1_to_6_Solutions
    {
        static void Main(string[] args)
        {
            checkEqual();

            checkPosNeg();

            int total = 0, prod, diff, div;
            total = calcu_fun(out diff, out prod, out div);
            Console.WriteLine($"Sum is {total}, product is {prod}, difference is {diff}, Division is {div}");

            printTable();

            calSum();

            findDay();

            Array_Question_Solutions aqs = new Array_Question_Solutions();
            aqs.find_average_min_max();
            aqs.marksOutput();
            aqs.ArrayCopy();

            StringAssesment_Solutions ss = new StringAssesment_Solutions();
            ss.stringSolution();

            Console.ReadKey();

        }

        //1. Write a C# Sharp program to accept two integers and check whether they are equal or not. 
        public static void checkEqual()
        {
            int num1, num2;
            Console.Write("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }


        //2. Write a C# Sharp program to check whether a given number is positive or negative. 
        public static void checkPosNeg()
        {
            int num1;
            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 1)
            {
                Console.WriteLine("Positive number");
            }
            else
            {
                Console.WriteLine("Negative number");
            }
        }


        //3. Write a C# Sharp program that takes two numbers as input and performs all operations (+,-,*,/) on them and displays the result of that operation. 
        public static int calcu_fun(out int diff, out int product, out int division)
        {
            int num1, num2;


            Console.Write("Enter first number to calculate(-,*,/,+): ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second to calculate(-,*,/,+): ");
            num2 = Convert.ToInt32(Console.ReadLine());
            diff = num1 - num2;
            product = num1 * num2;
            division = num1 / num2;
            return num1 + num2;
        }


        //4. Write a C# Sharp program that prints the multiplication table of a number as input.
        public static void printTable()
        {
            int num1;
            Console.Write("Enter a number to print table: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine($"{num1} x {i} = {num1*i}");
            }
        }


        //5.  Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.
        public static void calSum()
        {
            int num1, num2, sum=0;
            Console.Write("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;

            if (num1 == num2)
            {
                Console.WriteLine($"Value is same and triple sum is: {sum*3}");
            }
            else
            {
                Console.WriteLine($"Value is not same and sum is: {sum}");
            }
        }


        //6. Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
        public static void findDay()
        {            
            char day;
            Console.Write("Enter a number to print day: ");
            day = Convert.ToChar(Console.ReadLine());
            switch (day)
            {
                case '1':                
                    Console.WriteLine("Sunday");
                    break;

                case '2':               
                    Console.WriteLine("Monday");
                    break;

                case '3':                
                    Console.WriteLine("Tuesday");
                    break;

                case '4':
                    Console.WriteLine("Wednesday");
                    break;

                case '5':
                    Console.WriteLine("Thursday");
                    break;

                case '6':
                    Console.WriteLine("Friday");
                    break;

                case '7':
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid input(please enter between 1-7)");
                    break;
            }
        }



    }
}
