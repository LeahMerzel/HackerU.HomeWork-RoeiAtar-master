using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demos.HackerU.HomeWork.Inhheritance;
using Demos.HackerU.HomeWork.Pokemon;


namespace Demos.HackerU.HomeWork
{
    public class HW8OOP
    {
        #region Q1;
        public static void Run1()
        {


            Person p1 = new Person("markez barnea", "Ashkelon", 35, "Roei Atar");
            p1.DisplayInfoToConsole();
            Customer c1 = new Customer("Maale agat", "markez barnea", 35, "Ashkelon", "Roei Atar");
            c1.DisplayInfoToConsole();
            Employe e1 = new Employe("Software", 15000, "Maale agat St", 32, "Ashkelon", "Matan Gayda");
            e1.DisplayInfoToConsole();
            Student s1 = new Student("A2 Software", "Atotahim 5", 25, "Netanya", "Matan", StudentType.ComputerScience);
            s1.DisplayInfoToConsole();

            Console.WriteLine("____________________");

            Person[] Person = { p1, c1, e1, s1 };

            foreach (Person index in Person)
            {

                switch (index)
                {
                    case
                        Employe employe:
                        employe.DisplayInfoToConsole();
                        break;

                    case Student student:
                        student.DisplayInfoToConsole();
                        break;

                    case Customer customer:
                        customer.DisplayInfoToConsole();
                        break;
                }

            }
            Console.WriteLine("____________________");



            Customer c2 = new Customer();
            c2.Age = 10;
            c2.Address = "new address";
            c2.City = "New City";
            c2.ShippingAddress = "dfsfsd sdfsd  ";
            c2.DisplayInfoToConsole();



        }
        #endregion

        #region Q2;
        public static void Run2()
        {
            WaterPokemon pokeWater = new WaterPokemon();
            pokeWater.Id = "1001";
            pokeWater.Name = "Squirtle";

            AirPokemon pokeAir = new AirPokemon();
            pokeAir.Id = "1002";
            pokeAir.Name = "Pidgeot";

            pokeAir.StormAttackHit(pokeWater);
            pokeWater.ElectricAttackHit(pokeAir);
            pokeAir.Attack(pokeWater, 5);
            pokeWater.Attack(pokeAir, 7);

            ForestPokemon pockForest = new ForestPokemon();
            pockForest.Id = "1003";
            pockForest.Name = "Bulbasaur";


            pockForest.WoodsAttackHit(pokeWater);
            pokeWater.ElectricAttackHit(pockForest);
            pockForest.Attack(pokeWater, 5);
            pokeWater.Attack(pockForest, 7);

            for (int i = 0; i < pockForest.LifePower; i++)
            {
                //pockForest.WoodsAttackHit(pokeWater);
                pokeWater.ElectricAttackHit(pockForest);
                //pockForest.Attack(pokeWater, 5);
                //pokeWater.Attack(pockForest, 7);
            }



        }
        #endregion
    }
}
