using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26FebProject_Test_
{
    class Array_Question_Solutions
    {
        /*1. Write a  Program to assign integer values to an array  and then print the following
           a.Average value of Array elements
           b.Minimum and Maximum value in an array*/

        public void find_average_min_max()
        {
            int[] array = new int[5] { 10, 1, 30, 9, 50 };
            int arrayLength = array.Length;
            int sum = 0, average = 0;


            // a.Average value of Array elements
            for (int i = 0; i < arrayLength; i++)
            {
                sum += array[i];
            }
            average = sum / arrayLength;
            Console.WriteLine($"Average value of Array elements: {average}");


            //b.Minimum and Maximum value in an array
            int min = array[0];
            int max = array[0];

            for(int i=1; i<arrayLength; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                else
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Minimum value of array is: {min}");
            Console.WriteLine($"Maximum value of array is: {max}");
        }

        /*2.  Write a program in C# to accept ten marks and display the following
                  a.Total
                  b.Average
                  c.Minimum marks
                  d.Maximum marks
                  e.Display marks in ascending order
                  f.Display marks in descending order*/

        public void marksOutput()
        {
            int[] markArray = new int[10];
            int arrLen = markArray.Length;
            int total = 0, average = 0, count=1, a=0;
            
            for(int i=0; i<arrLen; i++)

            {
                Console.Write($"Enter marks {count++}: ");
                markArray[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            int min = markArray[0], max = markArray[0];

            for (int i=0; i<arrLen; i++)
            {
                total += markArray[i]; //calculate total
                average = total / arrLen; //calculate average

                if (min > markArray[i])
                {
                    min = markArray[i]; //calculate minimum
                }
                else
                {
                    max = markArray[i]; //calculate maximum
                }
                
                for(int j=i+1; j<arrLen; j++)
                {
                    if (markArray[i] > markArray[j])
                    {
                        a = markArray[i];
                        markArray[i] = markArray[j];
                        markArray[j] = a;
                    }
                }
            }
            Console.WriteLine($"Total is: {total}");
            Console.WriteLine($"Average is: {average}");
            Console.WriteLine($"Minimum is: {min}");
            Console.WriteLine($"Maximum is: {max}");
            Console.Write("Ascending Order is:");

            for(int i=0; i<arrLen; i++)
            {
                Console.Write($" {markArray[i]}");
            }

            Console.WriteLine();

            Console.Write("Descending Order is:");
            for (int i = arrLen-1; i >= 0; i--)
            {
                Console.Write($" {markArray[i]}");
            }


        }

        //3.  Write a C# Sharp program to copy the elements of one array into another array.(do not use any inbuilt functions)

        public void ArrayCopy()
        {
            int[] arr1 = new int[5] { 1, 2, 65, 7, 8 };
            int[] arr2 = new int[arr1.Length];

            for(int i=0; i<arr1.Length; i++)
            {
                arr2[i] = arr1[i];               
            }
        }


    }
}
