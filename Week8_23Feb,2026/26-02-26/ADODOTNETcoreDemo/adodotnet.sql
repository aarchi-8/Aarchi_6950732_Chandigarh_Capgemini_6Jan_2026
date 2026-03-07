use [employeeDB]

CREATE TABLE Address(
	AddressID int IDENTITY(1,1) NOT NULL Primary key,
	Street varchar(255) NULL,
	City varchar(100) NULL,
	State varchar(100) NULL,
	PostalCode Varchar(20) NULL
);

ALTER TABLE Address
ADD CONSTRAINT PK_Address PRIMARY KEY(AddressID);

CREATE TABLE Employee(
	EmployeeID int identity(1,1) not null primary key,
	FirstName varchar(100) null,
	LastName varchar(100) null,
	Email varchar(100) null,
	AddressID int null,
	Foreign Key (AddressID) References Address(AddressID)
); 
SET IDENTITY_INSERT Address ON;
INSERT into Address(AddressID, Street, City	, State, PostalCode) 
						Values
						(1, '1234 Elm Street', 'Springfield ', 'Illinois', '62704'),
						(2, '5678 Oak Street', 'Decatur', 'Alabama', '35601'),
						(4, '123 Patia', 'BBSR' , 'India', '755019'),
						(5, '123 Patia', 'BBSR' , 'India', '755019');

						SET IDENTITY_INSERT Address OFF;

						SET IDENTITY_INSERT Employee ON;
INSERT INTO Employee (EmployeeID, FirstName, LastName, Email, AddressID)
VALUES
(1,'John', 'Doe', 'johndoe@example.com', 1),
(2,'Jane', 'Doe', 'janedoe@example.com', 2),
(4,'Ramesh', 'Sharma', 'ramesh@example.com', 4),
(5, 'Ramesh', 'Sharma', 'ramesh@example.com', 5);
SET IDENTITY_INSERT Employee OFF;


create procedure CreateEmployeeWithAddress
@FirstName varchar(100),
@LastName varchar(100),
@Email varchar(100),
@Street varchar(255),
@City varchar(100),
@State varchar(100),
@PostalCode varchar(20)
AS
BEGIN
DECLARE @AddressID int;
Insert into Address (Street, City, State, PostalCode)
values (@Street, @City, @State, @PostalCode);
set @AddressID = SCOPE_IDENTITY();

insert into Employee (FirstName, LastName, Email, AddressID)
values (@FirstName, @LastName, @Email, @AddressID);
end

EXEC CreateEmployeeWithAddress
'Aarchi',
'Soorma',
'aarchi@email.com',
'Patia',
'BBSR',
'India',
'755019';
go

CREATE PROCEDURE DeleteEmployee
@EmployeeID int
As
begin
declare @AddressID int;

begin transaction;

select @AddressID = AddressID from Employee where EmployeeID = @EmployeeID;

delete from employee where EmployeeID = @EmployeeID;

delete from address where AddressID = @AddressID;

commit transaction;
end;
EXEC DeleteEmployee 1;
go

CREATE PROCEDURE GetAllEmployees
AS
begin
select e.EmployeeID, e.FirstName, e.LastName, e.Email, a.Street, a.City, a.State, a.PostalCode
from Employee e
inner join Address a on e.AddressID = a.AddressID;
end;


EXEC GetAllEmployees;
go

create procedure GetEmployeeID
@EmployeeID int
AS
begin
select e.EmployeeID, e.FIrstName, e.LastName, e.Email, a.Street, a.City, a.State, a.PostalCode
from Employee e
inner join Address a on e.AddressID = a.AddressID
where e.EmployeeID = @EmployeeID;
end 

EXEC GetEmployeeID 2;
go

CREATE PROCEDURE UpdateEmployeeWithAddress
(
    @EmployeeID INT,
    @FirstName VARCHAR(100),
    @LastName VARCHAR(100),
    @Email VARCHAR(100),
    @Street VARCHAR(255),
    @City VARCHAR(100),
    @State VARCHAR(100),
    @PostalCode VARCHAR(20),
    @AddressID INT
)
AS
BEGIN
    -- Update Address table
    UPDATE Address
    SET 
        Street = @Street,
        City = @City,
        State = @State,
        PostalCode = @PostalCode
    WHERE AddressID = @AddressID;

    -- Update Employee table
    UPDATE Employee
    SET 
        FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        AddressID = @AddressID
    WHERE EmployeeID = @EmployeeID;
END;

EXEC UpdateEmployeeWithAddress
    @EmployeeID = 1,
    @FirstName = 'John',
    @LastName = 'Doe',
    @Email = 'johnupdated@email.com',
    @Street = 'New Street',
    @City = 'Delhi',
    @State = 'Delhi',
    @PostalCode = '110001',
    @AddressID = 1;
go