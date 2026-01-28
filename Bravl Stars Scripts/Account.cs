using Bravl_Stars_Scripts.SuperHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravl_Stars_Scripts
{
    class Account
    {
        public string Name { get; set; }
        public List<ISuperHero> List = new List<ISuperHero>();

    }
}
