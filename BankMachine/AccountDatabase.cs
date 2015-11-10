using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    class AccountDatabase
    {

        public List<Person> People { get; set; }

        public AccountDatabase()
        {
            People = new List<Person>(); 
        }
        public void addPerson (Person a) { People.Add(a); }

        public Person lookupAccntNum (int num) {
            return People.Find(p => p.AccountNumber == num);
        }

    }
}
 