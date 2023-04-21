using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9_
{
    public class CreditCard
    {
        public int CardNumber { get; set; }
        public string CardOwnerName { get; set; }
        public string ExpirationDate { get; set; }
        public int Pin { get; set; }
        public int CreditLimit { get; set; }
        public int Balance { get; set; }

        public void AddMoney(int amount)
        {
            Balance += amount;
        }

        public void SpendMoney(int amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient money");
            }
        }

        public void StartCredit()
        {
            if (Balance == 0)
            {
                Balance = CreditLimit;
            }
            else
            {
                Console.WriteLine("Credit already in use");
            }
        }

        public void ChangePin(int newPin)
        {
            Pin = newPin;
        }
        public void Show()
        {
            Console.WriteLine("\nInfo:\nCard number: " + CardNumber);
            Console.WriteLine("Card owner name: " + CardOwnerName);
            Console.WriteLine("Expiration date: " + ExpirationDate);
            Console.WriteLine("PIN: " + Pin);
            Console.WriteLine("Credit limit: " + CreditLimit);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
