--qn1 Create a database named CompanyDB.--
Create database companyDB
use companyDB
--qn2 Create a table named Employees with the following columns:--
create table Employees(
	EmployeeID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName varchar(50),
	LastName varchar(50),
	Department varchar(50),
	Salary decimal(10,2)

);
--Assignment2--
Insert into Employees(EmployeeID,FirstName,LastName,Department,Salary)
values(1,'John','Doe','HR',50000),
	  (2,'Jane', 'Smith', 'IT', 60000),
	  (3,'David', 'Lee', 'Marketing', 55000);
select FirstName,Department from Employees



--Assignment 3 qn1--
SELECT * FROM Employees

SELECT FirstName,LastName,Salary from Employees WHERE Department='IT' and Salary>5000

SELECT MAX(Salary) AS MaxSalary from Employees

--Assignment 4--
UPDATE Employees set salary=55000 where FirstName='John' and LastName='Doe'

UPDATE Employees set department='Marketing' WHERE FirstName='Jane'

--Assignment 5--
Delete from employees where FirstName='David'

Delete from employees where department='Marketing'

--Assignment 6 Create a tabled named Products and insert below records in the table.--
Create table Products(
		ProductID int NOT NULL Primary Key IDENTITY(1,1),
		ProductName varchar(200),
		Category varchar(200),
		Price int,
		Stock int)

Insert into Products(ProductName,Category,Price,Stock)
			values('Laptop','Electronics',1000,50),
				('Mouse','Electronics',20,200),
				('Keyboard','Electronics',30,150),
				('Printer','Electronics',150,75)
				--qn 2 select all columns from product table--
select * from products
--qn 3 Select products, sorted by their price in descending order.--
Select * from products Order by Price DESC

--qn 4 Update the price of the "Mouse" to 25.--
Update Products set price=25 where ProductName='Mouse'

--qn 5 Delete the product with ProductID 2 (Mouse).--
Delete from Products where productid=2

--qn6 Select products sorted by ProductName in alphabetical order.--
Select * from products order by ProductName ASC

--qn 7 Create a tabled named Books with the below structure and insert below records in the table--
Create table Books(
		BookID int NOT NULL PRIMARY KEY IDENTITY(1,1),
		Title varchar(200),
		Author varchar(200),
		PublishedYear int,
		AvailableCopies int);
Insert into Books(Title,Author,PublishedYear,AvailableCopies)
			values('The Great Gatsby','F.Scott Fitzgerald',1925,3),
				  ('1984','George Orwell',1949,2),
				  ('To Kill a MockingBird','Harper Lee',1960,5),
				  ('Brave New World','Aldous Huxley',1932,4)
select * from books;
--Update the available copies of "1984" to 5.
Update Books set AvailableCopies=5 where Title='1984'

--Delete the book with BookID 1 (The Great Gatsby).
Delete from Books where BookID=1

--Write a query to Select books published after 1950.
Select * from Books where PublishedYear>1950

--Assignment 8 Customer Management, Create a Customers table containing details about customers with the below details.
Create table customers(
		CustomerID INT NOT NULL PRIMARY KEY IDENTITY(201,1),
		CustomerName varchar(200),
		Email varchar(200),
		Phonenumber varchar(10))

Insert into Customers(CustomerName,Email,Phonenumber)
		values('Alice Johnson','alice@example.com','555-1234'),
			  ('Bob Smith','bob@example.com','555-5678'),
			  ('Charlie Brown','charlie@example.com','555-8765')

select * from customers;

--2. Insert a new customer into the Customers table with the following details:
--a. CustomerID: 204
--b. CustomerName: David Wilson
--c. Email: david@example.com
--d. PhoneNumber: 555-4321

Insert into Customers(CustomerName,Email,PhoneNumber)
	values('David Wilson','david@example.com','555-4321')

--Update the phone number of "Alice Johnson" to "555-9999".
update Customers set PhoneNumber='555-9999' 
where CustomerName='Alice Johnson'

Delete from customers where CustomerId=202

--Assignment 9 Create an Orders table that contains information about customer orders with the below
--details:
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

select * from orders

--qn2 Insert a new order into the Orders table with the following details:
--a. OrderID: 304
--b. CustomerID: 204
--c. OrderDate: 2024-09-04
--d. TotalAmount: 300.00

Insert into Orders(CustomerID,OrderDate,TotalAmount)
		values(204,'2024-09-04',300.00)
--3.Update the TotalAmount for OrderID 301 to 275.00.

Update Orders set TotalAmount=275.00 WHERE OrderId=301

--4.Delete the order with OrderID 302.

delete from Orders where orderID =302

--5.Select orders with a total amount greater than 200.

Select * from Orders WHERE TotalAmount>200

--6.Select only the OrderID and TotalAmount for all orders.
Select OrderID,TotalAmount from Orders

--Assignment 10 Create a Students table with a StudentID as the primary key and include the following columns:
--FirstName, LastName, and Email. Insert three records into the table.

Create table Students(
		StudentID int PRIMARY KEY IDENTITY(1,1),
		FirstName varchar(200),
		LastName varchar(50),
		Email varchar(50))

Insert Into Students(FirstName,LastName,Email)
	values('John','Doe','john.doe@example.com'),
		('Jane','Smith','jane.smith@example.com'),
		('Mike','Johnson','mike.johnson@example.com')
				
select * from students

--Assignment 11 Create a Courses table with a CourseID as the primary key. Create a Enrollments table with a
--StudentID as a foreign key referencing the Students table and a CourseID as a foreign key
--referencing the Courses table. Insert sample data into both tables.

create table courses(
		CourseID int PRIMARY KEY IDENTITY(100,1),
		CourseName varchar(50))

create table enrollments( 
		EnrollmentID INT PRIMARY KEY,
		StudentID int,
		CourseID int,
		FOREIGN KEY(StudentID) references Students(studentId),
		FOREIGN KEY(CourseID) references Courses(CourseID))

insert into Courses(CourseName)
		values('Python'),
			  ('Csharp'),
			  ('Java')
select * from courses

insert into enrollments(EnrollmentID,StudentID,CourseID)
			values(50,1,100),
				  (51,2,101),
				  (52,3,102)

select * from enrollments

--12 Composite Key Create an OrderDetails table that contains OrderID, ProductID, and Quantity. Define a
--composite primary key using OrderID and ProductID.
create table Orderdetails(
orderid int,productid int,quantity int,
primary key(orderid,productid))

use companyDB
--13 Create a Users table with UserID as the primary key, and include Email and Username as
--candidate keys. Set the Email column as a unique key.

create table users(userid int primary key,
	username varchar(50),
	email varchar(50) UNIQUE)

--14.Create table with surrogate key
create table products1(autoID int IDENTITY(1,1) PRIMARY KEY,
					ProductName VARCHAR(100),
					Price DECIMAL(10,2));
--15.Create a Employees table that uses SSN (Social Security Number) as a natural key. Include 
--columns for FirstName, LastName, and Position. 

Create table Employees2(
	SSN char(9) PRIMARY KEY,
	FirstName varchar(50),
	LastName varchar(50),
	Position varchar(50)
	)
select * from Employees

--16.Create a Customers table with a CustomerID as the primary key and a PhoneNumber column 
--that must be unique. 
create table customers2(
	CustomerID int PRIMARY KEY,
	CustomerName varchar(255),
	Phonenumber varchar(255) UNIQUE)

	--17. Views, 
	--qn1. Create a simple view named EmployeeView that displays the FirstName, LastName, and 
--Department columns from the Employees table.
create view EmployeeView as 
Select FirstName,LastName,Department from Employees

--query view to display
Select * from employeeview

--18.Create a view named EditableEmployeeView that shows EmployeeID, FirstName, 
--LastName, and Salary. 

create view EditableEmployeeView as
Select EmployeeID,FirstName,LastName,Salary from Employees

select * from EditableEmployeeView

--2.Update the salary of an employee using the view.

Update EditableEmployeeView 
set Salary=70000 where Employeeid=1

--verify the update
select * from EditableEmployeeView

--19.Create a view named EmployeeSalaryBonusView that displays each employee’s 
--FirstName, LastName, Salary, and a calculated column Bonus (10% of the salary).

create view EmployeeSalaryBonusView as
select FirstName,LastName,Salary,Salary*0.10 as SalaryBonus
from Employees

--Query the view 
select * from EmployeeSalaryBonusView

--20.Alter the EmployeeView from Assignment 1 to include a new column Salary.

Alter view EmployeeView as
Select FirstName,LastName,Department,Salary
from employees
--2.Verify the view with the updated column. 
select * from EmployeeView

--21.
--1.Create a view named FilteredEmployeeView from employees table that displays 
--EmployeeID,FirstName,LastName & Department. 

Create view FilteredEmployeeView as
select EmployeeID,FirstName,LastNAme,Department
from employees

select * from FilteredEmployeeView
--2.Use a query on the view to return employees in a specific department (e.g., 
--DepartmentID = 2). 

Select * from FilteredEmployeeView where Department='HR'
--Assignment 22
--1.Drop the EmployeeView that was created in the previous assignments.
Drop view EmployeeView

--Try to query the view again.
select * from employeeview







--SELECT * FROM Employees where Department='IT'

--SELECT * FROM Employees WHERE Salary>=55000

--SELECT MAX(Salary) As MaxSalary FROM Employees;

--SELECT MIN(Salary) As MinSalary FROM Employees;

--Update Employees set Salary=70000 WHERE FirstName='John'

--delete from Employees where EmployeeID=2

--Select * from Employees 
--Order BY Salary ASC

