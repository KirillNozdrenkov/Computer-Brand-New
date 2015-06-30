using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PriceGoods
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPrice = new Price()
            {
                Value = 1500000,
                Currency = new BelarusianRuble()
            };
            var secondPrice = new Price()
            {
                Value = 100,
                Currency = new AmericanDollar()
            };
           //var price = firstPrice + secondPrice;
            //+ - * int / int > < == !=
            Console.WriteLine("Сложение: " + (firstPrice.Value + secondPrice.Value));
            Console.WriteLine("Вычитание: " + (firstPrice.Value - secondPrice.Value));
            Console.WriteLine("Умножение: " + (firstPrice.Value * secondPrice.Value));
            Console.WriteLine("Деление: " + (firstPrice.Value / secondPrice.Value));
            Console.WriteLine((firstPrice+secondPrice).Value);
            Console.ReadKey();
        }
    }
}
