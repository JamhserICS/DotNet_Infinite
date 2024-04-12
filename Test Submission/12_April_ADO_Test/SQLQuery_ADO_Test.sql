create database employeemanagement


use employeemanagement

create table employee_details (
    empno int primary key,
    empname varchar(50) not null,
    empsal numeric(10,2) check (empsal >= 25000),
    emptype char(1) check (emptype in ('P', 'C'))
)

select * from employee_details

--writing store procedure code
create proc Add_Emp_Data
    @empname varchar(50),
    @empsal numeric(10,2),
    @emptype char(1)
as
begin
    declare @empno int
    
    select @empno = isnull(max(empno), 0) + 1 from employee_details
    
    -- Insert into table
    insert into employee_details (empno, empname, empsal, emptype)
    values (@empno, @empname, @empsal, @emptype)
end



select * from sys.procedures

