use Assignment

select * from EMP
select * from dept


--1. Retrieve a list of MANAGERS. 
select ename as 'Manager Name List', salary from emp where job='manager'


--2. Find out the names and salaries of all employees earning more than 1000 per month.
select ename, salary from emp where Salary>1000


--3. Display the names and salaries of all employees except JAMES. 
select ename, salary from emp where ename!='james'


--4. Find out the details of employees whose names begin with ‘S’. 
select *from emp where ename like 's%'


--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename from emp where ename like '%a%'


--6. Find out the names of all employees that have ‘L’ as their third character in their name.
select ename from emp where ename like '__l%'


--7. Compute daily salary of JONES. 
select salary/30 as DailySalary from emp where ename='jones'


--8. Calculate the total monthly salary of all employees. 
select sum(salary) as Total_Monthly_Salary from emp


--9. Print the average annual salary . 
select avg(salary*12) as Average_Annual_Salary from emp


--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
--select *from emp
select ename, job, salary, deptno from emp where job!='SALESMAN' and deptno!=30


--11. List unique departments of the EMP table. 
select distinct deptno from emp


--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as Employees, salary as 'Monthly Salary' from emp where salary>1500 and deptno in (10,20)


--13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename, job, salary from emp where job in ('manager', 'analyst') and salary not in (1000,3000,5000)


--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
select ename,salary, comm as commision from emp where comm>(salary*1.1)


--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
select ename from emp where (ename like '%l%l%' and deptno=30) or mgrid=7780


--16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees. 
select ename, count(*) as 'Total Employees' from emp where DATEDIFF(year, hiredate, GETDATE()) between 30 and 40 group by ename


--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select d.deptno, e.ename from departments d left join employees e on d.deptno = e.deptno order by d.deptno asc, e.ename desc;


--18. Find out experience of MILLER. 
select datediff(year, hiredate, getdate()) as experience from emp where ename = 'MILLER';
