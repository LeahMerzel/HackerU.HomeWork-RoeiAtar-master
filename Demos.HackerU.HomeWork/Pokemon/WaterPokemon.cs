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

        public void ElectricAttackHit(Pokemon OtherPokemon)
        {

        }

    }
}
