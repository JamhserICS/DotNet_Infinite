/*1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

   a) HRA as 10% of Salary
   b) DA as 20% of Salary
   c) PF as 8% of Salary
   d) IT as 5% of Salary
   e) Deductions as sum of PF and IT
   f) Gross Salary as sum of Salary,HRA,DA
   g) Net Salary as Gross Salary - Deductions*/

--select *from Employees


-----creating or altering a stored procedure named gen_slip which take a parameter (@emp_no)-----
create or alter procedure gen_slip 
    @emp_no int
as
begin
    -----Declaring Variables float type becuase value can be in decimal------
    declare @sal float;
	declare @ename varchar(10)
    declare @hra float;
    declare @da float
    declare @pf float
    declare @it float
    declare @deductions float
    declare @gross_sal float
    declare @net_sal float

    -- fetching the salary and name of the employees table with help of @emp_no
    select @sal = salary, @ename=ename from employees where empno = @emp_no

    -- Calculating HRA, DA, PF, IT
    set @hra = @sal * 0.10
    set @da = @sal * 0.20
    set @pf = @sal * 0.08
    set @it = @sal * 0.05

    -----Calculating Deductions
    set @deductions = @pf + @it

    -----Calculating Gross Salary
    set @gross_sal = @sal + @hra + @da

    -----Calculating Net Salary
    set @net_sal = @gross_sal - @deductions

    -----Print all the calculated details
    print 'Payslip for Employee no: ' + cast(@emp_no as varchar(10))+ ', Name: '+@ename
    print '---------------------------------'
    print @ename+' ' + 'Salary: ' + cast(@sal as varchar(20))
    print @ename+' ' + 'HRA: ' + cast(@hra as varchar(20))
    print @ename+' ' + 'DA: ' + cast(@da as varchar(20))
    print @ename+' ' + 'PF: ' + cast(@pf as varchar(20))
    print @ename+' ' + 'IT: ' + cast(@it as varchar(20))
    print '---------------------------------'
    print @ename+' ' + 'Deductions: ' + cast(@deductions as varchar(20))
    print @ename+' ' + 'Gross Salary: ' + cast(@gross_sal as varchar(20))
    print @ename+' ' + 'Net Salary: ' + cast(@net_sal as varchar(20))
    print '---------------------------------'
end

select*from Employees
exec gen_slip 7001 -----Executing the Stored Procedure: gen_slip



------Below is the Ouput of above the Query--------

/*Payslip for Employee no: 7001, Name: Ramesh
---------------------------------
Ramesh Salary: 34234
Ramesh HRA: 3423.4
Ramesh DA: 6846.8
Ramesh PF: 2738.72
Ramesh IT: 1711.7
---------------------------------
Ramesh Deductions: 4450.42
Ramesh Gross Salary: 44504.2
Ramesh Net Salary: 40053.8
---------------------------------

Completion time: 2024-03-27T20:57:07.8019786+05:30*/