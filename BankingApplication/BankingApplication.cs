using BankingApplication_BO;
using BankingApplication_BLL;
using System;
using System.Collections.Generic;

namespace BankingApplication
{
    class BankingApplication
    {
        //enum AccountType { Checking, Savings, Loan };
        enum AccountFunc { Balance, Withdraw, Deposit }
        static void Main(string[] args)
        {

            //Main Menu Please select account, 1: checking 2: saving 3: loan 4: Get all Account balances 5 exit
            // Account Menu 1: get balance 2: deposit 3: withdraw 4: main menu  5: exit
            //1 - print balance and account menu
            //2 - take amount and acount menu

            Accounts_BLL accounts = new Accounts_BLL();
            Transactions_BLL transactions = new Transactions_BLL();
            Customers_BLL customers = new Customers_BLL();
            
            //List<bool> flagList = new List<bool>();
            //for(int i = 0; i<4; i++)
            //    flagList.Add(true);
            //Console.WriteLine(flagList[1]);

            bool selectAcctMenuFlag = true;
            bool mainMenuFlag = true;
            bool accountMenuFlag = true;
            bool transMenuFlag = true;
            bool custFlag = true;
            bool checkCustFlag = true;
            CustomerMenu();

            void CustomerMenu()
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
                            Console.WriteLine("Welcome to our Banking Application. You have successfully logged in.");
                            MainMenu();
                            custFlag = false;
                        }
                            
                        else
                        {
                            Console.WriteLine("Your customer ID is not found. Please try again.");
                            
                        }
                            
                    }
                } while (custFlag);
            }

            void MainMenu()
            {
                try
                {
                    do
                    {
                        //Also include transaction 1 Accounts 2: transaction exit
                        //if 2 - which account transaction 1:checking 2: loan 3: saving 
                        Console.WriteLine("Main Menu:\n1. Accounts \n2. Transactions \n3. Log Out");
                        string mainMenuInput = Console.ReadLine();

                        //Console.WriteLine("Main Menu: \n1. {0} \n2. {1} \n3. {2} \n4. Get All Account Balances \n5. Exit", AccountType.Checking, AccountType.Savings, AccountType.Loan);
                        //string mainMenuInput = Console.ReadLine();

                        bool mainMenuInputCheck = int.TryParse(mainMenuInput, out int mainMenuInputInteger);


                        if (mainMenuInputCheck)
                        {
                            switch (mainMenuInputInteger)
                            {
                                case 1:
                                    SelectAccountMenu();
                                    break;
                                case 2:
                                    SelectTransactionMenu();
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

            void AccountMenu(AccountType acctType)
            {
                try
                {


                    do
                    {

                        Console.WriteLine("Account Menu: \n1. Get Balance \n2. Withdraw \n3. Deposit \n4. Select Account Menu \n5. Exit");
                        string accountMenuInput = Console.ReadLine();

                        bool accountMenuInputCheck = int.TryParse(accountMenuInput, out int accountMenuInputInteger);

                        if (accountMenuInputCheck)
                        {
                            switch (accountMenuInputInteger)
                            {
                                case 1:
                                    Console.WriteLine("Your {0} account balance is: {1}", acctType, accounts.GetBalance(acctType));
                                    break;
                                case 2:
                                    Console.WriteLine("Enter an amount to withdraw:");
                                    string amount = Console.ReadLine();
                                    bool checkAmount = double.TryParse(amount, out double amountValue);
                                    if (checkAmount)
                                    {
                                        if (accounts.GetBalance(acctType) - amountValue < 0)
                                            Console.WriteLine("Please enter an amount within your balance: {0}", accounts.GetBalance(acctType));
                                        else
                                        {
                                            accounts.Withdraw(amountValue, acctType);
                                            
                                            Console.WriteLine("You have successfully withdrawn {0} from your {1} account.", amountValue, acctType);
                                            Console.WriteLine("Your current balance in your {0} account is: {1}", acctType, accounts.GetBalance(acctType));
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
                                            accounts.Deposit(depositAmountValue, acctType);
                                            Console.WriteLine("You have successfully deposited {0} in your {1} account.", depositAmountValue, acctType);
                                            Console.WriteLine("Your current balance in your {0} account is: {1}", acctType, accounts.GetBalance(acctType));
                                        }

                                    }
                                    else
                                        Console.WriteLine("Please enter a proper amount value.");
                                    break;
                                case 4:
                                    SelectAccountMenu();
                                    break;
                                case 5:
                                    mainMenuFlag = false;
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

            void SelectAccountMenu()
            {
                do
                {
                    Console.WriteLine("Select Account Menu: \n1. {0} \n2. {1} \n3. {2} \n4. Get All Account Balances \n5. Main Menu \n6. Exit", AccountType.Checking, AccountType.Savings, AccountType.Loan);
                    string selectAcctMenuInput = Console.ReadLine();
                    bool selectAcctMenuInputCheck = int.TryParse(selectAcctMenuInput, out int selectAcctMenuInputInteger);

                    if (selectAcctMenuInputCheck)
                    {
                        switch (selectAcctMenuInputInteger)
                        {
                            case 1:
                                AccountMenu(AccountType.Checking);
                                break;
                            case 2:
                                AccountMenu(AccountType.Savings);
                                break;
                            case 3:
                                AccountMenu(AccountType.Loan);
                                break;
                            case 4:
                                GetAllBalances();
                                break;
                            case 5:
                                MainMenu();
                                selectAcctMenuFlag = false;
                                break;
                            case 6:
                                mainMenuFlag = false;
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

            void SelectTransactionMenu()
            {

                do
                {
                    Console.WriteLine("Select the account to retrieve transactions: \n1. Checking \n2. Savings \n3. Loan \n4. Main Menu \n5. Exit");
                    string selectTransInput = Console.ReadLine();

                    bool selectTransInputCheck = int.TryParse(selectTransInput, out int selectTransInputInteger);

                    if (selectTransInputCheck)
                    {
                        switch (selectTransInputInteger)
                        {
                            case 1:
                                transactions.displayTransactions(transactions.GetTransactions(AccountType.Checking), AccountType.Checking);
                                break;
                            case 2:
                                transactions.displayTransactions(transactions.GetTransactions(AccountType.Savings), AccountType.Savings);
                                break;
                            case 3:
                                transactions.displayTransactions(transactions.GetTransactions(AccountType.Loan), AccountType.Loan);
                                break;
                            case 4:
                                MainMenu();
                                mainMenuFlag = false;
                                transMenuFlag = false;
                                selectAcctMenuFlag = false;
                                accountMenuFlag = false;
                                break;
                            case 5:
                                selectAcctMenuFlag = false;
                                accountMenuFlag = false;
                                transMenuFlag = false;
                                mainMenuFlag = false;
                                Console.ReadKey();
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

            void GetAllBalances()
            {
                Console.WriteLine("Your checking account balance is: {0}", accounts.GetBalance(AccountType.Checking));
                Console.WriteLine("Your savings account balance is: {0}", accounts.GetBalance(AccountType.Savings));
                Console.WriteLine("Your loan account balance is: {0}", accounts.GetBalance(AccountType.Loan));
            }

            
        }


    }
}
