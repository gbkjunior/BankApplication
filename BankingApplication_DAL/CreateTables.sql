Drop table ACCOUNTS;
Drop table CUSTOMERS;
Drop table CUSTOMER_ACCOUNTS;
Drop table TRANSACTIONS;

CREATE TABLE Accounts (
	Account_ID int,
	Account_Type varchar(15)
) 

CREATE TABLE Customers (
	Customer_ID int,
	Customer_Name varchar(45),
	Customer_Address varchar(100),
	Customer_Telephone varchar(20),
)

CREATE TABLE Customer_Accounts (
	Customer_ID int,
	Account_ID int,
	Balance decimal(10)
)

CREATE TABLE Transactions (
	Transaction_ID int,
	Transaction_Type varchar(15),
	Transaction_Date varchar(20),
	Amount decimal(10),
	Account_ID int,
	Customer_ID int
)