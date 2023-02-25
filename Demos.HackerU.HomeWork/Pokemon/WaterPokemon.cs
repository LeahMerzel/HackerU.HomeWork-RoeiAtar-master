using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class WaterPokemon : Pokemon
    {
        public int ElectricPower;

        public WaterPokemon() : base()
        {
            ElectricPower = 0;

        }

        public WaterPokemon(int electricPower) : base()
        {
            ElectricPower = electricPower;
        }

        public void ElectricAttackHit(Pokemon OtherPokemon)
        {

        }

    }
}
