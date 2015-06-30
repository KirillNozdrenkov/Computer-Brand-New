using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService
{
    public class Workshop
    {
        public void Repair(IRepairable hardware)
        {
            hardware.DamageLevel = DamageLevel.NotDamaged;
        }
    }
}