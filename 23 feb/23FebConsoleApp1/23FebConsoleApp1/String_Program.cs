using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23FebConsoleApp1
{
    class String_Program
    {
        public void string_program()
        {
            Console.WriteLine("Output for String Program");
            char[] carr = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string myStr = new string(carr);
            Console.WriteLine(myStr);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This is string builder");
            Console.WriteLine(sb);
        }
    }
}
