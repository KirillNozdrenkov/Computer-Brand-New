using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceGoods
{
    internal class CurrencyTable : Currency
    {
        public static readonly Dictionary<Type, double> CurrencyToDollarTable = new Dictionary<Type, double>()
        {
            {typeof (AmericanDollar), 1},
            {typeof (RussianRuble), 50},
            {typeof (BelarusianRuble), 15000}
        };
    }
}
