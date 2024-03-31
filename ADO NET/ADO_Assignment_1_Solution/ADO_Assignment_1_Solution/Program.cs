using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Assignment_1_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Populating the data into Employee using generic list

            List<Employee> empList = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
        };

            // 1. Display a list of all the employees who have joined before 1/1/2015
            var before15 = empList.Where(emp => emp.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("Employees who have joined before 1/1/2015:");
            foreach (var emp in before15)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            // 2. Display a list of all the employees whose date of birth is after 1/1/1990
            var after90 = empList.Where(emp => emp.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("\nEmployees DOB is after 1/1/1990:");
            foreach (var emp in after90)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            // 3. Display a list of all the employees whose designation is Consultant and Associate
            var consAndAss = empList.Where(emp => emp.Title == "Consultant" || emp.Title == "Associate");
            Console.WriteLine("\nEmployees whose designation is Consultant and Associate:");
            foreach (var e in consAndAss)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName);
            }

            // 4. Display total number of employees
            Console.WriteLine("\nNumber of employees: " + empList.Count);

            // 5. Display total number of employees belonging to “Chennai”
            var chennCount = empList.Count(emp => emp.City.Equals("Chennai"));
            Console.WriteLine("\nTotal number of employees belonging to Chennai: " + chennCount);

            // 6. Display highest employee id from the list
            int maxEmpID = empList.Max(emp => emp.EmployeeID);
            Console.WriteLine("\nHighest employee ID: " + maxEmpID);

            // 7. Display total number of employees who have joined after 1/1/2015
            var after15 = empList.Count(emp => emp.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine("\nTotal number of employees who have joined after 1/1/2015: " + after15);

            // 8. Display total number of employees whose designation is not “Associate”
            var notAss = empList.Count(emp => emp.Title != "Associate");           
            Console.WriteLine("\nTotal number of employees whose designation is not Associate: " + notAss);
            var notAssEmp = empList.Where(x => x.Title != "Associate");
            foreach (var v in notAssEmp)
                Console.WriteLine(v.FirstName + " " + v.LastName + " ->" + v.Title);

            // 9. Display total number of employees based on City
            var boc = empList.GroupBy(emp => emp.City);
            Console.WriteLine("\nTotal number of employees based on City:");
            foreach (var group in boc)
            {
                Console.WriteLine(group.Key + ": " + group.Count());
            }

            // 10. Display total number of employees based on city and title
            var cat = empList.GroupBy(x => new { x.City, x.Title });
            Console.WriteLine("\nTotal number of employees based on City and Title:");
            foreach (var group in cat)
            {
                Console.WriteLine(group.Key.City + " - " + group.Key.Title + ": " + group.Count());
            }

            // group.Key.City->   retrieving the city name for the group.
            // group.Key.Title->  retrieving the job title for the group.



            // 11. Display total number of employees who is youngest in the list

            var yDOB = empList.Max(emp => emp.DOB);
            var yEmp = empList.Where(x => x.DOB.Equals(yDOB));
            Console.WriteLine();
            Console.Write("Youngest employee: ");
            foreach (var v in yEmp)
                Console.WriteLine(v.FirstName + " " + v.LastName);

            Console.Read();
        }
    }
}
