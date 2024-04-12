using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _12_April_ADO_Test
{


    //Business layer
    class Employee
    {
        public string empName { get; set; }
        public decimal empSalary { get; set; }
        public char empType { get; set; }
        

        public void AddNewEmpData()
        {
            Console.Write("Enter employee name :");
            empName = Console.ReadLine();
            Console.Write("Enter employee salary :");
            empSalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter employee type(P/C) :");
            empType = Convert.ToChar(Console.ReadLine());
            DataAccess.AddNewEmpData(empName, empSalary,empType);
        }

        public void ShowAllEmp()
        {
            DataAccess.DisplayAllEmployees();
        }

    }


//-------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------


        //Data layer to handle all database activities

        class DataAccess
        {
            public static SqlConnection con;
            public static SqlDataAdapter da;

            public static SqlConnection getConnection()
            {
                con = new SqlConnection("server=ICS-LT-2K476D3\\SQLEXPRESS; database=Employeemanagement; integrated security=true");
                con.Open();
                return con;
            }

            public static void AddNewEmpData(string emp_name, decimal emp_sal, char emp_type)
            {
                con = getConnection();

                try
                {
                    SqlCommand cmd = new SqlCommand("Add_Emp_Data", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding the parameters
                    cmd.Parameters.AddWithValue("@empName", emp_name);
                    cmd.Parameters.AddWithValue("@empsal", emp_sal);
                    cmd.Parameters.AddWithValue("@emptype", emp_type);

                    // Executing the command
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            public static void DisplayAllEmployees()
            {
                con = getConnection();

                try
                {
                    da = new SqlDataAdapter("SELECT * FROM Employee_Details", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Employee_Details");
                    DataTable dt = ds.Tables["Employee_Details"];

                    // Display employee details
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            Console.Write(row[col]);
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }


    //-------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------


    //CLient
    class Program
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee();

            // Calling the method to add a new employee using the stored procedure
            emp.AddNewEmpData();

            // Display all employee rows
            emp.ShowAllEmp();

            Console.Read();
        }
    }
}
