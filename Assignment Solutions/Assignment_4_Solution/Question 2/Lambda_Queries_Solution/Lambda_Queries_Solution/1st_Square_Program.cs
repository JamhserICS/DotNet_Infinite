using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Write a query that returns list of numbers and their suares only if the square is greater than 20
Example input {7,2,30}
Expected Output : 49,900
 */

namespace Lambda_Queries_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 7,2,30 }; //creating list type int with numbers

            var query = from number in numbers
                        let square = number * number
                        where square > 20
                        select new { Number = number, Square = square };

            foreach (var result in query) ////foreach loop to iterate result in query
            {
                Console.WriteLine("Number: {0}, Square: {1}", result.Number, result.Square);
            }

            Console.Read();
        }
    }
}
