using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class AirPokemon : Pokemon
    {

        public int StormPower;

        public AirPokemon() : base()
        {
            StormPower = 0;
        }

        public AirPokemon(int stormPower) : base()
        {
            StormPower = stormPower;
        }

        public void StormAttackHit(Pokemon OtherPokemon)
        {

        }
    }
}

