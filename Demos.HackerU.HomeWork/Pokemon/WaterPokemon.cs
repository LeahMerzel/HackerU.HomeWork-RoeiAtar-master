using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class WaterPokemon : Pokemon
    {
        public int ElectricPower = 20;

        public WaterPokemon() : base()
        {
            ElectricPower = 20;

        }

        public WaterPokemon(int electricPower, string id, string name, int lifePower, int ammunitionPower) : base(id, name, lifePower, ammunitionPower)
        {
            ElectricPower = electricPower;
        }

        public void ElectricAttackHit(Pokemon otherPokemon)
        {
            if (AmmunitionPower > 0 || LifePower > 0)
            {
                otherPokemon.LifePower -= 20;
                ElectricPower -= 8;
                LifePower -= 4;
            }
            else
            {
                Console.WriteLine("Pokemon can't fight");
            }

        }

    }
}
