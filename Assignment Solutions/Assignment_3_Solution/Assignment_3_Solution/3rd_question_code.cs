using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3.•	You have a class which has methods for transaction for a banking system. (created earlier)
•	Define your own methods for deposit money, withdraw money and balance in the account.
•	Write your own new application Exception class. 
•	This new Exception will be thrown in case of withdrawal of money from the account where customer doesn’t have sufficient balance.
•	Identify and categorized all possible checked and unchecked exception.*/


namespace Assignment_3_Solution
{
    class _3rd_question_code
    {
            public string Name { get; private set; }
            public int Id { get; private set; }
            private decimal balance;

            public _3rd_question_code(string name, int id) //paramiteraized constructor
            {
                Name = name;
                Id = id;
            }

            public void Deposit(decimal amount) //function to deposit money
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be greater than zero.");
                }

                balance += amount;
            }

            public void Withdraw(decimal amount) //function to withdrawl money from the user account
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be greater than zero.");
                }

                if (balance < amount)
                {
                    throw new InsufficientBalanceException("Insufficient balance.");
                }

                balance -= amount;
            }

            public decimal GetBalance() //for fetching the balance and return will be decimal type
            {
                return balance;
            }


        }
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }


}
