using System;
using System.Collections.Generic;
using System.Drawing;
namespace ComputerService
{
    public class Keyboard :IRepairable
    {
        private String _mark;

        public Keyboard()
        {
            DamageLevel = DamageLevel.NotDamaged;
        }

        public List<Keyboard> BuildList()
        {
            return new List<Keyboard>
            {
                {new Keyboard() {Mark = "Razer"}},
                {new Keyboard() {Mark = "Logitech"}},
                {new Keyboard() {Mark = "Defender"}},
                {new Keyboard() {Mark = "SteelSeries"}}
            };
        }

        public String Mark
        {
            get { return "Марка: " + _mark; }
            set { _mark = value; }
        }
        public Types Type { get; set; }
        public DamageLevel DamageLevel { get; set; }
        public Color Color { get; set; }

        public void Repair()
        {
            DamageLevel = DamageLevel.NotDamaged;
        }
    }
}
