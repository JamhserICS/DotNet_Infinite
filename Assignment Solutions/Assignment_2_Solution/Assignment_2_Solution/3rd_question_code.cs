using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 3. Create a class called Saledetails which has data members like Salesno,  Productno,  Price, dateofsale, Qty, TotalAmount
Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty *Price
Pass the other information like SalesNo, Productno, Price,Qty and Dateof sale through constructor
call the show data method to display the values.
Hint : Use This pointer 
 */

namespace Assignment_2_Solution
{
    class Q3SaleDetails //Defining Q3SaleDetails class
    {
        //declaring private data members
        private int salesNo;
        private int productNo;
        private double price;
        private DateTime dateOfSale;
        private int qty;
        private double totalAmount;

        public Q3SaleDetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale) //constructor that takes five parameters
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.qty = qty;
            this.dateOfSale = dateOfSale;
            this.TotalAmount = qty * price;
        }

        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        public void sales(double price1, int qty1)
        {
            price += price1;
            qty += qty1;
            TotalAmount = qty * price;
        }

        public void ShowData() //method to display the data
        {
            Console.WriteLine("Sales No: " + this.salesNo);
            Console.WriteLine("Product No: " + this.productNo);
            Console.WriteLine("Price: " + this.price);
            Console.WriteLine("Quantity: " + this.qty);
            Console.WriteLine("Date of Sale: " + this.dateOfSale.ToString("dd/MM/yyyy"));
            Console.WriteLine("Total Amount: " + this.totalAmount);
        }

        static void Main()
        {
            Q3SaleDetails sale1 = new Q3SaleDetails(1, 101, 50, 2, DateTime.Today); //creating object
            sale1.ShowData();
            Console.WriteLine();
            sale1.sales(50, 2);
            sale1.ShowData();



            Console.Read();
        }
    }
}
