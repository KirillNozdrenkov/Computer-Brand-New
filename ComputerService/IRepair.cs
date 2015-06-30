using System;

namespace ComputerService
{
    public interface IRepairable
    {
        void Repair();
        DamageLevel DamageLevel { get; set; }
    }
}