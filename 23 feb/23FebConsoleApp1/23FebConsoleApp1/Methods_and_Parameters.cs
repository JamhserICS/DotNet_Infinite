using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23FebConsoleApp1
{
    class Methods_and_Parameters
    {
        public void CallByValue(int n)
        {
            Console.WriteLine("Outout for CallByValue");
            n = 100;
            Console.WriteLine($"The value of n is {n}");
        }

        public void CallByRef(ref int n)
        {
            Console.WriteLine("Outout for CallByRef");
            n = 100;
            Console.WriteLine($"The value of n is{n}");
        }

        public int calcu_fun(int num1, int num2, out int diff, out int product, out int division)
        {
            Console.WriteLine("Outout for Calculate function");
            diff = num1 - num2;
            product = num1 * num2;
            division = num1 / num2;
            return num1 + num2;
        }
    }
}
