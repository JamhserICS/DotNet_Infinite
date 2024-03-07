using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. Create a Class called Doctor with RegnNo, Name, Feescharged as Private members. Create methods to give values and also to display the same.

namespace Assignment_3_Solution
{
    class Doctor //doctor class
    {
            private int regnNo;
            private string name;
            private decimal feesCharged;

            public int RegnNo //for setting and getting the registration number
        {
                get { return regnNo; }
                set { regnNo = value; }
            }

            public string Name //for setting and getting the name
            {
                get { return name; }
                set { name = value; }
            }

            public decimal FeesCharged //for setting and getting the fees
        {
                get { return feesCharged; }
                set { feesCharged = value; }
            }

            public void GetDetails() // method for getting the reg, name, fees
            {
                Console.WriteLine("Registration Number: " + regnNo);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Fees Charged: " + feesCharged);
            }

            public void SetDetails(int regnNo, string name, decimal feesCharged) //method for setting the reg, name, fees
        {
                this.regnNo = regnNo;
                this.name = name;
                this.feesCharged = feesCharged;
            }           
        }
}
