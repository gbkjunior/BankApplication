using BankingApplication_BO;
using BankingApplication_BLL;
using System;

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

            


            MainMenu();


            void MainMenu()
            {
                try
                {
                    do
                    {
                        //Also include transaction 1 Accounts 2: transaction exit
                        //if 2 - which account transaction 1:checking 2: loan 3: saving 

                        Console.WriteLine("Main Menu: \n1. {0} \n2. {1} \n3. {2} \n4. Get All Account Balances \n5. Exit", AccountType.Checking, AccountType.Savings, AccountType.Loan);
                        string mainMenuInput = Console.ReadLine();

                        bool mainMenuInputCheck = int.TryParse(mainMenuInput, out int mainMenuInputInteger);
                        if (mainMenuInputCheck)
                        {
                            if (mainMenuInputInteger == 5)
                            {
                                Console.ReadKey();
                                break;
                            }
                            if (mainMenuInputInteger > 5 || mainMenuInputInteger < 1)
                            {
                                Console.WriteLine("Please select a value from 1 to 5. \n");
                                
                            }
                            else if (mainMenuInputInteger == 1)
                            {

                                AccountMenu(AccountType.Checking);

                            }
                            else if (mainMenuInputInteger == 2)
                            {

                                AccountMenu(AccountType.Savings);
                            }
                            else if (mainMenuInputInteger == 3)
                            {

                                AccountMenu(AccountType.Loan);
                            }
                            else if (mainMenuInputInteger == 4)
                            {
                                Console.WriteLine("Your checking account balance is: {0}", accounts.GetBalance(AccountType.Checking));
                                Console.WriteLine("Your savings account balance is: {0}", accounts.GetBalance(AccountType.Savings));
                                Console.WriteLine("Your loan account balance is: {0}", accounts.GetBalance(AccountType.Loan));
                                MainMenu();
                            }
                        }
                        else
                            Console.WriteLine("Please enter a value from the given options");

                        
                    } while (true);
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
                        Console.WriteLine("Account Menu: \n1. Get Balance \n2. Withdraw \n3. Deposit \n4. Main Menu \n5. Exit");
                        string accountMenuInput = Console.ReadLine();

                        bool accountMenuInputCheck = int.TryParse(accountMenuInput, out int accountMenuInputInteger);
                        if (accountMenuInputCheck)
                        {
                            if (accountMenuInputInteger == 5)
                            {
                                Console.ReadKey();
                                break;
                            }
                            if (accountMenuInputInteger > 5 || accountMenuInputInteger < 1)
                            {
                                Console.WriteLine("Please select a value from 1 to 5. \n");
                                
                            }
                            else if (accountMenuInputInteger == 1)
                            {

                                Console.WriteLine("Your {0} account balance is: {1}", acctType,accounts.GetBalance(acctType));
                                
                            }
                            else if (accountMenuInputInteger == 2)
                            {
                                Console.WriteLine("Enter an amount to withdraw:");
                                string amount = Console.ReadLine();
                                bool checkAmount = double.TryParse(amount, out double amountValue);
                                if (checkAmount)
                                {
                                    if (accounts.GetBalance(acctType) - amountValue < 0)
                                    {
                                        Console.WriteLine("Please enter an amount within your balance: {0}", accounts.GetBalance(acctType));
                                        
                                    }
                                    else
                                    {
                                        accounts.Withdraw(amountValue,acctType);
                                        
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Please enter a proper amount value.");
                                    
                                }
                            }
                            else if (accountMenuInputInteger == 3)
                            {
                                Console.WriteLine("Enter an amount to deposit:");
                                string amount = Console.ReadLine();
                                bool checkAmount = double.TryParse(amount, out double amountValue);
                                if (checkAmount)
                                {
                                    if (amountValue < 0)
                                    {
                                        Console.WriteLine("Please enter a valid amount value.");
                                        
                                    }
                                    else
                                    {
                                        accounts.Deposit(amountValue,acctType);
                                        
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Please enter a proper amount value.");
                                    
                                }
                            }
                            else if (accountMenuInputInteger == 4)
                            {
                                MainMenu();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a value from the given options");
                            
                        }
                        //AccountMenu(acctType);
                    } while (true);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
            }


        }


    }
}
