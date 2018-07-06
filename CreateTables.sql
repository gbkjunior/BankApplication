CREATE TABLE ACCOUNTS (
	Account_ID int,
	Account_Type varchar(15)
) 

CREATE TABLE CUSTOMERS (
	Customer_ID int,
	Customer_Name varchar(45),
	Customer_Address varchar(100),
	Customer_Telephone varchar(20),
)

CREATE TABLE CUSTOMER_ACCOUNTS (
	Customer_ID int,
	Account_ID int,
	Balance decimal(10)
)

CREATE TABLE TRANSACTIONS (
	Transaction_ID int,
	Transaction_Type varchar(15),
	Transaction_Date varchar(20),
	Amount decimal(10),
	Account_ID int,
	Customer_ID int
)