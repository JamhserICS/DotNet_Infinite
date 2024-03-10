using System;
using System.Collections.Generic;
using System.Linq;
using Concession;
using System.Text;
using System.Threading.Tasks;

/*
Create a Console application to test the above project. Inside Class Program have int TotalFare as Constant, Name, Age as properties.  
Accept Name, Age from the user and call the CalculateConcession() method and print the details accordingly
(Hint : Add required references)
*/



namespace ConcessionConsoleApp
{
    class Program
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private const int TOTAL_FARE = 500;


        static void Main(string[] args)
        {
            Program pg = new Program();

            Console.Write("Enter Age: ");
            pg.Age = Convert.ToInt32(Console.ReadLine()); //taking input from the user

            Console.Write("Enter Name: ");
            pg.Name = Console.ReadLine(); //taking input from the user

            TicketConcession tc = new TicketConcession(); // creating the objects of the TicketConcession class

            tc.calculateConcession(pg.Age, pg.Name); //calling calculateConcession() function

            Console.Read();
        }
    }
}
