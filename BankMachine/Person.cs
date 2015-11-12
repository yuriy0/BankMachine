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
        public string AccountNumber { get; private set; }
        public string PIN { get; set; }
        public List<Account> Accounts { get; private set; }
        public int NumPinAttempts { get; private set; }

        public static int MaxPinAttempts = 3;

        private string lastReceipt = "";

        public string LastReceipt { get { return lastReceipt; } }

        public Person(string name, string number, string pin)
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

        public void withdrawFrom(float delta, int i) { withdrawFrom(delta, i);  }

        public void withdrawFrom(float delta, int i, DateTime date)
        {
            if (i < Accounts.Count)
            {
                Accounts[i].withdraw(delta, date);
                lastReceipt = String.Format("User: {0}\nAccount #{1}\n{2} account:\n\tCash withdrawl: -${3}.00\n\tBalance: ${4}"
                                   , Name, AccountNumber, Accounts[i].Type, delta, Accounts[i].Amount);
                
            } else
            {
                throw new Exception(string.Format("account #{0} does not exist", i, Name));
            }
        }

        public void depositMany(List<DepositObject> deps, int to, DateTime date)
        {
            if (to < Accounts.Count)
            {
                lastReceipt = String.Format("User: {0}\nAccount #{1}\nDeposited to {2} account:"
                                   , Name, AccountNumber, Accounts[to].Type);
                foreach (DepositObject d in deps)
                {
                    Accounts[to].deposit(d.value, date);
                    lastReceipt += "\n  " + d.ToString();
                }
                lastReceipt += "\n====\nFinal balance: $" + Accounts[to].Amount.ToString("0.00");
            } else
            {
                throw new Exception(string.Format("account #{0} does not exist", to, Name));
            }
        }
        public void depositMany(List<DepositObject> deps,int to)
        {
            depositMany(deps, to, DateTime.Now);
        }

        public void transferBetween(float delta, int from, int to) { transferBetween(delta, from, to);  }

        public void transferBetween(float delta, int from, int to, DateTime date)
        {
            if (from >= Accounts.Count)
            { throw new Exception(string.Format("account #{0} does not exist", from, Name)); }

            if (to >= Accounts.Count)
            { throw new Exception(string.Format("account #{0} does not exist", to, Name)); }

            Accounts[from].withdraw(delta, date);
            Accounts[to].deposit(delta, date);

            lastReceipt = String.Format("User: {0}\nAccount #{1}\nTransfer from {2} to {3} accounts:\n\tTransfer amount: ${4}.00\n\tBalance in {2}: ${5}\n\tBalance in {3}: ${6}"
                               , Name, AccountNumber, Accounts[from].Type, Accounts[to].Type,
                                 delta, Accounts[from].Amount, Accounts[to].Amount);
            

        }
    }
}
