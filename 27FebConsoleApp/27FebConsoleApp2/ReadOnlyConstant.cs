using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27FebConsoleApp2
{
    class ReadOnlyConstant
    {
        readonly bool flag = true; 
        readonly int ronly;  

        //private constructor
        internal ReadOnlyConstant()
        {
            Console.WriteLine(flag + " " + ronly);
            flag = false;
            ronly = 100;  
            Console.WriteLine("-----------");
            Console.WriteLine(flag + " " + ronly);
        }
    }

    class Trial
    {
        public static void Main()
        {
            ReadOnlyConstant rc = new ReadOnlyConstant();
            Console.WriteLine("Hi");
            Console.Read();
        }
    }
}
