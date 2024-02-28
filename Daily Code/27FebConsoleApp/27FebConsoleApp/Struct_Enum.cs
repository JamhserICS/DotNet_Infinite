using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27FebConsoleApp
{
    class Struct_Enum
    {
        enum cities
        {
            Agra, Bangalore, Chennai, Delhi, Hyderabad, Kolkata, Mumbai, Vizag
        }

        struct Customer
        {
            public int custrating;
        }
        class StructEnumerations
        {
            enum colors { Red, Blue, Green, Yellow, Orange, White };
            public static void TestStructnClass()
            {
                Customer cust1 = new Customer();
                cust1.custrating = 10;

                Customer cust2 = new Customer();
                cust2 = cust1;
                Console.WriteLine("Customer 1 rating:" + cust1.custrating + " " + "Customer 2 rating:" + cust2.custrating);
                cust2.custrating = 2;
                Console.WriteLine("After Changes");
                Console.WriteLine("Customer 1 rating:" + cust1.custrating + " " + "Customer 2 rating:" + cust2.custrating);


            }
            public static void enumOperations()
            {
                foreach (int x in Enum.GetValues(typeof(cities)))
                {
                    if (x == 1)
                    {
                        Console.WriteLine(Enum.GetName(typeof(cities), x) + " Is a garden city");
                    }
                    else if (x == 2)
                    {
                        Console.WriteLine(Enum.GetName(typeof(cities), x) + " Is a Temple city");
                    }
                    else if (x == 6)
                    {
                        Console.WriteLine(Enum.GetName(typeof(cities), x) + " Is a Financial city");
                    }
                    else
                    {
                        Console.WriteLine(Enum.GetName(typeof(cities), x));
                    }
                }

                Console.WriteLine("-----------");
                foreach (string s in Enum.GetNames(typeof(cities)))
                {
                    Console.WriteLine(s);
                }

            }
        }


        

    }
}
