using Bravl_Stars_Scripts.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravl_Stars_Scripts.SuperHeroes
{
    interface ISuperHero 
    {
        EnergyForSuperHero energy { get; set; }
        Regeniration HP { get; set; }
        void GetSuper();
        void GetAttack();
        string Name { get; }
        public int Damage { get; set; }
    }
}
