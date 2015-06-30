using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarplata
{
    abstract class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double PayType { get; set; }
        public abstract double CountPay();
        public double DaysWorks = 20.8;
        public int HourWorkInDay = 8;
        //test data
    }
}
