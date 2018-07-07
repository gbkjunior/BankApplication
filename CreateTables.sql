Drop table Account;
Drop table Customer;
Drop table Customer_Account;
Drop table Transactions;

CREATE TABLE AccountTable (
	Account_ID int,
	Account_Type varchar(15)
) 

CREATE TABLE CustomerTable (
	Customer_ID int Not Null identity(1,1) primary key,
	Customer_Name varchar(45),
	Customer_Address varchar(100),
	Customer_Telephone varchar(20),
)

CREATE TABLE Customer_Account_Table (
	Customer_ID int,
	Account_ID int,
	Balance decimal(10)
)

CREATE TABLE TransactionTable (
	Transaction_ID int,
	Transaction_Type varchar(15),
	Transaction_Date varchar(20),
	Amount decimal(10),
	Account_ID int,
	Customer_ID int
)