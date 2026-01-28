using Bravl_Stars_Scripts.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravl_Stars_Scripts.SuperHeroes
{
    class VORON : ISuperHero
    {
        public string Name { get; } = "VORON";
        public int Damage { get; set; } = 120;

        public EnergyForSuperHero energy { get; set; } = new EnergyForSuperHero(3, 40);
        public Regeniration HP { get; set; } = new Regeniration(1200);
        public void GetAttack()
        {
            Console.WriteLine($"{Name}-Обычный Выстрел [{Damage + new Random().Next(20,100)}]");
        }
        public void GetSuper()
        {
            Console.WriteLine($"{Name}-Взлет Ворона [{Damage * +new Random().Next(3, 10)}]");
        }
    }
}
