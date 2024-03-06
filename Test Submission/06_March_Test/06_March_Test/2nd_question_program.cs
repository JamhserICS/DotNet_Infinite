using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_March_Test
{

    public class _2nd_question_program
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public _2nd_question_program(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }
    }
}
