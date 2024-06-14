using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Banking
{
    internal class Program
    {
        public static List<BankingInfo> bankInfo = new List<BankingInfo>();
        static void Main(string[] args)
        {
            BankingInfo bankingInfo = new BankingInfo();

            bankInfo.Add(new BankingInfo { AccountId = 1, Balance = 0, Description = "Checking" });
            bankInfo.Add(new BankingInfo { AccountId = 2, Balance = 0, Description = "Checking" });

            Console.WriteLine("Please type out a command for example (Deposit 100): ");
            string firstInput = Console.ReadLine();
            string[] splitInput = firstInput.Split(" ");
            string Command = splitInput[0];
            string amount = splitInput[1];

            while (true)
            {
                Console.Write("What would you like to do Deposit, Withdraw, Current Balance, transfer, or if your all done please enter exit?: ");
                string userInput = Console.ReadLine();

                switch (Command.ToLower())
                {
                    case "deposit":

                        bankingInfo.Deposit();
                        break;

                    case "withdraw":
                        bankingInfo.Withdraw();
                        break;

                    case "current balance":
                        bankingInfo.curBalance();
                        break;
                    case "transfer":
                        bankingInfo.Transfer();
                        break;

                }
                if (userInput.ToLower() == "exit")
                {
                    break;
                }
            }




        }
    }

}

   //Console.Write("What is the account ID you would like to transfer to: ");
                        //string transferId = Console.ReadLine();

                        //int endTransferId = Convert.ToInt32(transferId);

                        //foreach (BankingInfo otherIdBankingInfo in bankInfo)
                        //{
                        //    int otherId = otherIdBankingInfo.AccountId;

                        //    if (otherIdBankingInfo.AccountId == otherId)
                        //    {
                        //        Console.Write($"Okay how much would you like to transfer your balance is {bankingInfo.Balance}: ");
                        //        string transferAmountString = Console.ReadLine();

                        //        int transferAmt = Convert.ToInt32(transferAmountString);

                        //        otherIdBankingInfo.Balance = transferAmt;

                        //        Console.WriteLine("Money Transfered");
                        //        //Console.WriteLine($"Other Account balance {otherIdBankingInfo.Balance}");
                        //        break;
                        //    }
                        //}