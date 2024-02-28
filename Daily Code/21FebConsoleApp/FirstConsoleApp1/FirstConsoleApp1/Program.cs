using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!..Welcome to C#");
            //Console.WriteLine("Enter Your First Name:");
            //string fname = Console.ReadLine();
            // Console.WriteLine("Enter your Last Name:");
            //string lname = Console.ReadLine();
            // Console.WriteLine("Your FirstName is : " + fname + "and your LastName is : " + lname); //concatenation
            // Console.WriteLine("Your FirstName is :{0} and your LastName is :{1}", fname, lname); //place holders


            //type_conversion();
            //forLoop();




            Console.ReadLine();
        }

        public static void arrayProgram()
        {
            int[] arr = new int[];
        }

        public static void forLoop()
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void type_conversion()
        {
            int i = 100;
            Console.WriteLine(i);

            float f = 10f;
            Console.WriteLine(f);

            i =(int) f;
            Console.WriteLine(f);

            

            float ff = 101f;
            int xx = Convert.ToInt32(ff);
            Console.WriteLine(xx);

            string str = "infinite";
            int x;
            bool succ = int.TryParse(str, out x);

            if (succ)
            {
                Console.WriteLine("parse number is {0}", x);
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }

    }
}
