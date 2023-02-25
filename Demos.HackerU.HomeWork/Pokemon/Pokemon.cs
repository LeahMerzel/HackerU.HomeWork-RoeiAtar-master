using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class Pokemon
    {
        public string Id;
        public string Name;
        public int LifePower = 100;
        public int AmmunitionPower = 20;

        public Pokemon()
        {
            Id = "No id";
            Name = "No name";
            LifePower = 100;
            AmmunitionPower = 50;
        }

        public Pokemon(string id, string name, int lifePower, int ammunitionPower)
        {
            Id = id;
            Name = name;
            LifePower = lifePower;
            AmmunitionPower = ammunitionPower;
        }

        public void Attack(Pokemon otherPokemon, int ammunitionPower)
        {
            if (AmmunitionPower > 0 || LifePower > 0)
            {
                otherPokemon.LifePower -= 5;
                AmmunitionPower -= ammunitionPower;
            }
            else
            {
                Console.WriteLine("Pokemon can't fight");
            }

        }
    }
}
