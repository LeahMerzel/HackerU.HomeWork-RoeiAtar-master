using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class ForestPokemon : Pokemon
    {
        public int WoodsPower;

        public ForestPokemon() : base()
        {
            WoodsPower = 0;
        }

        public ForestPokemon(int woodsPower) : base()
        {
            WoodsPower = woodsPower;
        }

        public void WoodsAttackHit(Pokemon OtherPokemon)
        {

        }

    }
}
