using System;
using System.Collections.Generic;

namespace ComputerService
{
    public class Monitor
    {
        private String _mark;
        private int _diagonal;
        private String _bright;

        public class Monitors
        {
            public String Mark { get; set; }
            public int Diagonal { get; set; }
            public String Bright { get; set; }
        }

        public List<Monitor> BuildList()
        {
            return new List<Monitor>
            {
                {new Monitor() {Mark = "LG", Diagonal = 19, Bright = "High"}},
                {new Monitor() {Mark = "HP", Diagonal = 15, Bright = "Low"}},
                {new Monitor() {Mark = "MSI", Diagonal = 21, Bright = "High"}},
                {new Monitor() {Mark = "ASUS", Diagonal = 17, Bright = "Medium"}}
            };
        }

        public String Mark
        {
            get { return "Марка: " + _mark; }
            set { _mark = value; }
        }

        public int Diagonal
        {
            get { return _diagonal; }
            set { _diagonal = value < 0 ? 0 : value; }
        }

        public String Bright
        {
            get { return "Яркость: " + _bright; }
            set { _bright = value; }
        }
    }
}
