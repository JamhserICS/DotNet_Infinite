using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 4. Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method. Create 2 classes Dayscholar 
and Resident that implements the interface Properties and Methods.
 */

namespace ConsoleApp1
{
    public interface IStudent //creating the Interface with name IStudent
    {
        //initializing members
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    public class DayScholar : IStudent //creating class and inheritaing the IStudent interface
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails() //creating the mathod for showing the details
        {
            Console.WriteLine($"Dayscholar - Student ID: {StudentId}, Name: {Name}");
            Console.WriteLine("Type: Day Scholar");
        }
    }

    public class Resident : IStudent //creating another class and inheritaing the IStudent interface
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Resident - Student ID: {StudentId}, Name: {Name}");
            Console.WriteLine("Type: Resident");
        }
    }

    class Program4
    {
        static void Main(string[] args)
        {
            IStudent student1 = new DayScholar() { StudentId = 1, Name = "John Doe" }; //creaitng object with passing the values
            IStudent student2 = new Resident() { StudentId = 2, Name = "Jane Doe" }; //creaitng object with passing the values
            student1.ShowDetails(); //calling fucntion to show details
            student2.ShowDetails(); //calling fucntion to show details
            Console.Read();
        }
    }
}
