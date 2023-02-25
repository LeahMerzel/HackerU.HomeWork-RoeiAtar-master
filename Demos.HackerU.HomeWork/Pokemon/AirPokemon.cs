using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class AirPokemon : Pokemon
    {

        public int StormPower = 25;

        public AirPokemon() : base()
        {
            StormPower = 25;
        }

        public AirPokemon(int stormPower, string id, string name, int lifePower, int ammunitionPower) : base(id, name, lifePower, ammunitionPower)
        {
            StormPower = stormPower;
        }

        public void StormAttackHit(Pokemon OtherPokemon)
        {

        }
    }
}

