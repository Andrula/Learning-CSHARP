using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class BankAccount
    {
        public string accountNumber { get; set; }  
        public string accountOwner { get; set; }
        public string accountPassword { get; set; }
        public decimal accountBalance { get; set; }

        private static int accountNumberSeed = 1234567890;

        public BankAccount(string name,decimal initialBalance)
        {
            this.accountOwner = name;
            this.accountBalance = initialBalance;
            this.accountNumber = accountNumberSeed.ToString();
            accountNumberSeed++;
        }



    }
}
