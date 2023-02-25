﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demos.HackerU.HomeWork.Inhheritance;

namespace Demos.HackerU.HomeWork
{
    public class HW8OOP
    {
        public static void Run()
        {
            #region Q1;
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

            foreach (Person p in Person)
            {
                p.DisplayInfoToConsole();
            }

            p1.Age = 10;
            p1.Address = "new address";
            p1.City = "New City";
            p1.DisplayInfoToConsole();
            #endregion

        }
    }
}
