using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. Create a class called Accounts which has data members/fields like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
D->Deposit
W->Withdrawal
-write a function that updates the balance depending upon the transaction type
	-If transaction type is deposit call the function credit by passing the amount to be deposited and update the balance
  Credit(int amount) function 
	-If transaction type is withdraw call call the function debit by passing the amount to be withdrawn and update the balance
  Debit(int amt) function 
-Pass the other information like Acount no, customer name,acc type through constructor
-call the show data method to display the values.
 */


namespace Assignment_2_Solution
{
    class Q1Account //declaring class
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private double balance;

        public Q1Account(int accountNo, string customerName, string accountType) //constructor
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.balance = 0;
        }

        public void Credit()
        {
            Console.Write("Enter amount for credit: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            this.balance += amount;
        }

        public bool Debit()
        {
            Console.Write("Enter amount for withdrawl: ");
            int amt = Convert.ToInt32(Console.ReadLine());
            if (this.balance >= amt)
            {
                this.balance -= amt;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
                return false;
            }
        }

        public void ShowData() //method to show all data
        {
            Console.WriteLine("Account No: " + this.accountNo);
            Console.WriteLine("Customer Name: " + this.customerName);
            Console.WriteLine("Account Type: " + this.accountType);
            Console.WriteLine("Balance: " + this.balance);
        }

        static void Main()
        {     
            Q1Account myAccount = new Q1Account(12345, "John Doe", "Savings"); //creating object with the help of class
            Console.WriteLine("Created account information:");
            myAccount.ShowData();
            Console.WriteLine();
            myAccount.Credit();
            myAccount.ShowData();
            Console.WriteLine();
            myAccount.Debit();
            myAccount.ShowData();
            Console.Read();
        }
    }

}
