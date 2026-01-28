using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravl_Stars_Scripts.Additional
{
    internal class EnergyForSuperHero
    {
        private int EnergyMax { get; }
        private int TimeRegenirationEnergy { get; }
        private int Count { get; set; }
        private int Time;
        public EnergyForSuperHero(int EnergyMax, int TimeRegenirationEnergy)
        {
            this.EnergyMax = EnergyMax;
            this.TimeRegenirationEnergy = TimeRegenirationEnergy;
            Count = EnergyMax;
        }
        public void RegenirationEnergy()
        {
            if (Count < EnergyMax)
            {
                Time++;
                if (Time == TimeRegenirationEnergy)
                {
                    Count++;
                    Time = 0;
                }
            }
        }
        public bool GetEnergy()
        {
            if (Count > 0)
            {
                Count--;
                return true;
            }
            return false;
        }
    }
}
