using System;
using System.Collections.Generic;

namespace ComputerService
{
    public class Processor : SystemUnit
    {
        private String _model;
        private int _numberOfCores;
        private int _frequency;
        
        public class Processors
        {
            public String Model { get; set; }
            public int NumberOfCores { get; set; }
            public int Frequency { get; set; }
        }

        public new List<Processor> BuildList()
        {
            return new List<Processor>
            {
                {new Processor() {Model = "i3", NumberOfCores = 4, Frequency = 1200}},
                {new Processor() {Model = "i7", NumberOfCores = 8, Frequency = 3200}},
                {new Processor() {Model = "i3", NumberOfCores = 2, Frequency = 1500}},
                {new Processor() {Model = "i5", NumberOfCores = 6, Frequency = 2100}}
            };
        }

        public int Frequency
        {
            get { return _frequency; }
            set { _frequency = value < 0 ? 0 : value; }
        }
        public int NumberOfCores
        {
            get
            {
                return _numberOfCores;
            }
            set { _numberOfCores = value < 0 ? 0 : value; }
        }
        public String Model
        {
            get
            {
                return "Модель: " + _model;
            }
            set { _model = value; }
        }
    }
}