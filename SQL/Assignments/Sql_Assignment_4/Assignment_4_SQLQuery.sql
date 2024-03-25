use Assignment

--1. Write a T-SQL Program to find the factorial of a given number.

create or alter proc cal_factorial(@number int) --cal_factorial which takes a number as parameter
as
begin
    declare @fact int = 1, @temp int = 1 --declaring the variable with value
    
    while @number>=@temp
    begin
        set @fact = @fact * @temp
        set @temp = @temp + 1
    end

    print 'factorial of ' + cast(@number as varchar(10)) + ' is: ' + cast(@fact as varchar(50)); --for printing the result
end

exec cal_factorial 4 --executing the calfactorial





--2. Create a stored procedure to generate multiplication tables up to a given number.
create or alter procedure gen_Mul_Tables (@num int) --creating gen_Mul_Tables 
as
begin
    declare @temp int = 1;
    declare @temp2 int;

    while @temp <= @num
    begin
        print 'multiplication table ' + cast(@temp as varchar(10)) + ':'
        set @temp2 = 1;
        while @temp2 <= 10
        begin
		    ----give ouput in this format: 1 x 1 = 1
            print cast(@temp as varchar(10)) + ' x ' + cast(@temp2 as varchar(10)) + ' = ' + cast(@temp * @temp2 as varchar(10)) 

            set @temp2 = @temp2 + 1;
        end
        print '' -- adding a line break between tables
        set @temp = @temp + 1;
    end
end;

exec gen_Mul_Tables 5;




--3.  Create a trigger to restrict data manipulation on EMP(in my database this is employees) table during General holidays. 
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 
-- create the holiday table
create table holiday (
    hol_date date primary key,
    hol_name varchar(50)
);


-- insert some holiday details
insert into holiday (hol_date, hol_name)
values 
--adding holiday details: date and name
    ('2024-08-15', 'Independence Day'),
    ('2024-10-27', 'Diwali'),
    ('2024-01-01', 'New Year'),
    ('2024-05-01', 'Labour Day'),
	('2024-03-25', 'Holi')

	--drop table holiday

-- Creating or altering the trigger for restriction
create or alter trigger restrict_trig
on employees
after insert, update, delete --trigger will happen after an insert, update, or delete operation on the employees table.
as
begin
    declare @hol_count int; --declaring the holiday cout type integer

    -- Check if the current date is a holiday
    select @hol_count = count(*)
    from holiday
    where hol_date = convert(date, getdate());

    if @hol_count > 0
    begin
        -- Rollback the transaction
        rollback; --Rollbac the current transaction, undoing any changes made by the insert, update, or delete operation.
        
        -- Display the error message
        declare @hol_name varchar(50);
        select @hol_name = hol_name
        from holiday
        where hol_date = convert(date, getdate());

        -- Print the error message
        print 'Due to ' + @hol_name + ', you cannot manipulate data.';
    end
end --ending trigger body


--select*from holiday;
--select*from employees;


-- Insert some test data into the employees table
--today is 25-03-24 so inset, update and delete will give error message:- "Due to Holi, you cannot manipulate data."
insert into employees (empno, ename, salary) values (1013, 'John', 50000);

update Employees set Salary=10000 where empno=7001 --today is 25-03-24 so this will give error message:- "Due to Holi, you cannot manipulate data."

delete from Employees where empno=101

insert into employees (empno, ename, salary) values (1013, 'John', 50000); --when i execute this query on 26 march then it will executed

--select*from employees;




