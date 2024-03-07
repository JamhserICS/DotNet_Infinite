using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 4. Create a class called Scholarship which has a function Public void Merit() that takes marks and fees as an input. 
If the given mark is >= 70 and <=80, then calculate scholarship amount as 20% of the fees
If the given mark is > 80 and <=90, then calculate scholarship amount as 30% of the fees
If the given mark is >90, then calculate scholarship amount as 50% of the fees.
In all the cases return the Scholarship amount

 */


namespace Assignment_3_Solution
{
    class _4th_question_code
    {
        public void Merit(int marks, int fees) //creating method
        {
            if (marks < 0 || marks > 100 || fees < 0)
            {
                throw new ArgumentException("Marks and fees should be non-negative and less than or equal to 100");
            }

            double scholarshipAmount; //variable for storing the scholarship amount

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = fees * 0.2; //calculating scholarship amount as 20% of the fees
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = fees * 0.3; //calculating scholarship amount as 30% of the fees
            }
            else if (marks > 90)
            {
                scholarshipAmount = fees * 0.5; //calculating scholarship amount as 50% of the fees
            }
            else
            {
                throw new Exception("Marks should be between 0 and 100"); //handling exception
            }

            Console.WriteLine("Scholarship amount: " + scholarshipAmount); //printing the scholarship amount
        }       
    }
}
