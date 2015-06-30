using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarplata
{
    class HourlyPayEmployee : Employee
    {
        public HourlyPayEmployee(int id, string name, double paytype)
        {
            Id = id;
            Name = name;
            PayType = paytype;
        }
        public override double CountPay()
        {
            return DaysWorks*HourWorkInDay*PayType;
        }
    }
}
