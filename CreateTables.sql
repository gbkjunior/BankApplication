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
	Customer_Email varchar(45),
	Customer_Password varchar(45),
	Customer_DOB varchar(15),
	Customer_Telephone varchar(20),
	Customer_Address varchar(100),
)

CREATE TABLE Customer_Accounts_Table (
	Customer_ID int foreign key references CustomerTable(Customer_ID) not null,
	Account_ID int foreign key references AccountTable(Account_ID) not null,
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

insert into CustomerTable values('Vijayadeepak','vijay@gmail.com','deepak','01/01/1990','5157358100','4122 Lincoln Swing St, Ames');

INSERT INTO [dbo].[AccountTable] ([Account_ID], [Account_Type]) VALUES (1, N'Checking')
INSERT INTO [dbo].[AccountTable] ([Account_ID], [Account_Type]) VALUES (2, N'Savings')
INSERT INTO [dbo].[AccountTable] ([Account_ID], [Account_Type]) VALUES (3, N'Loan')


INSERT INTO [dbo].[Customer_Accounts_Table] ([Customer_ID], [Account_ID], [Balance]) VALUES (1, 1, CAST(100 AS Decimal(10, 0)))
INSERT INTO [dbo].[Customer_Accounts_Table] ([Customer_ID], [Account_ID], [Balance]) VALUES (1, 2, CAST(315 AS Decimal(10, 0)))
INSERT INTO [dbo].[Customer_Accounts_Table] ([Customer_ID], [Account_ID], [Balance]) VALUES (2, 3, CAST(350 AS Decimal(10, 0)))
INSERT INTO [dbo].[Customer_Accounts_Table] ([Customer_ID], [Account_ID], [Balance]) VALUES (4, 2, CAST(100 AS Decimal(10, 0)))
INSERT INTO [dbo].[Customer_Accounts_Table] ([Customer_ID], [Account_ID], [Balance]) VALUES (7, 3, CAST(140 AS Decimal(10, 0)))


SET IDENTITY_INSERT [dbo].[TransactionTable] ON
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (1, N'Deposit', N'08-07-2018 02:52:21', CAST(100 AS Decimal(10, 0)), 1, 1)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (2, N'Withdraw', N'08-07-2018 02:52:30', CAST(50 AS Decimal(10, 0)), 1, 1)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (3, N'Withdraw', N'08-07-2018 02:55:12', CAST(25 AS Decimal(10, 0)), 1, 1)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (4, N'Deposit', N'08-07-2018 02:55:26', CAST(45 AS Decimal(10, 0)), 1, 1)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (5, N'Deposit', N'08-07-2018 02:55:41', CAST(450 AS Decimal(10, 0)), 2, 1)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (6, N'Withdraw', N'08-07-2018 02:56:03', CAST(135 AS Decimal(10, 0)), 2, 1)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (7, N'Deposit', N'08-07-2018 02:57:26', CAST(350 AS Decimal(10, 0)), 3, 2)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (8, N'Deposit', N'08-07-2018 17:25:40', CAST(30 AS Decimal(10, 0)), 1, 1)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (9, N'Deposit', N'08-07-2018 18:44:55', CAST(135 AS Decimal(10, 0)), 2, 4)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (10, N'Withdraw', N'08-07-2018 18:47:01', CAST(35 AS Decimal(10, 0)), 2, 4)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (11, N'Deposit', N'08-07-2018 18:53:47', CAST(140 AS Decimal(10, 0)), 3, 7)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (12, N'Deposit', N'08-07-2018 23:32:34', CAST(25 AS Decimal(10, 0)), 1, 1)
INSERT INTO [dbo].[TransactionTable] ([Transaction_ID], [Transaction_Type], [Transaction_Date], [Amount], [Account_ID], [Customer_ID]) VALUES (13, N'Withdraw', N'09-07-2018 21:20:38', CAST(25 AS Decimal(10, 0)), 1, 1)
SET IDENTITY_INSERT [dbo].[TransactionTable] OFF
