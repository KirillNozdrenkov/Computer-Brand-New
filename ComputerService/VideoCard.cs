using System;
using System.Collections.Generic;

namespace ComputerService
{
    public class VideoCard : SystemUnit
    {
        private String _mark;
        private String _gpu;
        private int _capacity;

        public class VideoCards
        {
            public String Mark { get; set; }
            public String Gpu { get; set; }
            public int Capacity { get; set; }
        }

        public new List<VideoCard> BuildList()
        {
            return new List<VideoCard>
            {
                {new VideoCard() {Mark = "AMD", Gpu = "Radeon 5600", Capacity = 2}},
                {new VideoCard() {Mark = "Nvidia", Gpu = "GeForce Black", Capacity = 4}},
                {new VideoCard() {Mark = "AMD", Gpu = "Radeon 9800", Capacity = 6}},
                {new VideoCard() {Mark = "Nvidia", Gpu = "GeForce Titan", Capacity = 8}}
            };
        }

        public String Mark
        {
            get { return "Марка: " + _mark; }
            set { _mark = value; }
        }
        public String Gpu
        {
            get { return "Графический процессор: " + _gpu; }
            set { _gpu = value; }
        }
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value < 0 ? 0 : value; }
        }
    }
}