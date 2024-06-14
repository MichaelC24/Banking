using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class BankingInfo
    {
        public int AccountId { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
//----------------------------------------------------//
//---------------Methods------------------------------//
//----------------------------------------------------//
        public void Deposit()
        {
            decimal deposit = 0;

            while (true)
            {
                Console.Write($"How much would you like to deposit here is the current balance {Balance}: ");
                string userInput = Console.ReadLine();

                if (deposit < 0)
                {
                    Console.WriteLine("You can only deposit a positive number into your account please only enter a positive number.");
                }
                else
                {
                    deposit = Convert.ToInt32(userInput);
                    Balance += deposit;
                    break;
                }
            }
            Console.WriteLine($"Here is your current balance: {Balance}");
        }
        public void Withdraw()
        {
            decimal withdraw = 0;


            while (true)
            {
                Console.Write($"How much would you like to withdraw this is your current balance {Balance}: ");
                string userInput = Console.ReadLine();

                if (withdraw > Balance)
                {
                    Console.WriteLine("The withdraw is greater than the balance please enter a number less than your balance.");
                }
                else
                {
                    withdraw = Convert.ToInt32(userInput);
                    Balance -= withdraw;
                    break;
                }
            }
            Console.WriteLine($"Here is your current balance: {Balance}");
        }
        public void curBalance()
        {
            Console.WriteLine($"Here is your current Balance {Balance}");
        }
        public void Transfer()
        {
            //BankingInfo bankingInfo = new BankingInfo();
            Program program = new Program();

            Console.Write("What is the account ID you would like to transfer to: ");
            string transferId = Console.ReadLine();

            int endTransferId = Convert.ToInt32(transferId);

            foreach (BankingInfo otherIdBankingInfo in Program.bankInfo)
            {
                int otherId = otherIdBankingInfo.AccountId;

                if (otherIdBankingInfo.AccountId == otherId)
                {
                    Console.Write($"Okay how much would you like to transfer your balance is {Balance}: ");
                    string transferAmountString = Console.ReadLine();

                    int transferAmt = Convert.ToInt32(transferAmountString);

                    otherIdBankingInfo.Balance = transferAmt;

                    Console.WriteLine($"Money Transfered your balance is: {Balance - transferAmt}");
                    //Console.WriteLine($"Other Account balance {otherIdBankingInfo.Balance}");
                    break;
                }
            }

        }
    }
}
