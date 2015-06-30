using System;
using System.Collections.Generic;

namespace ComputerService
{
    public class RandomAccessMemory : SystemUnit
    {
        private String _type;
        private int _frequency;
        private int _capacity;

        public class RandomAccessMemorys
        {
            public String Type { get; set; }
            public int Frequency { get; set; }
            public int Capacity { get; set; }
        }

        public new List<RandomAccessMemory> BuildList()
        {
            return new List<RandomAccessMemory>
            {
                {new RandomAccessMemory() {Type = "DDR", Frequency = 1200, Capacity = 2}},
                {new RandomAccessMemory() {Type = "DDR2", Frequency = 1400, Capacity = 4}},
                {new RandomAccessMemory() {Type = "DDR3", Frequency = 1600, Capacity = 6}},
                {new RandomAccessMemory() {Type = "DDR4", Frequency = 1800, Capacity = 8}}
            };
        }

        public String Type
        {
            get { return "“ËÔ: " + _type; }
            set { _type = value; }
        }
        public int Frequency
        {
            get { return _frequency; }
            set { _frequency = value < 0 ? 0 : value; }
        }

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value < 0 ? 0 : value; }
        }
    }
}