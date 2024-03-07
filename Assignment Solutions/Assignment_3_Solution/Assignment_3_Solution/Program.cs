using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. program calling
            First_Question_Code.display();


            //2. program calling
            _2nd_question_solution.countChar();


            //3. program calling
            _3rd_question_code account = null;
            try
            {
                Console.Write("Enter account holder name: ");
                string str = Console.ReadLine();  //taking name from user and storing in str variable
                Console.Write("Enter id: ");
                int id = Convert.ToInt32(Console.ReadLine()); //taking id from user and storing in id variable
                account = new _3rd_question_code(str,id);

                Console.Write("Enter amount for deposit: ");
                int depo = Convert.ToInt32(Console.ReadLine()); //taking deposit amount from user, converting into integer and storing in depo variable
                account.Deposit(depo);

                Console.Write("Enter amout for withdrawl: ");
                int with = Convert.ToInt32(Console.ReadLine()); //taking withdrawl amount from user, converting into integer and storing in with variable
                account.Withdraw(with);

                Console.WriteLine("Your Balance: " + account.GetBalance()); // printing final balance
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }    
            


            //4. program calling
            _4th_question_code scholarship = new _4th_question_code();

            try
            {
                Console.Write("Enter marks: ");
                int marks = Convert.ToInt32(Console.ReadLine()); //taking marks input from user, converting into integer and storing in marks variable

                Console.Write("Enter fees: ");
                int fees = Convert.ToInt32(Console.ReadLine()); //taking fees amount from user, converting into integer and storing in fees variable

                scholarship.Merit(marks, fees); //passing the marks and fees value in Merit() function
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            //5. program calling
            Doctor doctor = new Doctor();

            Console.Write("Enter Registration number: ");
            int regNo = Convert.ToInt32(Console.ReadLine()); //taking registration number from user, converting into integer and storing in regNo variable
            Console.Write("Enter name: ");
            string name = Console.ReadLine(); //taking name input from user storing in name variable
            Console.Write("Enter fees: ");
            decimal feeChrge = Convert.ToDecimal(Console.ReadLine()); //taking fees amount from user, converting into decimal and storing in feeChrge variable

            doctor.SetDetails(regNo, name, feeChrge); //passing the regNo, name and feeCharge in SetDetails() function
            doctor.GetDetails(); //function calling for getting details of regNo, name and feeCharge


            Console.Read();
        }
    }
}
