using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a Program to count the no. of occurrences of a letter in a given string (for example in a string called
// “OOPS PROGRAMMING”, O appears 3 times) Hint: Accept a string and also the letter to be counted

namespace Assignment_3_Solution
{
    class _2nd_question_solution
    {

        public static void countChar()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine(); //taking string from the user and storing

            Console.Write("Enter a letter to count: ");
            char letter = Console.ReadLine()[0]; //storing letter

            int count = 0;
            foreach (char c in input) //foreach loop to iterate and count the number of letter which are present in string
            {
                if (c == letter)
                {
                    count++;
                }
            }

            Console.WriteLine("'{0}' appears {1} times", letter, count); //printing the ouput
        }

    }
}
