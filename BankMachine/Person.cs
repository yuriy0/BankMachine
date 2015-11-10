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
        public int PIN { get; set; }
        public List<Account> Accounts { get; private set; }

        public Person(string name, int number, int pin)
        {
            Name = name;
            AccountNumber = number;
            PIN = pin;
            Accounts = new List<Account>();
        }

        public void addAccount (Account a) {
            Accounts.Add(a);
        }

        public void withdrawFrom(float delta, int i, string date)
        {
            if (Accounts.Count < i)
            {
                Accounts[i].withdraw(delta, date);
            } else
            {
                throw new Exception(string.Format("Account {0} does not exist for {1}", i, Name));
            }
        }
    }
}
