using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    public class Account
    {
        public enum AccountType {Chequings,Savings};

        public int Number { get; private set; }
        public float Amount { get; set; }
        public AccountType Type { get; private set; } 

        public Account ( int num, AccountType type )
        {
            Number = num;
            Amount = 0;
            Type = type;
        }

        public void deposit(float delta)
        {
            this.Amount = this.Amount + delta;
            if (this.Amount < 0) { throw new Exception("Insufficient funds"); }
        }

        public void withdraw(float delta)
        {
            deposit(-delta);
        }

        public void transferTo(float delta, Account accnt)
        {
            this.withdraw(delta) ; accnt.deposit(delta); 
        }
    }
}
