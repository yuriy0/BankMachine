using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    public class Person
    {
        public string Name { get; private set; }
        public int AccountNumber { get; private set; }
        public string PIN { get; set; }
        public List<Account> Accounts { get; private set; }
        public int NumPinAttempts { get; private set; }

        public static int MaxPinAttempts = 3;

        private string lastReceipt = "";

        public string LastReceipt { get { return lastReceipt; } }

        public Person(string name, int number, string pin)
        {
            Name = name;
            AccountNumber = number;
            PIN = pin;
            Accounts = new List<Account>();
        }

        public void addAccount (Account a) {
            Accounts.Add(a);
        }

        public bool guessPIN(string guess)
        {
            if (guess != PIN) { NumPinAttempts++; return false; }
            return true; 
        }

        public void withdrawFrom(float delta, int i, string date)
        {
            if (i < Accounts.Count)
            {
                Accounts[i].withdraw(delta, date);
                lastReceipt = String.Format("User: {0}\nAccount #{1}\n{2} account:\n\tCash withdrawl: -${3}.00\n\tBalance: ${4}"
                               , Name,AccountNumber,Accounts[i].Type,delta,Accounts[i].Amount);
            } else
            {
                throw new Exception(string.Format("account #{0} does not exist", i, Name));
            }
        }
    }
}
