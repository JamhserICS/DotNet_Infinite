using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23FebConsoleApp1
{
    class Array_Program
    {
        static void Main(string[] args)
        {
            // oneDimension();
            // twoDimension();
            // jaggedArray();

            //String_Program strp = new String_Program();
            //strp.string_program();

            Methods_and_Parameters mp = new Methods_and_Parameters();
            //int number = 10;
            //mp.CallByValue(number);
            //Console.WriteLine($"The value of n is {number}");

            //mp.CallByRef(ref number);
            //Console.WriteLine($"The value of n is {number}");

            int total = 0, prod, diff, div;
            total = mp.calcu_fun(10, 15, out diff, out prod, out div);
            Console.WriteLine($"Sum of 10 and 15 is {total}, product is {prod}, difference is {diff}, Division is {div}");
            Console.WriteLine("-----Params example-----");  
            
            total = mp.addElem(); //calling with zero arguments
            Console.WriteLine("The Total is {0}", total);
            Console.WriteLine("----------------");

            total = mp.addElem(7);  //calling the function with one argument
            Console.WriteLine("The Total is {0}", total);
            Console.WriteLine("----------------");

            total = mp.addElem(2, 9, 5, 8, 10, 33);
            Console.WriteLine("The Total is {0}", total);

            Console.WriteLine("--------2nd Params Example Output------");
            mp.param_method2();

            int[] testarray = new int[] { 10, 20, 30 };
            mp.param_method2(testarray);
            mp.param_method2(2, 4, 6, 8, 10, 12);

            mp.param_method3(1, 3.5f);
            mp.param_method3(5, 6.5f, 12.50, 40.5);
            
            Console.ReadKey();
        }

        public static void oneDimension()
        {
            Console.WriteLine("One dimentional output");
            int[] oneArr = new int[5] { 4, 2, 5, 3, 1 };
            //Console.Write(oneArr[1]);

            //for loop for to showing the array value
            for(int i=0; i<oneArr.Length; i++)
            {
                Console.Write(oneArr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void twoDimension()
        {
            Console.WriteLine("Two dimentional output");
            int[,] myArr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(myArr[1, 1]);

            // loop to iterate rows
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(myArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void jaggedArray()
        {
            Console.WriteLine("Jagged array output");
            //declare JA of 2 rows
            int[][] jaggArray = new int[2][];

            //set size of each row
            jaggArray[0] = new int[3];
            jaggArray[1] = new int[2];

            // initialize jagged array
            //first row
            jaggArray[0][0] = 2;
            jaggArray[0][1] = 5;
            jaggArray[0][2] = 7;

            //second row
            jaggArray[1][0] = 6;
            jaggArray[1][1] = 9;

            //diff way initialization
            int[][] jaggedArrayNew =
            {
                new int[]{1,2,3},
                new int[]{5,6},
                new int[]{8,9,2}
            };

            //iterate jagged array
            for(int i=0; i<jaggedArrayNew.Length; i++)
            {
                for(int j=0; j<jaggedArrayNew[i].Length; j++)
                {
                    Console.Write(jaggedArrayNew[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
