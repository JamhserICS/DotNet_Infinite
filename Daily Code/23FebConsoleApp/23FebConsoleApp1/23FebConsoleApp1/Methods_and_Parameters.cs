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

        //params array example 1:
        public int addElem(params int[] arr)
        {
            int sum = 0;
            foreach(int n in arr)
            {
                sum += n;
            }
            return sum;
        }

        public void param_method2(params int[] num)
        {
            Console.WriteLine("There are {0} number of elements in the Array", num.Length);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

        }
        public void param_method3(int i, float f, params double[] d)
        {
            Console.WriteLine("{0}, {0}", i, f);

            foreach(double dbl in d)
            {
                Console.WriteLine(dbl);
            }
        }
    }
}
