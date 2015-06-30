using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ComputerService
{
    public class SystemUnit
    {
        private String _manufacturer;

        public Processor Processor { get; set; }
        public RandomAccessMemory RandomAccessMemory { get; set; }
        public VideoCard VideoCard { get; set; }

        public class SystemUnits
        {
            public String Manufacturer { get; set; }
            public String Color { get; set; }
        }

        public List<SystemUnit> BuildList()
        {
            return new List<SystemUnit>
            {
                {new SystemUnit() {Manufacturer = "Invasion"}},
                {new SystemUnit() {Manufacturer = "ASUS"}},
                {new SystemUnit() {Manufacturer = "HP"}},
                {new SystemUnit() {Manufacturer = "MSI"}}
            };
        }

        public String Manufacturer
        {
            get { return "Марка: " + _manufacturer; }
            set { _manufacturer = value; }
        }

        public Color Color { get; set; }

        //VideoCard videoCard1 = new VideoCard("Nvidia","GeForce","2Gb");
        //VideoCard videoCard2 = new VideoCard("AMD","Radeon","1Gb");
        //Processor processor1 = new Processor("i7",4,"2100Hz");
        //Processor processor2 = new Processor("i3",2,"1200Hz");
        //RandomAccessMemory randomAccessMemory1 = new RandomAccessMemory("DDR3","1600MHz","8Gb");
        //RandomAccessMemory randomAccessMemory2 = new RandomAccessMemory("DDR2","1200MHz","4Gb");

        public SystemUnit()
        {

        }
    }
}
