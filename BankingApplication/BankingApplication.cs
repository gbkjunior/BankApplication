using BankingApplication_BO;
using BankingApplication_BLL;
using System;
using System.Collections.Generic;

namespace BankingApplication
{
    class BankingApplication
    {
        static void Main(string[] args)
        {
            Accounts_BLL accounts = new Accounts_BLL();
            Transactions_BLL transactions = new Transactions_BLL();
            Customers_BLL customers = new Customers_BLL();
            
            bool bankMenuFlag = true;
            bool selectAcctMenuFlag = true;
            bool mainMenuFlag = true;
            bool accountMenuFlag = true;
            bool transMenuFlag = true;
            bool custFlag = true;
            bool checkCustFlag = true;

            BankMenu();

            void BankMenu()
            {
                try
                {
                    do
                    {
                        Console.WriteLine("Application Menu:\n1. Login \n2. Register \n3. Exit");
                        string bankMenuInput = Console.ReadLine();

                        bool bankMenuInputCheck = int.TryParse(bankMenuInput, out int bankMenuInputInteger);

                        if (bankMenuInputCheck)
                        {
                            switch (bankMenuInputInteger)
                            {
                                case 1:
                                    CustomerLoginMenu();
                                    break;
                                case 2:
                                    CustomerRegisterMenu();
                                    continue;
                                case 3:
                                    bankMenuFlag = false;
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Please choose either 1 or 2 or 3");
                                    break;
                            }
                        }
                        else
                            Console.WriteLine("Please enter a value from the given options");

                    } while (bankMenuFlag);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: {0}", e.ToString());
                }
            }

            void CustomerLoginMenu()
            {
                do
                {
                    Console.WriteLine("Enter your customer ID:");
                    string custInput = Console.ReadLine();

                    bool custInputCheck = int.TryParse(custInput, out int custInputInteger);
                    if (custInputCheck)
                    {
                        checkCustFlag = customers.validateCustomer(custInputInteger);
                        if (checkCustFlag)
                        {
                            Console.WriteLine("Welcome to our Banking Application, {0}. You have successfully logged in.", customers.GetCustomerName(custInputInteger));
                            MainMenu(custInputInteger);
                            custFlag = false;
                        }
                        else
                        {
                            Console.WriteLine("Your customer ID is not found. Please try again.");   
                        }
                    }
                } while (custFlag);
            }

            void CustomerRegisterMenu()
            {
                try
                {
                        Console.WriteLine("Welcome to our Banking Application. Please enter the following details:\n");

                        Console.WriteLine("Enter your Full Name");
                        string userNameInput = Console.ReadLine();

                        Console.WriteLine("Enter your Address");
                        string userAddressInput = Console.ReadLine();

                        Console.WriteLine("Enter your Telephone Number");
                        string userTelephoneInput = Console.ReadLine();
                    
                        Console.WriteLine("You have registered successfully. Your customerID is: {0}", customers.AddNewCustomer(userNameInput, userAddressInput, userTelephoneInput));
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception caught: {0}", e.ToString());
                }
            }

            void MainMenu(int custID)
            {
                try
                {
                    do
                    {
                        Console.WriteLine("Main Menu:\n1. Accounts \n2. Transactions \n3. Log Out");
                        string mainMenuInput = Console.ReadLine();
                        
                        bool mainMenuInputCheck = int.TryParse(mainMenuInput, out int mainMenuInputInteger);
                        
                        if (mainMenuInputCheck)
                        {
                            switch (mainMenuInputInteger)
                            {
                                case 1:
                                    SelectAccountMenu(custID);
                                    break;
                                case 2:
                                    SelectTransactionMenu(custID);
                                    break;
                                case 3:
                                    mainMenuFlag = false;
                                    transMenuFlag = false;
                                    selectAcctMenuFlag = false;
                                    selectAcctMenuFlag = false;
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Please choose either 1 or 2 or 3");
                                    break;
                            }
                        }
                        else
                            Console.WriteLine("Please enter a value from the given options");

                    } while (mainMenuFlag);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }

            }

            void AccountMenu(int custID,int acctID)
            {
                try
                {
                    do
                    {
                        Console.WriteLine("Account Menu: \n1. Get Balance \n2. Withdraw \n3. Deposit \n4. Select Account Menu \n5. Main Menu");
                        string accountMenuInput = Console.ReadLine();

                        bool accountMenuInputCheck = int.TryParse(accountMenuInput, out int accountMenuInputInteger);

                        if (accountMenuInputCheck)
                        {
                            switch (accountMenuInputInteger)
                            {
                                case 1:
                                    Console.WriteLine("Your {0} account balance is: {1}", accounts.GetAccountTypeByID(acctID), transactions.GetBalance(custID,acctID));
                                    break;
                                case 2:
                                    Console.WriteLine("Enter an amount to withdraw:");
                                    string amount = Console.ReadLine();
                                    bool checkAmount = double.TryParse(amount, out double amountValue);
                                    if (checkAmount)
                                    {
                                        if (transactions.GetBalance(custID, acctID) - amountValue < 0)
                                            Console.WriteLine("Please enter an amount within your balance: {0}", transactions.GetBalance(custID, acctID));
                                        else
                                        {
                                            transactions.Withdraw(custID, acctID, amountValue);
                                            Console.WriteLine("You have successfully withdrawn {0} from your {1} account.", amountValue, accounts.GetAccountTypeByID(acctID));
                                            Console.WriteLine("Your current balance in your {0} account is: {1}", accounts.GetAccountTypeByID(acctID), transactions.GetBalance(custID, acctID));
                                        }
                                    }
                                    else
                                        Console.WriteLine("Please enter a proper amount value.");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter an amount to deposit:");
                                    string depositAmount = Console.ReadLine();
                                    bool checkDepositAmount = double.TryParse(depositAmount, out double depositAmountValue);
                                    if (checkDepositAmount)
                                    {
                                        if (depositAmountValue < 0)
                                            Console.WriteLine("Please enter a valid amount value.");
                                        else
                                        {
                                            transactions.Deposit(custID,acctID,depositAmountValue);
                                            Console.WriteLine("You have successfully deposited {0} in your {1} account.", depositAmountValue, accounts.GetAccountTypeByID(acctID));
                                            Console.WriteLine("Your current balance in your {0} account is: {1}", accounts.GetAccountTypeByID(acctID), transactions.GetBalance(custID,acctID));
                                        }
                                    }
                                    else
                                        Console.WriteLine("Please enter a proper amount value.");
                                    break;
                                case 4:
                                    SelectAccountMenu(custID);
                                    break;
                                case 5:
                                    accountMenuFlag = false;
                                    selectAcctMenuFlag = false;
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Please select a value from 1 to 5.");
                                    break;
                            }
                        }
                        else
                            Console.WriteLine("Please enter a value from the given options");

                    } while (accountMenuFlag);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
            }

            void SelectAccountMenu(int custID)
            {
                do
                {
                    Console.WriteLine("Select Account Menu: \n1. {0} \n2. {1} \n3. {2} \n4. Get All Account Balances \n5. Main Menu", AccountType.Checking, AccountType.Savings, AccountType.Loan);
                    string selectAcctMenuInput = Console.ReadLine();
                    bool selectAcctMenuInputCheck = int.TryParse(selectAcctMenuInput, out int selectAcctMenuInputInteger);

                    if (selectAcctMenuInputCheck)
                    {
                        int acctID;
                        switch (selectAcctMenuInputInteger)
                        {
                            case 1:
                                acctID = (int)AccountType.Checking;
                                AccountMenu(custID, acctID);
                                break;
                            case 2:
                                acctID = (int)AccountType.Savings;
                                AccountMenu(custID, acctID);
                                break;
                            case 3:
                                acctID = (int)AccountType.Loan;
                                AccountMenu(custID, acctID);
                                break;
                            case 4:
                                transactions.DisplayAllBalances(transactions.GetAllAccountBalances(custID));
                                break;
                            case 5:
                                MainMenu(custID);
                                selectAcctMenuFlag = false;
                                break;
                            default:
                                Console.WriteLine("Please enter a value between 1 to 5.");
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Please enter a value from the given options.");

                } while (selectAcctMenuFlag);
            }

            void SelectTransactionMenu(int custID)
            {
                do
                {
                    Console.WriteLine("Select the account to retrieve transactions: \n1. Checking \n2. Savings \n3. Loan \n4. Get All Transactions \n5. Main Menu ");
                    string selectTransInput = Console.ReadLine();

                    bool selectTransInputCheck = int.TryParse(selectTransInput, out int selectTransInputInteger);

                    if (selectTransInputCheck)
                    {
                        switch (selectTransInputInteger)
                        {
                            case 1:
                                transactions.DisplayTransactions(transactions.GetTransactionsByID(custID, 1));
                                continue;
                            case 2:
                                transactions.DisplayTransactions(transactions.GetTransactionsByID(custID, 2));
                                continue;
                            case 3:
                                transactions.DisplayTransactions(transactions.GetTransactionsByID(custID, 3));
                                continue;
                            case 4:
                                transactions.DisplayTransactions(transactions.GetAllTransaction(custID));
                                continue;
                            case 5:
                                MainMenu(custID);
                                mainMenuFlag = false;
                                transMenuFlag = false;
                                selectAcctMenuFlag = false;
                                accountMenuFlag = false;
                                break;
                            default:
                                Console.WriteLine("Please enter a value from the given options.");
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Please select a value from the given options.");
                } while (transMenuFlag);
            }
        }
    }
}
