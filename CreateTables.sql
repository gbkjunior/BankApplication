Drop table AccountTable;
Drop table CustomerTable;
Drop table Customer_Accounts_Table;
Drop table TransactionTable;

CREATE TABLE AccountTable (
	Account_ID int primary key,
	Account_Type varchar(15) not null
) 

CREATE TABLE CustomerTable (
	Customer_ID int primary key not null identity(1,1),
	Customer_Name varchar(45),
	Customer_Address varchar(100),
	Customer_Telephone varchar(20),
)

CREATE TABLE Customer_Accounts_Table (
	Customer_ID int foreign key references CustomerTable(Customer_ID),
	Account_ID int foreign key references AccountTable(Account_ID),
	Balance decimal(10) not null
)

CREATE TABLE TransactionTable (
	Transaction_ID int primary key not null identity(1,1),
	Transaction_Type varchar(15),
	Transaction_Date varchar(20),
	Amount decimal(10) default 100 not null,
	Account_ID int foreign key references AccountTable(Account_ID),
	Customer_ID int foreign key references CustomerTable(Customer_ID)
)