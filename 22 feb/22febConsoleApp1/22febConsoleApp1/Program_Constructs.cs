using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22febConsoleApp1
{
    class Program_Constructs
    {
        //if else code
        public void CheckGrades()
        {
            char grade;
            int maths = 100;
            Console.WriteLine("Enter Grade A/B/C");
            grade = Convert.ToChar(Console.ReadLine());
            if ((grade == 'A' || grade == 'a') && (maths > 90))
                Console.WriteLine("Outstanding");
            else if (grade == 'B' || grade == 'b')
                Console.WriteLine("Very Good");
            else if (grade == 'C' || grade == 'c')
                Console.WriteLine("Good");
            else
                Console.WriteLine("Invalid Grade");
        }

        public void CheckGrades_Switch()
        {
            char grade; 
            int math;
            Console.WriteLine("Enter Grade and maths Score");
            grade = Convert.ToChar(Console.ReadLine());
            math = Convert.ToInt32(Console.ReadLine());
            switch (grade)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("invalid Grade");
                    break;
            }
        }
    }

    class Loops
    {
        //iterations program
        public void WhileLoop()
        {
            int i = 1;
            while (i < 7)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine();
        }

        public static void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 7);
        }

        public void ForLoop()
        {
            int tot = 0;
            for (int i = 0; i <= 7; i++)
            {
                if (i == 2)
                    break;
                    //continue;
                tot += i;
            }
            Console.WriteLine("Sum of all numbers {0}", tot);
        }
    }
}
