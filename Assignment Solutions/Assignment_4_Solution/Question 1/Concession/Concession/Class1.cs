using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create a class Library Project called Concession. Change the class name to TicketConcession. Inside the class, Write a method called CalculateConcession(int age)  
that takes age as an input and calculates concession for travel as below:
If age<=5 then “Little Champs- Free Ticket” should be displayed along with name and Age
If age >60 then calculate 30% concession on the totalfare
(Which is a constant amount - you can fix Eg:500/-) and Display “ Senior Citizen” + Calculated Fare along with Name and Age
For others Print "Ticket Booked” + Fare along with Name and Age 
*/

namespace Concession
{
    public class TicketConcession // changing the class name with TicketConcession
    {
        private const int TOTAL_FARE = 500;
        public void calculateConcession(int age, string name) //creating function calculateConcession
        {
            if (age <= 5)
            {
                Console.WriteLine($"Little Champs - Free Ticket, Name: {name}, Age: {age}");
            }
            else if (age > 60)
            {
                decimal seniorCitizenFare = TOTAL_FARE * .3m;
                Console.WriteLine($"Senior Citizen - {seniorCitizenFare}, Name: {name}, Age: {age}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - {TOTAL_FARE}, Name: {name}, Age: {age}");
            }
        }
    }
}
