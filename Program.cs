using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(DateTime.Now.Day);
            
            string dt= date1.Day.ToString();
            
            int dailydeposit = 0;
           int dailywithdraw = 0;
            int Balance = 0;
            int count = 0;
            int countwithdraw = 0;
            //Itreate the Program
            for (int i = 0; i <99999999; i++)
            {



                //Landing Page
                Console.WriteLine("Please Select Service");
                Console.WriteLine("1. Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. QUIT");

                //Read User Input on Service
                string option;
                try
                {
                    option = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("I only accept Strings");
                    throw;
                }

                //decision Based on user
                if (option == "1")
                {
                    //Call a function to display Balance in the class Balance
                    Balance bal1 = new Balance();
                    bal1.ShowBalance(Balance);
                }
                if (option == "2")
                {
                    //Introducing a count for no. of deposits daily
                   

                    //Check If it is a new day
                    DateTime date2 = new DateTime(DateTime.Now.Day);
                    string dtn = date2.Day.ToString();

                    if (dtn == dt)
                    {
                        //Incrementing Count
                        count = count + 1;
                    }

                    // Reset Daily parameters
                    else
                    {

                        dt = dtn;
                        dailydeposit = 0;
                        count = 0;

                    }
                    //Enforce Transaction Times rule
                    if (count < 4)
                    {
                        //Get Amount to deposit
                        Console.WriteLine("Enter Amount to Deposit" + "NOTE MAX DEPOSIT IS Ksh 40,000");
                        string depositamount = Console.ReadLine();
                        int depositamountint;
                        try
                        {
                            depositamountint = int.Parse(depositamount);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("I can Only accept Integers");
                            throw;
                        }

                        //Enforce Max Deposit Amount Rule

                        if (dailydeposit < 150001)
                        {
                            //Enforce Max Transaction Rule
                            if (depositamountint < 40001)
                            {
                                //call a function to deposit the said Amount
                                Deposit depositMoney = new Deposit();
                                Balance = depositMoney.DepositAmount(depositamountint, Balance);

                                Console.WriteLine("Ksh " + depositamount + "Has Been Deposited:");
                                Console.WriteLine("Your Balance is Ksh:" + Balance);
                                dailydeposit = dailydeposit + depositamountint;
                                Console.ReadLine();
                            }
                            else Console.WriteLine("Maximum Deposit Per Transacrion is Ksh 40,000");
                        }

                        else Console.WriteLine("You have reached maximum deposit of 150K");
                    }

                    else Console.WriteLine("Maximum Deposit Per Day is 4 times");


                }
                if (option == "3")
                {
               
                  
                    //Check If it is a new day
                    DateTime date3 = new DateTime(DateTime.Now.Day);
                    string dtnw = date3.Day.ToString();

                    if (dt == dtnw)
                    {
                        //Increment Countwithdraw
                        countwithdraw = countwithdraw + 1;
                    }
                    
                    else
                    {
                        //reset day
                        dt = dtnw;
                        dailywithdraw = 0;
                        countwithdraw = 0;

                    }
                    //enforce max no. of withdraws daily
                    if (countwithdraw < 3)
                    {
                        //Get Amount to Withdraw
                        Console.WriteLine("Enter Amount to Withdraw" + "NOTE MAX Withdrawal IS Ksh20,000");
                        string withdrawamount = Console.ReadLine();
                        int withdrawamountint;
                        try
                        {
                            withdrawamountint = int.Parse(withdrawamount);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("I can Only accept Integers");
                            throw;
                        }

                        //enforce max amount rule

                        if (dailywithdraw < 50001)
                        {
                            //enforce max transaction rule
                            if (withdrawamountint < 20001)
                            {
                                //logic to ensure you cannot withdraw more than you have
                                if (Balance >= withdrawamountint)
                                {
                                    //call a function to deposit the said Amount
                                    Withdraw withdrawmoney = new Withdraw();
                                    Balance = withdrawmoney.WithdrawAmount(withdrawamountint, Balance);

                                    Console.WriteLine("Ksh " + withdrawamountint + "Has Been Withdrawn:");
                                    Console.WriteLine("Your Balance is Ksh:" + Balance);
                                    dailywithdraw = dailywithdraw + withdrawamountint;
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("You Have Insufficient Funds");
                                    Console.WriteLine("Your Balance is Ksh:" + Balance);
                                }
                            }
                            else Console.WriteLine("Maximum Allowed Amount Per Transacrion is Ksh 20,000");
                        }

                        else Console.WriteLine("You have reached maximum Withdraw of 50K");
                    }

                    else Console.WriteLine("Maximum Withdaw time Per Day is 3 times");

                }
                if (option == "4")
                {// propmpt user
                    Console.WriteLine("Are You Sure You want to quite");
                    Console.WriteLine("Press 1. Yes");
                    Console.WriteLine("Press 2. No");
                    String QuiteOption;
                    try
                    {
                        QuiteOption = Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Strictly Press 1 or 2");
                        throw;
                    }
                   
                    if (QuiteOption == "1")
                    {
                        //Clear all Information
                        System.GC.Collect();
                        //exit Console
                        Environment.Exit(0);
                    }

                    if (QuiteOption == "2")
                    {
                        Console.ReadKey();
                    }
                    else Console.WriteLine("Invalid choice");
                }
                else Console.WriteLine("LOADING...");
            }
        }
    }
}
