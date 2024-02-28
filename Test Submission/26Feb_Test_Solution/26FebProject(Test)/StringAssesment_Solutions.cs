using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26FebProject_Test_
{
    class StringAssesment_Solutions
    {

        /*Strings Assignment :

              1.  Write a program in C# to accept a word from the user and display the length of it.
              2.  Write a program in C# to accept a word from the user and display the reverse of it. 
              3.  Write a program in C# to accept two words from user and find out if they are same. */


        public void stringSolution()
        {
            string str;
            Console.Write("Enter a word: ");
            str = Console.ReadLine();
            int len =str.Length;
            Console.WriteLine(len);
            char[] charArr = new char[len];
            charArr = str.ToCharArray();
            Array.Reverse(charArr);
            string revStr = new string(charArr);
            Console.WriteLine(revStr);

            string word1, word2;
            Console.Write("Enter first word: ");
            word1 = Console.ReadLine();
            Console.Write("Enter second word: ");
            word2 = Console.ReadLine();

            if (word1.Equals(word2))
            {
                Console.WriteLine("Entered Words are equal");
            }
            else
            {
                Console.WriteLine("Entered Words are not equal");
            }
        }
    }
}
