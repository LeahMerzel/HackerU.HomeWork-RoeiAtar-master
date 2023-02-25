using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Inhheritance
{
    public class Person
    {

        public string Addres;
        public string Name;
        public int Age;
        public string City;

        public Person()
        {
            Addres = "No Addres";
            Name = "No Name";
            Age = 0;
            City = "No City";
        }

        public Person(string addres, string name, int age, string city)
        {
            Addres = addres;
            Name = name;
            Age = age;
            City = city;
        }
        public void DisplayInfoToConsole()
        {
            Console.WriteLine($"Name :{Name}\nAge :{Age}\nCity :{City}\nAddres :{Addres}");
        }
    }
}
