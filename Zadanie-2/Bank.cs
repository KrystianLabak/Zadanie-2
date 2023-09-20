using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class BankAccount
    {
        private decimal Balance;

        public BankAccount(decimal startBalance)
        {
            Balance = startBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Wpłata nie może być ujemna.");
            }
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <  0)
            {
                Console.WriteLine("Wypłata nie może być ujemna.");
            }
            if (amount > Balance)
            {
                Console.WriteLine("Brak środków do wypłaty.");
            }

        }
    }
}
