using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    public class AccountDatabase
    {
        public List<Person> People { get; set; }

        public AccountDatabase()
        {
            People = new List<Person>(); 
            // People.Add (new Person ("Yuriy"))
        }

        public void initDefault()
        {
            var a0 = new Account(2345234, AccountType.Chequings);
            a0.deposit(400.00f, "June 8th 2015");

            var a1 = new Account(9954, AccountType.Savings);
            a1.deposit(63.32f, "July 4th 2015");

            var p0 = new Person("Yuriy", "0", "0");
            p0.addAccount(a0); p0.addAccount(a1);
            People.Add(p0);
        }

        public void addPerson (Person a) { People.Add(a); }

        public Person lookupAccntNum (string num) {
            return People.Find(p => p.AccountNumber == num);
        }

    }
}
 