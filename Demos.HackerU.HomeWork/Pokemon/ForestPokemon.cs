using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class ForestPokemon : Pokemon
    {
        public int WoodsPower = 30;

        public ForestPokemon() : base()
        {
            WoodsPower = 30;
        }
        public ForestPokemon(int woodsPower, string id, string name, int lifePower, int ammunitionPower) : base(id, name, lifePower, ammunitionPower)
        {
            WoodsPower = woodsPower;
        }
        public void WoodsAttackHit(Pokemon OtherPokemon)
        {

        }

    }
}
