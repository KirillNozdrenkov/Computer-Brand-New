using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PriceGoods
{
    public class Price
    {
        public double Value { get; set; }
        public Currency Currency { get; set; }
        public Price Add(Price price)
        {
            if (Currency.GetType() == price.Currency.GetType())
            {
                return new Price()
                {
                    Value = this.Value + price.Value,
                    Currency = this.Currency
                };
            }
            else
            {
                var firstPriceCurrencyToDollar = CurrencyTable.CurrencyToDollarTable[Currency.GetType()];
                var firstPriceInDollars = this.Value / firstPriceCurrencyToDollar;
                var secondPriceInDollar = price.Value / CurrencyTable.CurrencyToDollarTable[price.Currency.GetType()];
                var sumPriceInDollar = firstPriceInDollars + secondPriceInDollar;
                return new Price()
                {
                    Value = sumPriceInDollar * firstPriceCurrencyToDollar,
                    Currency = this.Currency
                };
            }
        }

        public static Price operator +(Price firstPrice, Price secondPrice)
        {
            return new Price() {Value = firstPrice.Value + secondPrice.Value};
        }

        public static Price operator -(Price firstPrice, Price secondPrice)
        {
            return new Price() { Value = firstPrice.Value - secondPrice.Value };
        }
        public static Price operator *(Price firstPrice, Price secondPrice)
        {
            return new Price() { Value = firstPrice.Value * secondPrice.Value };
        }
        public static Price operator /(Price firstPrice, Price secondPrice)
        {
            return new Price() { Value = firstPrice.Value / secondPrice.Value };
        }
        public static bool operator ==(Price firstPrice, Price secondPrice)
        {
            if ((firstPrice.Value == secondPrice.Value))
            return true;
            return false;
        }
        public static bool operator !=(Price firstPrice, Price secondPrice)
        {
            if ((firstPrice.Value != secondPrice.Value))
            return true;
            return false;
        }
        public static bool operator <(Price firstPrice, Price secondPrice)
        {
            if ((firstPrice.Value < secondPrice.Value))
            return true;
            return false;
        }
        public static bool operator >(Price firstPrice, Price secondPrice)
        {
            if ((firstPrice.Value > secondPrice.Value))
            return true;
            return false;
        }
    }
}