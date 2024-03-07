using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.Create a class called student which has data members like rollno, name, class, Semester, branch, int[] marks = new int marks [5](marks of 5 subjects )
-Pass the details of student like rollno, name, class, SEM, branch in constructor
- For marks write a method called GetMarks() and give marks for all 5 subjects
-Write a method called displayresult, which should calculate the average marks
-If marks of any one subject is less than 35 print result as failed
-If marks of all subject is >35, but average is < 50 then also print result as failed
-If avg > 50 then print result as passed.
-Write a DisplayData() method to display all values.*/


namespace Assignment_2_Solution
{
    class Q2Student //Defining class
    {
        private int rollNo;
        private string name;
        private int className;
        private int semester;
        private string branch;
        private int[] marks = new int[5];

        public Q2Student(int rollNo, string name, int className, int semester, string branch) //constructor with aurgumnets
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Subject " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayData() //method to display data
        {
            Console.WriteLine("Roll No: " + this.rollNo);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Class: " + this.className);
            Console.WriteLine("Semester: " + this.semester);
            Console.WriteLine("Branch: " + this.branch);
            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ": " + this.marks[i]);
            }
        }

        public string DisplayResult()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += this.marks[i];
            }
            double avg = (double)sum / 5;

            if (this.marks.Any(m => m < 35))
            {
                return "Failed";
            }
            else if (avg < 50)
            {
                return "Failed";
            }
            else
            {
                return "Passed";
            }
        }
        static void Main()
        {
            Q2Student myStudent = new Q2Student(1, "John", 12, 3, "CSE");
            myStudent.GetMarks();
            myStudent.DisplayData();
            Console.WriteLine("Result: " + myStudent.DisplayResult());
            Console.Read();
        }
    }
}
