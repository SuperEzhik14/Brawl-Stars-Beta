using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravl_Stars_Scripts.Additional
{
    class Regeniration
    {
        public int Count;
        public int MAX;
        private int Time;
        public Regeniration(int HPMAX)
        {
            this.Count = HPMAX;
            this.MAX = HPMAX;
        }
        public void GetRegeniration()
        {
            if (Count < MAX)
            {
                Time++;
                if (Time == 100)
                {
                    if (Count < (MAX - (MAX / 8)))
                    {
                        Count += (MAX / 8);
                    }
                    else
                    {
                        Count = MAX;
                    }
                    Time = 0;
                }
            }
        }
    }
}
