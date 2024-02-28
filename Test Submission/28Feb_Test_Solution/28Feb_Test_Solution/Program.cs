using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Feb_Test_Solution
{
    class Program
    {

        /*1. Write a C# Sharp program to remove the character at a given position in the string. 
            The given position will be in the range 0..(string length -1) inclusive.*/

        public static void removeChar()
        {
            string str;
            int n;
            Console.Write("Enter any string to remove the character : ");
            str = Console.ReadLine();
            Console.Write("Enter the position: ");
            n = Convert.ToInt32(Console.ReadLine());
            string newStr=str.Remove(n, 1);
            Console.WriteLine($"New String is: {newStr}");
        }

        // 2. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
        public static void charExchange()
        {
            string str;                      
            Console.Write("Enter any string exchange the first and last characters: ");
            str = Console.ReadLine();
            int len = str.Length;
            string newStr = str[len - 1]+ str.Substring(1, len - 2) + str[0];            
            Console.WriteLine($"New String is: {newStr}");
            Console.WriteLine();
        }

        //3. Write a C# Sharp program to check the largest number among three given integers.

        public static void largNumber()
        {
            int n1, n2, n3;
            Console.Write("Enter number 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 3: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if(n1 > n3){
                    Console.WriteLine($"{n1} is largest number among three given numbers");
                }
                else
                {
                    Console.WriteLine($"{n3} is largest number among three given numbers");
                }
            }
            else if (n2 > n3)
            {
                Console.WriteLine($"{n2} is largest number among three given numbers");
            }
            else
            {
                Console.WriteLine($"{n3} is largest number among three given numbers");
            }
        }

        static void Main(string[] args)
        {
            removeChar();
            Console.WriteLine("************************************************");
            Console.WriteLine();
            charExchange();
            Console.WriteLine("************************************************");
            Console.WriteLine();
            largNumber();

            Console.ReadKey();
        }
    }
}
