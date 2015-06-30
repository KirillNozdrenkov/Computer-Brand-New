using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService
{
    class Computer
    {
        public Keyboard Keyboard { get; set; }
        public Monitor Monitor { get; set; }
        public SystemUnit SystemUnit { get; set; }
    }
}