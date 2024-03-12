using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a class Box that has Length and breadth as its members. 
Write a function that adds 2 box objects and stores in the 3rd. Create a Test class to execute the above.
 */


namespace ConsoleApp1
{
    class Box //creating the Box class
    {
        //initializing the members
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Box(int length, int breadth) // constructor with parameters
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box add(Box box1, Box box2) //function with return type Box
        {
            int l = box1.Length + box2.Length;
            int b = box1.Breadth + box2.Breadth;

            return new Box(l, b);
        }
    }

    class TestClass //Test for testing the program
    {
        static void Main()
        {
            Console.Write("Enter 1st Box length : "); //taking input from the user
            int l1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Box length : "); //taking input from the user
            int l2 = int.Parse(Console.ReadLine());

            Console.Write("Enter 1st Box breadth : "); //taking input from the user
            int b1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Box breadth : "); //taking input from the user
            int b2 = int.Parse(Console.ReadLine());

            //creating objects and passing the values
            Box box1 = new Box(l1, b1); 
            Box box2 = new Box(l2, b2);

            Box box3 = Box.add(box1, box2); //adding 2 box objects and storing in the 3rd object

            Console.WriteLine($"Box3 length is {box3.Length} and Box3 breadth is {box3.Breadth}"); //printing box3 length and breadth
            Console.Read();
        }
    }
}
