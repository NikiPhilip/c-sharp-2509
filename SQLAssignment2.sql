
CREATE database salesdb
use salesdb
create table Sales(
	Saleid int PRIMARY KEY IDENTITY(1,1),
	ProductID int,
	ProductName varchar(255),
	QuantitySold int,
	SaleAmount int,
	SaleDate date)

Insert into Sales values(101,'Laptop',5,5000,'2024-09-01'),
						(102,'Mouse',10,250,'2024-09-02'),
						(101,'Laptop',3,3000,'2024-09-03'),
						(103,'Keyboard',8,800,'2024-09-04'),
						(102,'Mouse',6,150,'2024-09-05')
select * from sales
--1.Write a query to calculate the total sales amount for all products (SUM).
select sum(SaleAmount) as TotalSalesAmount from sales

--2.Write a query to find the maximum quantity sold of any product (MAX).
select max(QuantitySold) as MaxQuantitySold from Sales

--3.Write a query to calculate the average sale amount per sale (AVG). 
select AVG(SaleAmount) as AvgSaleAmount from sales

--4. Write a query to find the minimum sale amount in the database (MIN). 
select MIN(SaleAmount) as MinSaleAmount from sales

--5.Write a query to calculate the total quantity sold of a specific product, say "Laptop" 
--(SUM with WHERE clause). 

select sum(QuantitySold) as TotalQuantityofLaptops from sales WHERE ProductName='Laptop' 

--Assignment 2 You are given an Employees table with salary details. The table structure is as follows: 

Create table Employees(
			EmployeeID int PRIMARY KEY IDENTITY(1,1),
			EmployeeName varchar(255),
			Department varchar(30),
			Salary int,
			HireDate date)

Insert into Employees values('John Doe','IT',5000,'2022-01-10'),
							('Jane Smith','HR',6000,'2021-03-15'),
							('Bob Johnson','Finance',5500,'2020-06-20'),
							('Alice Brown','IT',6200,'2023-02-01'),
							('Charlie White','Marketing',4800,'2023-03-10')
select * from employees
drop table employees

--1. Write a query to find the total salary expenditure for all employees (SUM).
select sum(salary) as TotalSalary from Employees

--2.Write a query to find the highest salary among all employees (MAX). 
select max(salary) as MaxSalary from Employees

--3.Write a query to calculate the average salary across all employees (AVG). 
select avg(salary) as AvgSalary from Employees

--4. Write a query to find the minimum salary in the IT department (MIN with WHERE 
--clause). 
select MIN(salary) as MinSalary from Employees where Department='IT'

--5. Write a query to find the total number of employees in each department (COUNT and 
--GROUP BY). 
select Department,count(Employeeid) as Total_Employees from Employees GROUP BY Department

--Assignment 3: Inventory Management
--You are given an Inventory table with information about the stock levels of different products. 
--The table structure is as follows:

create table Inventory(ProductID int PRIMARY KEY identity(201,1),
					  ProductName varchar(50),
					  QuantityInStock int,
					  ReorderLevel int,
					  LastRestockDate date)

Insert into Inventory values('Monitor',50,10,'2024-08-25'),
							('Printer',30,5,'2024-09-01'),
							('Mouse',100,15,'2024-09-10'),
							('Keyboard',80,20,'2024-09-15'),
							('Laptop',25,5,'2024-09-20')

select * from inventory
							
--1.Write a query to find the total quantity of products in stock (SUM). 
select sum(QuantityInStock) as TotalQuantity from Inventory

--2. Write a query to find the product with the highest quantity in stock (MAX).
select productname,quantityinstock from Inventory where QuantityInStock= (select max(QuantityInStock) from Inventory)

--3. Write a query to find the average reorder level across all products (AVG). 
select avg(ReorderLevel) as AvgReorderLevel from Inventory 

--4. Write a query to find the product with the lowest reorder level (MIN). 
select productname,ReorderLevel from inventory where ReorderLevel= (select Min(ReorderLevel) from Inventory)

--5. Write a query to find the total quantity in stock for products where the quantity is 
--less than the reorder level (SUM with WHERE clause). 
select sum(QuantityInStock) as TotalQuantityInStock from Inventory
where QuantityInStock<ReorderLevel

--Assignment 4: Customer Orders Database 
--You have a CustomerOrders table that contains details about customer orders. The structure of 
--the table is as follows: 

Create table CustomerOrders(OrderId int PRIMARY KEY IDENTITY(501,1),
							CustomerID varchar(20),
							OrderDate date,
							OrderAmount int,
							QuantityOrdered int)

Insert Into CustomerOrders values('C001','2024-09-10',1500,3),
								 ('C002','2024-09-11',2000,5),
								 ('C001','2024-09-12',1000,2),
								 ('C003','2024-09-13',2500,4),
								 ('C002','2024-09-14',3000,6)

								 select * from CustomerOrders
--1. Write a query to calculate the total order amount for all orders (SUM). 
select sum(OrderAmount) as TotalAmount from CustomerOrders
--2. Write a query to find the average order amount for all customers (AVG)
select avg(OrderAmount) as AvgOrderAmount from CustomerOrders
--3. Write a query to find the maximum order amount from a single order (MAX).
select max(OrderAmount) as MaxOrderAmount from CustomerOrders where CustomerID='C001'
--4. Write a query to find the total quantity ordered across all orders (SUM). 
select sum(QuantityOrdered) as TotalQuantity from CustomerOrders
--5. Write a query to find the minimum order amount in the database (MIN). 
select min(OrderAmount) as MinOrderAmount from CustomerOrders

--Assignment 6: Product Ratings Database 
--You have a ProductRatings table containing customer ratings for various products. The 
--structure is as follows: 

Create table ProductRatings(RatingID int PRIMARY KEY IDENTITY(1,1),
							ProductID varchar(20),
							CustomerId varchar(30),
							Rating int,
							ReviewDate date)
Insert into ProductRatings values('P001','C001',4,'2024-09-01'),
								('P002','C002',5,'2024-09-02'),
								('P001','C003',3,'2024-09-03'),
								('P003','C001',2,'2024-09-04'),
								('P002','C004',4,'2024-09-05')
select * from ProductRatings
--1. Write a query to calculate the average rating for each product (AVG with GROUP BY). 
select Productid,avg(Rating) as AverageRating from ProductRatings GROUP BY ProductID
--2. Write a query to find the highest rating given to any product (MAX).
select max(rating) as MaxRatingof1 from ProductRatings WHERE ProductID='P001'
--3.Write a query to find the lowest rating given to any product (MIN). 
select min(rating) as MinRatingof2 from ProductRatings WHERE ProductID='P002'
--4.Write a query to find the total number of ratings for each product (COUNT and GROUP 
--BY). 
select ProductId,Sum(Rating) as TotalRatings from ProductRatings GROUP BY ProductID
--5. Write a query to find the total number of products rated (COUNT with DISTINCT).
select count(distinct productid) as TotalProducts from ProductRatings

--SQL Server assignments and solutions using various SQL operators such as IN, 
--BETWEEN, LIKE, AND, OR, NOT, etc. 
--Assignment 1:  
--Retrieve Employees Who Work in Specific Departments Using IN Operator 
--Task: Retrieve the names of employees who work in either the 'HR', 'Finance', or 'IT' 
--departments.
select * from employees
select EmployeeName,Department from Employees WHERE Department IN('HR','Finance','IT')

--Assignment 2:  
--Retrieve Products Within a Specific Price Range Using BETWEEN Operator 
--Task: Retrieve the product names and prices of products that are priced between 100 and 500. 
--Tables: 
-- Products (ProductID, ProductName, Price)
Create table Products(
		ProductID int NOT NULL Primary Key IDENTITY(1,1),
		ProductName varchar(200),
		Category varchar(200),
		Price int,
		Stock int)
		truncate table products

Insert into Products(ProductName,Category,Price,Stock)
			values('Laptop','Electronics',1000,50,),
				('Mouse','Electronics',20,200),
				('Keyboard','Electronics',30,150),
				('Printer','Electronics',150,75)
select * from products

select ProductName,Price from Products WHERE Price between 100 and 500

--Assignment 3:  
--Find Customers Whose Name Starts With 'A' Using LIKE Operator 
--Task: Retrieve the customer names that start with the letter 'A'. 
--Tables: 
--Customers (CustomerID, CustomerName)
Create table customers(
		CustomerID INT NOT NULL PRIMARY KEY IDENTITY(201,1),
		CustomerName varchar(200),
		Email varchar(200),
		Phonenumber varchar(10))

Insert into Customers(CustomerName,Email,Phonenumber)
		values('Alice Johnson','alice@example.com','555-1234'),
			  ('Bob Smith','bob@example.com','555-5678'),
			  ('Charlie Brown','charlie@example.com','555-8765')

select * from customers

select CustomerName from customers WHERE CustomerName LIKE 'A%'

--Assignment 4:  
--Retrieve Orders Placed on Specific Dates Using IN Operator 
--Task: Retrieve the order IDs of orders placed on '2023-01-01', '2023-02-01', and '2023-03-01'. 
--Tables: 
-- Orders (OrderID, OrderDate)

select OrderID,OrderDate from orders WHERE OrderDate in('2023-01-01', '2023-02-01', '2023-03-01')

Create table Orders(
	OrderId int NOT NULL PRIMARY KEY IDENTITY(301,1),
	CustomerID int NOT NULL,
	OrderDate date,
	TotalAmount decimal(10,2))
	select * from orders
Insert into Orders(
	CustomerID,OrderDate,TotalAmount)
	values(201,'2024-09-21',250.00),
		  (202,'2024-09-02',150.00),
		  (203,'2024-09-03',200.00),
		  (204,'2023-01-01',300.00),
		  (205,'2023-02-01',500.00),
		  (206,'2023-03-01',350.00)
Insert into orders values(208,'2023-04-14',3000)
select * from orders
drop table orders

--Assignment 5:  
--Retrieve Products That Are Not Priced Between 100 and 500 Using NOT BETWEEN 
--Operator 
--Task: Retrieve the product names and prices of products that are not priced between 100 and 
--500. 
--Tables: 
-- Products (ProductID, ProductName, Price)

Select ProductName,Price from products where price not between 100 and 500

--Assignment 6:  
--Find Orders Where the Total Amount is More Than 5000 or Less Than 1000 Using OR 
--Operator 
--Task: Retrieve the order IDs where the total amount is either greater than 5000 or less than 1000.

Select OrderId,TotalAmount from Orders WHERE TotalAmount>5000 or TotalAmount<1000

--Assignment 7:  
--Retrieve Employees Who Do Not Work in the 'HR' or 'IT' Departments Using NOT IN 
--Operator 
--Task: Retrieve the names of employees who do not work in the 'HR' or 'IT' departments. 

select EmployeeName,Department from employees where department not in('HR','IT')

--Assignment 8:  
--Retrieve Orders Placed in 2023 Using BETWEEN and AND Operators 
--Task: Retrieve the order IDs of orders placed between '2023-01-01' and '2023-12-31'. 
--Tables: 
-- Orders (OrderID, OrderDate)
select * from orders

select OrderId,Orderdate from Orders where Orderdate between '2023-01-01' and '2023-12-31'

--Assignment 9:  
--Find Customers Who Do Not Have 'John' in Their Name Using NOT LIKE Operator 
--Task: Retrieve the customer names that do not have 'John' in them.
select CustomerName from customers where CustomerName NOT LIKE '%John%'

--Assignment 10:  
--Retrieve Products That Are Either in Category 'A' or Priced Below 100 Using IN and OR 
--Operators 
--Task: Retrieve the product names and prices of products that are either in category 'A' or have a 
--price less than 100. 
--Tables: 
-- Products (ProductID, ProductName, Price, CategoryID) 
-- Categories (CategoryID, CategoryName)


select productname,price from products where categoryid= (select categoryid from categories where categoryname='A') or price<100

Create table Categories(CategoryID int PRIMARY KEY IDENTITY(101,1),CategoryName varchar(50))
select * from products
alter table products add CategoryID int

Create table Products(
		ProductID int NOT NULL Primary Key IDENTITY(1,1),
		ProductName varchar(200),
		Price int,
		CategoryID int,
		Foreign key(CategoryID) references Categories(CategoryID))

drop table products
		

Insert into Categories values('A'),('B'),('C'),('D')
select * from categories
drop table categories
Insert into Products values('Laptop',5000,101),
							('Mouse',4000,102),
							('Keyboard',4500,103),
							('Printer',5000,104)
select * from products

--Assignment 1: Add a New Column 
--Task: Add a column DateOfBirth (data type DATE) to the Employees table to store employees' 
--dates of birth.
select * from employees
use salesdb;
create table Employees(
	EmployeeID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName varchar(50),
	LastName varchar(50),
	Department varchar(50),
	Salary decimal(10,2)

);
alter table employees add DateOfBirth date

--Assignment 2  
--Task: Change the data type of the PhoneNumber column in the Customers table to 
--VARCHAR(15).

select * from customers

alter table customers alter column Phonenumber varchar(15)
--Assignment 3: Add a Primary Key 
--Task: Add a primary key to the DepartmentID column in the Departments table. 
select * from departments

create table departments(department_id int not null,department_name varchar(50))
insert into departments values(12,'IT'),(13,'Finance'),(14,'HR')
alter table departments add constraint PK_DepartmentId Primary Key(Department_ID)
drop table departments
--Assignment 4: Drop a Column 
--Task: Remove the MiddleName column from the Employees table.
ALTER table employees add MiddleName varchar(50)
Alter Table employees drop column MiddleName

--Assignment 5: Add a Foreign Key 
--Task: Add a foreign key to the EmployeeID column in the Orders table that references the 
--EmployeeID column in the Employees table. 
Alter table Orders ADD CONSTRAINT FK_EmployeeId_Orders FOREIGN KEY(EmployeeId) REFERENCES Employees(EmployeeID)

Create table Orders(
	OrderId int NOT NULL PRIMARY KEY IDENTITY(301,1),
	CustomerID int NOT NULL,
	OrderDate date,
	TotalAmount decimal(10,2))

Insert into Orders(
	CustomerID,OrderDate,TotalAmount)
	values(201,'2024-09-21',250.00),
		  (202,'2024-09-02',150.00),
		  (203,'2024-09-03',200.00)
Alter Table Orders add Employeeid int

Select * from orders

--Assignment 6: Drop a Foreign Key 
--Task: Remove the foreign key constraint that references EmployeeID from the Orders table.
Alter table Orders DROP CONSTRAINT Fk_EmployeeId_Orders

--Assignment 7: Rename a Column 
--Task: Rename the column FullName to EmployeeFullName in the Employees table.
Exec sp_rename 'Employees.EmployeeName','EmployeeFullName','Column'

--ALTER TABLE Employees 
--ADD CONSTRAINT DF_HireDate  
--DEFAULT GETDATE() FOR HireDate;

--Task: Add a default value of 'Active' to the Status column in the Employees table.
Alter Table Employees add Status varchar(50)
Alter Table Employees add constraint DF_Status Default 'Active' for Status

Update employees set status='Active'

--Assignment 9: Drop a Primary Key 
--Task: Drop the primary key constraint from the Departments table. 
alter table Departments drop Pk_DepartmentId

--Assignment 10: Add a Unique Constraint 
--Task: Ensure the Email column in the Employees table is unique by adding a unique constraint.

Alter table Employees add email varchar(50)
Alter Table Employees ADD Constraint UQ_email Unique(Email)

select * from employees

--Assignment 11: Add a Check Constraint 
--Task: Add a check constraint to the Salary column in the Employees table to ensure that no 
--salary is less than 1000.

Alter table Employees Add constraint chk_salary check(Salary>1000)

--Assignment 13: Drop a Check Constraint 
--Task: Remove the check constraint from the Salary column in the Employees table.
Alter table employees drop constraint chk_salary

--Insert into employees values('Abhay Deol','IT',5000,Default,'1999-04-21',Default,'abhay@gmail.com')

--SQL Server assignments involving subqueries. 
--Assignment 1:  
--Retrieve Employees Who Earn More Than the Average Salary 
--Task: Retrieve the names and salaries of employees whose salary is greater than the average 
--salary of all employees in the company. 
--Tables: 
--Employees (EmployeeID, EmployeeName, Salary)
select * from employees
select EmployeeFullName,Salary from Employees where salary>(select avg(salary) from employees)

--Assignment 2:  
--Find Departments with More Than 5 Employees 
--Task: Retrieve the department names that have more than 5 employees. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, DepartmentID) 

select department_name from departments 
where department_id in
		(select department_id from employees2 
		group by department_id having
		count(Employeeid)>5)

Create table Employees2(EmployeeID int,
						EmployeeName varchar(30),
						Department_ID int,
						salary int,
						managerid int)
						drop table employees2

select * from departments
select * from employees2
select * from departments
Insert into employees2 values(1,'John Mathew',12,50000,4),
							 (2,'Anil Antony',13,40000,4),
							 (3,'Jacob M',13,35000,2),
							 (4,'Rahul Roy',13,40000,1),
							 (5,'Neeta Philip',13,45000,3),
							 (6,'Priya Roy',13,35000,4),
							 (7,'Sana Joy',13,40000,4)
							 

				select * from employees2
create table departments(department_id int not null,department_name varchar(50))
insert into departments values(12,'IT'),(13,'Finance'),(14,'HR')
select * from departments
alter table departments add constraint PK_DepartmentId Primary Key(Department_ID)
alter table employees2 add constraint FK_DepartmentID FOREIGN KEY(Department_ID) REFERENCES Departments(department_ID)
select * from departments
drop table departments
--Assignment 3:  
--Retrieve Products with a Price Higher Than the Maximum Price of Category 'A' 
--Task: Retrieve the product names and prices of products that have a price higher than the 
--maximum price of products in category 'A'. 
--Tables: 
-- Products (ProductID, ProductName, Price, CategoryID)
select * from products
select * from categories
Create table products2(ProductID int PRIMARY KEY IDENTITY(1,1),
					ProductName varchar(50),
					Price int,
					CategoryID int)


Select ProductName,Price from products 
			where price> (select max(price) from products where 
			categoryid=(select categoryid from categories where categoryname='A'))


--Assignment 4:  
--Retrieve Employees Who Work in Departments with Average Salary Higher Than 50,000 
--Task: Retrieve the names of employees who work in departments where the average salary is 
--higher than 50,000. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, Salary, DepartmentID) 
-- Departments (DepartmentID, DepartmentName)
select * from employees2
select * from departments
alter table employees2 add salary int


SELECT EmployeeName
FROM Employees2
WHERE Department_ID IN (
    SELECT Department_ID
    FROM Employees2
    GROUP BY Department_ID
    HAVING AVG(Salary) > 50000
);


--Assignment 5:  
--Find Employees Who Earn More Than Their Department's Average Salary 
--Task: Retrieve the names of employees who earn more than the average salary of their 
--department. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, Salary, DepartmentID)

Select EmployeeName,Salary from employees2 
			WHERE salary>
			(select avg(salary) from employees2
			where Department_id=employees2.Department_ID)

--Assignment 6:  
--Find Customers Who Have Not Placed Any Orders 
--Task: Retrieve the names of customers who have not placed any orders. 
--Tables: 
-- Customers (CustomerID, CustomerName) 

select CustomerName from customers where customerid 
				not in(select customerid from orders group by customerid)

select * from customers
select * from orders

insert into Customers values('Rahul Roy','rahul@gmail.com',555-1342)
insert into orders values(204,'2024-03-21',300,7)

--Assignment 8:  
--Find Products That Have Never Been Ordered 
--Task: Retrieve the names of products that have never been ordered. 
--Tables: 
-- Products (ProductID, ProductName) 
-- OrderDetails (OrderID, ProductID)


select productname from products where productid not in(select productid from orders)
select * from orders
select * from products
alter table orders add productid int
alter table orders add constraint fk_productid foreign key(productid) references products(productid)

--JOINS ASSIGNMENT
--Assignment 1:  
--Retrieve Employees and Their Department Names (INNER JOIN) 
--Task: Retrieve the employee names and their corresponding department names. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, DepartmentID) 
-- Departments (DepartmentID, DepartmentName)

select * from employees2
select * from departments

select e.employeename,d.department_name from employees2 e
	inner join departments d ON e.department_id=d.department_id

--Assignment 2:  
--Retrieve All Employees and Their Department Names, Including Those Without 
--Departments (LEFT JOIN) 
--Task: Retrieve the employee names and their corresponding department names. Include 
--employees who are not assigned to any department. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, DepartmentID) 
select e.employeename,d.department_name from employees2 e left join departments d on 
			e.department_id= d.department_id

--Assignment 3:  
--Retrieve All Departments and the Employees Working in Them (RIGHT JOIN) 
--Task: Retrieve all departments and their respective employees. Include departments even if they 
--don’t have any employees. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, DepartmentID)
select  e.employeename,d.department_name
		from Employees2 e right join Departments d on e.Department_ID=d.department_id

--Assignment 4:  
--Retrieve All Employees and Departments, Including Those Without Matches (FULL 
--OUTER JOIN) 
--Task: Retrieve all employees and all departments, including employees without a department 
--and departments without employees. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, DepartmentID) 
-- Departments (DepartmentID, DepartmentName)

select e.employeename,d.department_name 
from Employees2 e FULL OUTER JOIN Departments d ON e.department_id=d.department_id

--Assignment 5:  
--Retrieve Orders and the Customers Who Placed Them (INNER JOIN) 
--Task: Retrieve order IDs and customer names for all orders. 
--Tables: 
-- Orders (OrderID, CustomerID)

select * from orders
select * from customers
Select o.orderid,c.customername from orders o Inner join Customers c On o.CustomerID=c.CustomerID

--Assignment 6:  
--Retrieve Orders and Customers, Including Customers Without Orders (LEFT JOIN) 
--Task: Retrieve all customers and their respective orders. Include customers even if they haven’t 
--placed any orders.
select c.customerid,c.CustomerName,o.Orderid from customers c left join orders o On  c.customerid=o.customerid

--Assignment 7:  
--Retrieve Products and Their Categories (INNER JOIN) 
--Task: Retrieve product names and their respective category names. 
--Tables: 
-- Products (ProductID, ProductName, CategoryID)

select * from products
select * from categories
select p.productname,c.categoryname from products p inner join categories c on p.categoryid=c.categoryid

--8.Retrieve All Categories and Products, Including Categories Without Products (RIGHT 
--JOIN) 
--Task: Retrieve all categories and the products in each category. Include categories that don’t 
--have any products. 
--Tables: 
-- Products (ProductID, ProductName, CategoryID) 
-- Categories (CategoryID, CategoryName)

select p.productname,c.categoryid,c.categoryname from products p Right join categories c ON p.categoryid=c.categoryid

--Assignment 9:  
--Retrieve Employees and Their Managers (Self-Join) 
--Task: Retrieve the employee names and the names of their managers. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, ManagerID)

alter table employees2 add managerid int
select * from employees2
select e.employeename as managername,
m.employeename as Employee from Employees2 e inner join Employees2 m on e.Employeeid=m.Managerid

--Assignment 10:  
--Get All Possible Combinations of Products and Orders (CROSS JOIN) 
--Task: Retrieve all possible combinations of products and orders (cartesian product). 
--Tables: 
-- Products (ProductID, ProductName) 
-- Orders (OrderID)
select * from products
select * from orders
select p.productname,o.orderid from products p cross join orders o

--SQL Server assignments using the GROUP BY and HAVING clauses
--Assignment 1:  
--Find the Average Salary in Each Department 
--Task: Retrieve the department name and the average salary of employees in each department. 
--Only display departments where the average salary is greater than 50,000.
select * from Employees2
select * from departments
select departmentname,salary from employees2 where 
salary=(select avg(salary) from employees2 group by department_id having salary>50000)

SELECT 
    d.Department_Name, 
    AVG(e.Salary) AS AverageSalary
FROM 
    Employees2 e
JOIN 
    Departments d ON e.Department_ID = d.Department_ID
GROUP BY 
    d.Department_Name
HAVING 
    AVG(e.Salary) > 50000;
	alter table employees2 add salary int

--Assignment 2:  
--Count the Number of Employees in Each Department 
--Task: Retrieve the department name and the total number of employees in each department. 
--Only display departments that have more than 5 employees. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, DepartmentID) 

select 
		distinct d.department_name,
count(e.Employeeid) as TotalEmployees
from Departments d 
			join Employees2 e on d.department_id=e.department_id
		group by d.department_name having Count(e.employeeid)>5

--		Assignment 3:  
--Find the Maximum and Minimum Salary in Each Department 
--Task: Retrieve the department name, maximum salary, and minimum salary for each 
--department. Only include departments where the minimum salary is greater than 30,000. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, Salary, DepartmentID)

select * from employees2
select 
		d.department_name,
		max(e.salary) as MaxSalary,
		min(e.salary) as MinSalary
from 
		departments d
join
		employees2 e 
on 
		d.department_id= e.department_id
group by
		d.department_name
having
		min(e.salary)>30000

--Assignment 4:  
--Find the Total Sales by Each Salesperson 
--Task: Retrieve the employee name and total sales made by each salesperson. Only display 
--salespersons who have made total sales of more than 100,000. 
--Tables: 
-- Sales (SalesID, EmployeeID, Amount)
select e.employeename,sum(s.Saleamount) from Employees2 e join sales s
on e.employeeid=s.employeeid 
group by e.Employeename having Sum(s.SaleAmount)>100000


alter table sales add employeeid int
alter table sales 
add constraint fk_employeeid
foreign key(employeeid) references
employees2(employeeid)
select * from employees2
alter table employees2 alter column employeeid int not null 
alter table employees2 add constraint pk_employeeid primary key(Employeeid)
select * from products
select * from sales

--Assignment 5:  
--Find the Number of Orders by Each Customer 
--Task: Retrieve the customer name and the total number of orders placed by each customer. Only 
--display customers who have placed more than 3 orders. 
--Tables: 
-- Orders (OrderID, CustomerID) 
-- Customers (CustomerID, CustomerName)
select * from orders
select * from customers
select c.customername,count(o.orderid) as TotalOrders
from Customers c join orders o
on c.customerid=o.customerid
group by c.customername having count(orderid)>3
