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
        public List<Account> Accounts { get; private set; }

        public Person(string name, int number)
        {
            Name = name;
            AccountNumber = number;
        }

        public void addAccount (Account a) {
            Accounts.Add(a);
        }

        public void withdrawFrom(float delta, int i)
        {
            if (Accounts.Count < i)
            {
                Accounts[i].withdraw(delta);
            } else
            {
                throw new Exception(string.Format("Account {0} does not exist for {1}", i, Name));
            }
        }
    }
}
