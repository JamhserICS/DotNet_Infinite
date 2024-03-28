select *from emp
select *from employees



-----creating table for birthdays
create table birthdays (
    id int primary key,
    name varchar(100),
    birthdaydate date
)

----inserting values
insert into birthdays values 
(1, 'Jamsher Shekh', '2002-07-07'),
(2, 'Rajesh Gupta', '2002-05-05')


-----1.	Write a query to display your birthday( day of week)
select datename(dw, birthdaydate) as 'My Birthday Week' from birthdays where birthdaydate = '07-07-2002'

                                           ----Output-----

								    ------My Birthday week-----           
								    ------Sunday-------    







-----2.	Write a query to display your age in days
select name, datediff(day, birthdaydate, getdate()) as "Age in Days" from birthdays where name='jamsher shekh'

                                         ----Output-----

								------name                 Age in Days
								------Jamsher Shekh	       7935------







------3. Write a query to display all employees information those who joined before 5 years in the current month
------(Hint : If required update some HireDates in your EMP table of the assignment)
select*from emp

select * from emp where hiredate <= dateadd(year, -5, dateadd(month, datediff(month, 0, getdate()), 0))

----in emp table all employees hiredate is before 1990 so for testing the code i am updating some hiredate value with near current date
update emp set hiredate = '2022-12-16' where empno = 7369
update emp set hiredate = '2023-12-16' where empno = 7698

                       ---prev data----
/*7369	SMITH	CLERK	7902	2022-12-16	968	NULL	20
7499	ALLEN	SALESMAN	7698	1981-02-20	1600	300	30
7521	WARD	SALESMAN	7698	1981-02-22	1250	500	30
7566	JONES	MANAGER	7839	1981-04-02	3600	NULL	20
7654	MARTIN	SALESMAN	7698	1981-09-28	1250	1400	30
7698	BLAKE	MANAGER	7839	2023-12-16	2850	NULL	30
7782	CLARK	MANAGER	7839	1981-06-09	2450	NULL	10
7788	SCOTT	ANALYST	7566	1987-04-19	3630	NULL	20
7839	KING	PRESIDENT	NULL	1981-11-17	5000	NULL	10
7844	TURNER	SALESMAN	7698	1981-09-08	1500	0	30
7876	ADAMS	CLERK	7788	1987-05-23	1331	NULL	20
7900	JAMES	CLERK	7698	1981-12-03	950	NULL	30
7902	FORD	ANALYST	7566	1981-12-03	3630	NULL	20
7934	MILLER	CLERK	7782	1982-01-23	1300	NULL	10*/


                 -----After Executing the query--------
/*7499	ALLEN	SALESMAN	7698	1981-02-20	1600	300	30
7521	WARD	SALESMAN	7698	1981-02-22	1250	500	30
7566	JONES	MANAGER	7839	1981-04-02	3600	NULL	20
7654	MARTIN	SALESMAN	7698	1981-09-28	1250	1400	30
7782	CLARK	MANAGER	7839	1981-06-09	2450	NULL	10
7788	SCOTT	ANALYST	7566	1987-04-19	3630	NULL	20
7839	KING	PRESIDENT	NULL	1981-11-17	5000	NULL	10
7844	TURNER	SALESMAN	7698	1981-09-08	1500	0	30
7876	ADAMS	CLERK	7788	1987-05-23	1331	NULL	20
7900	JAMES	CLERK	7698	1981-12-03	950	NULL	30
7902	FORD	ANALYST	7566	1981-12-03	3630	NULL	20
7934	MILLER	CLERK	7782	1982-01-23	1300	NULL	10*/







/*4.	Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
	a. First insert 3 rows 
	b. Update the second row sal with 15% increment  
        c. Delete first row.
After completing above all actions how to recall the deleted row without losing increment of second row.*/

drop table employee

create table employee (
    empno int primary key,
    ename varchar(10),
    sal float,
    doj date
)

insert into employee values 
(1, 'ramesh', 400, '2023-01-01'),
(2, 'mahesh', 761, '2024-02-25'),
(3, 'mohan', 600, '2021-03-21')

begin transaction

select * from employee

delete from employee where empno = 1 --deleting row with empno

select * from employee
rollback transaction --calling rollback to undo changes
select * from employee

update employee set sal = 1.15 * sal where empno = 2

select * from employee

---before rollback---
/*

1	John	400	    2023-01-01
2	Jane	761  	2024-02-25
3	Bob  	600 	2021-03-21


----After Rollback and 15 increment

1	John	5000	2022-01-01
2	Jane	7604	2022-01-02
3	Bob 	5000	2022-01-03

*/















/*Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
	a.     For Deptno 10 employees 15% of sal as bonus.
	b.     For Deptno 20 employees  20% of sal as bonus
	c      For Others employees 5%of sal as bonus*/
	

-- Create the function
create or alter function calc_bon(@deptno int, @salary float) 
returns float
as
begin
    declare @bonus float
    
    if @deptno = 10
        set @bonus = @salary * 0.15 -- 15% bonus for deptno 10
    else if @deptno = 20
        set @bonus = @salary * 0.20 -- 20% bonus for deptno 20
    else
        set @bonus = @salary * 0.05 -- 5% bonus for others
    
    return @bonus
end

--select*from Employees


select empno, ename, job, salary, deptno, dbo.calc_bon(deptno, salary) as bonus from employees

                                     
									 ---------Output------------

---Prev table data---
/*
empno   ename   job       salary  deptno
7001	Ramesh	Analyst  	34234	10
7002	Rajesh	Designer	30000	10
7003	Madhav	Developer	40000	20
7004	Manoj	Developer	40000	20
7005	Abhay	Designer	35000	10
7006	Uma	    Tester   	30000	30
7007	Gita	Tech.   	30000	40
7008	Priya	Tester	    35000	30
7009	Nutan	Developer	45000	20
7010	Smita	Analyst 	20000	10
7011	Anand	Project Mgr	65000	10
*/


-----after function query------
/*
empno   ename   job       salary  deptno bonus
7001	Ramesh	Analyst	   34234	10	5135.1
7002	Rajesh	Designer	30000	10	4500
7003	Madhav	Developer	40000	20	8000
7004	Manoj	Developer	40000	20	8000
7005	Abhay	Designer	35000	10	5250
7006	Uma	    Tester	   30000	30	1500
7007	Gita	Tech.    	30000	40	1500
7008	Priya	Tester  	35000	30	1750
7009	Nutan	Developer	45000	20	9000
7010	Smita	Analyst	   20000	10	3000
7011	Anand	Project    65000	10	9750*/

 


