create database testDB
use testdb

create table book (
    id int primary key,
    title varchar(40),
    author varchar(40),
    isbn varchar(40) unique,
    published_date datetime
)
insert into book values 
(1, 'My First SQL book', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
(2, 'My Second SQL book', 'John Mayer', '857300923713', '1972-07-03 09:22:45'),
(3, 'My Third SQL book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44')

select *from book

--1. fetch book details author name ending with er
select *from book where author like '%er'







create table reviews (
    id int primary key,
    book_id int,
    reviewer_name varchar(40),
    content varchar(40),
    rating int,
    published_date datetime
	foreign key (book_id) references book(id)
)

insert into reviews values 
(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10')
select *from reviews

--2. Display the title, author and reviewerName for all the books from the above table
select b.title, b.author, r.reviewer_name from book b join reviews r on b.id = r.book_id;


--3. display the revierwer name who review more than one book
select reviewer_name from reviews group by reviewer_name having count(distinct book_id) > 1;








create table customer (
    id int primary key,
    name varchar(40),
    age int,
    address varchar(40),
    salary numeric(15)
)

insert into customer values
(1, 'ramesh', 32, 'ahmedabad', 2000),
(2, 'khilan', 25, 'delhi', 1500),
(3, 'kaushik', 23, 'kota', 2000),
(4, 'chaitali', 25, 'mumbai', 6500),
(5, 'hardik', 27, 'bhopal', 8500),
(6, 'komal', 22, 'mp', 4500),
(7, 'muffy', 24, 'indore', 10000)

--4. Display the Name for the customer from above customer table who live in same address which has character o anywhere in address
select name as 'Customer name', address as 'Address contains o letter' from customer where address like '%o%'









create table orders (
    oid int primary key,
    date datetime,
    customer_id int,
    amount numeric(15),
    foreign key (customer_id) references customer(id)
)

insert into orders (oid, date, customer_id, amount) values
(102, '2009-10-08 00:00:00', 3, 3000),
(100, '2009-10-08 00:00:00', 3, 1500),
(101, '2009-11-20 00:00:00', 2, 1560),
(103, '2008-05-20 00:00:00', 4, 2060)

select *from orders

--5. Write a query to display the date, total no of cutomer placed order on same date.
select date, count(distinct customer_id) as total_customers from orders group by date;











create table employee (
    id int primary key,
    name varchar(40),
    age int,
    address varchar(40),
    salary numeric(15)
)

insert into employee values
(1, 'ramesh', 32, 'ahmedabad', 2000),
(2, 'khilan', 25, 'delhi', 1500),
(3, 'kaushik', 23, 'kota', 2000),
(4, 'chaitali', 25, 'mumbai', 6500),
(5, 'hardik', 27, 'bhopal', 8500),
(6, 'komal', 22, 'mp', null),
(7, 'muffy', 24, 'indore', null)

select * from employee

--6. Display the names of the employee in lower case, whose salary is null
select lower(name) as lowercase_name from employee where salary is null;









create table studentdetails (
    registerno int primary key,
    name varchar(255),
    age int,
    qualification varchar(40),
    mobileno varchar(15),
    mail_id varchar(40),
    location varchar(40),
    gender char(1)
)

insert into studentdetails (registerno, name, age, qualification, mobileno, mail_id, location, gender) values
(2, 'Sai', 22, 'B.E', '9952836777', 'Sai@gmail.com', 'Chennai', 'M'),
(3, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madura', 'M'),
(4, 'Selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
(5, 'Nisha', 25, 'ME', '7834672310', 'Nisha@gmail.com', 'Then', 'F'),
(6, 'SaiSaran', 21, 'B.A', '7890345678', 'saran@gmail.com', 'Madura', 'F'),
(7, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune', 'M')

drop table studentdetails

select * from studentdetails

--﻿7. Write a sql server query to display the Gender, Total no of male and female from the above relation
select gender,
       count(case when gender = 'm' then 1 end) as total_male,
       count(case when gender = 'f' then 1 end) as total_female
from studentdetails
group by gender
