using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMachine.Account; 

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
        }

        public void addPerson (Person a) { People.Add(a); }

        public Person lookupAccntNum (int num) {
            return People.Find(p => p.AccountNumber == num);
        }

    }
}
 