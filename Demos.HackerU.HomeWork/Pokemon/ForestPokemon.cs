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
        public void WoodsAttackHit(Pokemon otherPokemon)
        {
            if (AmmunitionPower > 0 || LifePower > 0)
            {
                otherPokemon.LifePower -= 8;
                WoodsPower -= 3;
                LifePower -= 2;
            }
            else
            {
                Console.WriteLine("Pokemon can't fight");
            }
        }



    }
}
