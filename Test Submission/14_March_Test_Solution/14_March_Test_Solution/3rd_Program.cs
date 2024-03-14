using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 3. Create a Generic List Collection empList and populate it with the following records.
 
EmployeeID 	FirstName	 LastName 	Title 		         DOB 		DOJ 			City
1001	        Malcolm         Daruwalla 	Manager 		16/11/1984 	8/6/2011 		Mumbai
1002 		Asdin	        Dhalla 		AsstManager 	        20/08/1984 	7/7/2012 		Mumbai
1003 		Madhavi         Oza 		Consultant 	        14/11/1987 	12/4/2015 	        Pune
1004 		Saba 		Shaikh		SE 			3/6/1990	2/2/2016	 	Pune
1005 		Nazia 		Shaikh 		SE 			8/3/1991 	2/2/2016	 	Mumbai
1006 		Amit 		Pathak 		Consultant 	        7/11/1989 	8/8/2014 		Chennai
1007 		Vijay 		Natrajan	Consultant 	        2/12/1989	1/6/2015 		Mumbai
1008 		Rahul 		Dubey 		Associate	 	11/11/1993 	6/11/2014	 	Chennai
1009 		Suresh 		Mistry		Associate 	        12/8/1992 	3/12/2014        	Chennai
1010 		Sumit 		Shah 		Manager 		12/4/1991 	2/1/2016 		Pune
 
Now once the collection is created write down and execute the LINQ queries for collection 
as follows :
 
a. Display detail of all the employee
b. Display details of all the employee whose location is not Mumbai
c. Display details of all the employee whose title is AsstManager
d. Display details of all the employee whose Last Name start with S
 
 
 */

namespace _14_March_Test_Solution
{
    class Employee
    {
        //creating the properties to get and set the value
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program3
    {
        static void Main()
        {
            // Creating a generic list collection called empList and storing values which is mentioned in question
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
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 3, 12), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 2, 1), City = "Pune" }
            };

            // Below are the LINQ queries

            // Code for displaying the all employee details
            Console.WriteLine("Details of all employees:");
            foreach (var emp in empList)
            {
                Console.WriteLine($"-> {emp.EmployeeID}, {emp.FirstName} {emp.LastName}, {emp.Title}, {emp.DOB.ToShortDateString()}, {emp.DOJ.ToShortDateString()}, {emp.City}");
            }
            Console.WriteLine();

            // Code for displaying those employee whose location is not Mumbai
            Console.WriteLine("Details of employees not in Mumbai:");
            var employeesNotInMumbai = empList.Where(emp => emp.City != "Mumbai");
            foreach (var emp in employeesNotInMumbai)
            {
                Console.WriteLine($"->{emp.EmployeeID}, {emp.FirstName} {emp.LastName}, {emp.Title}, {emp.DOB.ToShortDateString()}, {emp.DOJ.ToShortDateString()}, {emp.City}");
            }
            Console.WriteLine();

            // Code for displaying those employee whose title is AsstManager
            Console.WriteLine("Details of employees with title AsstManager:");
            var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"->{emp.EmployeeID}, {emp.FirstName} {emp.LastName}, {emp.Title}, {emp.DOB.ToShortDateString()}, {emp.DOJ.ToShortDateString()}, {emp.City}");
            }
            Console.WriteLine();

            // Code for displaying those employee whose Last Name starts with S
            Console.WriteLine("Details of employees whose Last Name starts with S:");
            var lastNameStartsWithS = empList.Where(emp => emp.LastName.StartsWith("S"));
            foreach (var emp in lastNameStartsWithS)
            {
                Console.WriteLine($"->{emp.EmployeeID}, {emp.FirstName} {emp.LastName}, {emp.Title}, {emp.DOB.ToShortDateString()}, {emp.DOJ.ToShortDateString()}, {emp.City}");
            }

            Console.Read();
        }
    }
}
