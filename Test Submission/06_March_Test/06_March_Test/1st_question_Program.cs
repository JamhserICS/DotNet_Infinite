using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_March_Test
{

    public abstract class Student    // this is abstract class
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public abstract bool isPassed(double grade); // abstract boolean method
    }

    public class Undergraduate : Student //inheriting the Student class by Undergraduate class
    {
        public override bool isPassed(double grade) // overriding the abstract isPassed method
        {
            return grade > 70.0;
        }
    }

    public class Graduate : Student // inheriting the Student class by Graduate class
    {
        public override bool isPassed(double grade) // overriding the abstract isPassed method
        {
            return grade > 80.0;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Undergraduate undergraduate = new Undergraduate { Name = "James", StudentId = 1, Grade = 75.0 }; //creating object with value
            Console.Write("Enter the grade value for Undergraduate: ");
            double grd1 = Convert.ToDouble(Console.ReadLine()); // taking value from the user
            Console.WriteLine($"Undergraduate output: {undergraduate.isPassed(grd1)}");

            Graduate graduate = new Graduate { Name = "John", StudentId = 2, Grade = 85.0 }; //creating object with value
            Console.Write("Enter the grade value for Graduate: ");
            double grd2 = Convert.ToDouble(Console.ReadLine()); // taking value from the user
            Console.WriteLine($"Graduate output: {graduate.isPassed(grd2)}");



           List<_2nd_question_program> products = new List<_2nd_question_program>

           {
            new _2nd_question_program(1, "Product 1", 10.5),
            new _2nd_question_program(2, "Product 2", 15.99),
            new _2nd_question_program(3, "Product 3", 5.49),
            new _2nd_question_program(4, "Product 4", 20.0),
            new _2nd_question_program(5, "Product 5", 12.99),
            new _2nd_question_program(6, "Product 6", 8.99),
            new _2nd_question_program(7, "Product 7", 18.5),
            new _2nd_question_program(8, "Product 8", 14.99),
            new _2nd_question_program(9, "Product 9", 6.99),
            new _2nd_question_program(10, "Product 10", 25.0)
            };

                var sortedProducts = products.OrderBy(p => p.Price).ToList();

                Console.WriteLine("Sorted Products by price:");
                foreach (var product in sortedProducts)
                {
                    Console.WriteLine($"Sorted Price: {product.Price}, {product.ProductName}");
                }

            Console.Read();
        }
    }
}
