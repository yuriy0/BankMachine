using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    public enum AccountType { Chequings, Savings };

    public class HistoryEntry
    {
        public DateTime time;
        public float delta;
        public string comment; 
        public HistoryEntry(DateTime _time, float _delta, string _comment)
        {
            time = _time; delta = _delta; comment = _comment;
        }
        public override string ToString() {
            return String.Format("{3}{0} on {1}{2}",delta.ToString("0.00"), time.ToShortDateString(), 
                comment==""?"":"("+comment+")",
                delta<0 ? "-" : "");
        }
    }

    public class Account
    {

        public int Number { get; private set; }
        public float Amount { get; set; }
        public AccountType Type { get; private set; }
        public List<HistoryEntry> History { get; private set; }

        public Account ( int num, AccountType type )
        {
            Number = num;
            Amount = 0;
            Type = type;
            History = new List<HistoryEntry>();
        }

        public void deposit(float delta, DateTime date)
        {
            float newAmount = this.Amount + delta;
            if (newAmount < 0) { throw new Exception("you have insufficient funds"); }
            this.Amount = newAmount;
            History.Add(new HistoryEntry(date, delta, "deposit"));
        }

        public void deposit(float delta)
        {
            deposit(delta, DateTime.Now);
        }

        public void withdraw(float delta, DateTime date)
        {
            float newAmount = this.Amount - delta;
            if (newAmount < 0) { throw new Exception("you have insufficient funds"); }
            this.Amount = newAmount;
            History.Add(new HistoryEntry(date, delta, "withdrawal"));
        }

        public void withdraw(float del) { withdraw(del, DateTime.Now);  }

        public void transferTo(float delta, Account accnt, DateTime date)
        {
            this.withdraw(delta, date) ; accnt.deposit(delta, date); 
        }

        public void transferTo(float delta, Account accnt) 
          { transferTo(delta, accnt, DateTime.Now); }

    }
}
