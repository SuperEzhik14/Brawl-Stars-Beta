using Bravl_Stars_Scripts.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravl_Stars_Scripts.SuperHeroes
{
    class SHELLY : ISuperHero
    {
        public string Name { get; } = "SHELLY";
        public int Damage { get; set; } = 340;

        public EnergyForSuperHero energy { get; set; } = new EnergyForSuperHero(3, 60);
        public Regeniration HP { get; set; } = new Regeniration(2000);
        public void GetAttack()
        {
            Console.WriteLine($"{Name}-Обычный Выстрел [{Damage}]");
        }
        public void GetSuper()
        {
            Console.WriteLine($"{Name}-Супер Выстрел X3 урона [{Damage * 3}]");
        }
    }
}
