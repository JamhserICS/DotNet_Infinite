using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;// adding system.io becuase Stream writer is the part of System.IO

/*
 1. Write a program in C# Sharp to append some text to an existing file. If file is not available, then create one. 
Hint: (Use the appropriate mode of operation. Use stream writer class)
 */


namespace _14_March_Test_Solution
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string wriitngFilePath = @"C:\Users\jamshers\Desktop\DotNet tutorial\Test Submission\14_March_Test_Solution\appended txt file.txt"; //giving the file path where text will be store

                //string filePath2 = @"C:\Users\appended txt file.txt"; //this is wrong path to testing the catch exception

                string writingText;

                Console.Write("Please enter text to append: ");
                writingText = Console.ReadLine();

                try
                {
                    AppendTextToFile(wriitngFilePath, writingText); //calling the AppendTextToFile function
                    Console.WriteLine("Text appended successfully.");
                }
                catch (Exception ex) ////if try not run then it will show exception
                {
                    Console.WriteLine("Error is: " + ex.Message);
                }

                Console.WriteLine();
                Console.Write("Want to add more text? Please type (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                    break;
            }
            Console.Read();
        }

        static void AppendTextToFile(string wriitngFilePath, string writingText) //creating function AppendTextToFile which takes path and text as parameter
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(wriitngFilePath, true)) //this will create file if not exists
                {
                    writer.WriteLine(writingText); //this will write the text variable value in file
                }
            }
            catch (Exception ex) //if try not run then it will show exception
            {
                throw ex;
            }
        }
    }
}
