using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    public enum AccountType { Chequings, Savings };
    public class Account
    {

        public int Number { get; private set; }
        public float Amount { get; set; }
        public AccountType Type { get; private set; }
        public List<String> History { get; private set; }

        public Account ( int num, AccountType type )
        {
            Number = num;
            Amount = 0;
            Type = type;
            History = new List<String>();
        }

        public void deposit(float delta, string date)
        {
            this.Amount = this.Amount + delta;
            if (this.Amount < 0) { throw new Exception("Insufficient funds"); }
            History.Add(string.Format("Deposited ${0} on {1}", delta, date));
        }

        public void withdraw(float delta, string date)
        {
            this.Amount = this.Amount - delta;
            if (this.Amount < 0) { throw new Exception("Insufficient funds"); }
            History.Add(string.Format("Withdrew ${0} on {1}", delta, date));
        }

        public void transferTo(float delta, Account accnt, string date)
        {
            this.withdraw(delta, date) ; accnt.deposit(delta, date); 
        }
    }
}
