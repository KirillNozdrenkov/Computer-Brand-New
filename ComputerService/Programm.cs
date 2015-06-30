using System;
using System.Drawing;

namespace ComputerService
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var keyboard = new Keyboard() { Color = Color.GreenYellow,DamageLevel = DamageLevel.Damaged};
            var systemUnit = new SystemUnit() {Color = Color.Orange};

            Console.WriteLine();

            var workshop = new Workshop();
            workshop.Repair(keyboard);
        }
    }
}