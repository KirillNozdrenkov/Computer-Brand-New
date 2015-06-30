using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarplata
{
    class FixedPayEmployee : Employee
    {
        public FixedPayEmployee(int id, string name, double paytype)
        {
            Id = id;
            Name = name;
            PayType = paytype;
        }
        public override double CountPay()
        {
            return PayType*DaysWorks;
        }
    }
}
