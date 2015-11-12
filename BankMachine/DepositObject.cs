using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    public class DepositObject
    {
        public float value;
        public string type;
        public string meta;
        public DepositObject(float v, string t, string m)
        {
            value = v; type = t; meta = m;
        }
        public override string ToString()
        {
            switch (type)
            {
                case "Cheque":
                    return "Cheque for $" + value.ToString("0.00") + " from " + meta;
                case "Cash":
                    return "Cash: $" + value.ToString("0");
                default:
                    return String.Format("{0,-20}{1,-20}{2,-20}", type, value.ToString("$0.00"), meta);
            }
        }
    }
}
