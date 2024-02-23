using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22febConsoleApp1
{
    class Static_Instance
    {
        static void Main(string[] args)
        {
            Static_Instance Si = new Static_Instance();
            int sum = Si.AddNo(5, 8);
            Console.WriteLine("The Sum of 2 No :{0}", sum);
            EvenNo_Gen(10);
            Console.WriteLine("------------");
            TestClass.Method1();
            Console.ReadKey();


            Program_Constructs pc = new Program_Constructs();
            pc.CheckGrades();
            pc.CheckGrades_Switch();
            Loops loops = new Loops();
            Console.WriteLine("While Loop");
            loops.WhileLoop();
            Console.WriteLine("For Loop");
            loops.ForLoop();
            Console.WriteLine("Do While Loop");
            Loops.DoWhileLoop();

        }

        public int AddNo(int a, int b) //Instance Method
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public static void EvenNo_Gen(int num)  //static Method
        {
            int i = 0;
            while (i <= num)
            {
                Console.WriteLine(i);
                i += 3;
            }
        }

    }

    class TestClass
    {
        public static void Method1()
        {
            Console.WriteLine("This is a static function of another class");
        }
}
}
