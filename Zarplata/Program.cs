using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarplata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> persons = new List<Employee>();
            persons.Add(new HourlyPayEmployee(1, "Михаил", 100));
            persons.Add(new FixedPayEmployee(5, "Роман", 150));
            persons.Add(new HourlyPayEmployee(3, "Николай", 300));
            persons.Add(new FixedPayEmployee(12, "Кирилл", 500));
            persons.Add(new HourlyPayEmployee(9, "Владислав", 900));
            persons.Add(new HourlyPayEmployee(23, "Юрий", 1000));
            persons.Add(new FixedPayEmployee(15, "Алексей", 1900));
            persons.Add(new FixedPayEmployee(27, "Андрей", 2200));
            persons.Add(new FixedPayEmployee(24, "Максим", 3700));
            persons.Add(new HourlyPayEmployee(50, "Сергей", 5000));
            foreach (var person in persons)
            {
                Console.WriteLine(person.CountPay());
            }
            persons = persons.OrderByDescending(x => x.CountPay()).ToList();

            foreach (Employee x in persons)
            {
                Console.WriteLine("{0} - {1}", x.Id, x.CountPay());
            }

            var firstFiveEmployees = persons.Skip(5).ToList();
            //persons.OrderByDescending(x => x.PayType);
            Console.WriteLine(persons);
            Console.ReadKey();
        }
    }
}
