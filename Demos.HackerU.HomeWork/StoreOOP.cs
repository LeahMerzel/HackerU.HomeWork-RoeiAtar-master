﻿using Demos.HackerU.HomeWork.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork
{
    public class StoreOOP
    {
        public static void Run()
        {

            //create top level and sub Categories
            StoreCategory s1 = new StoreCategory("Electronics", 0);
            StoreCategory s2 = new StoreCategory("Games", 0);
            StoreCategory s3 = new StoreCategory("Clothes");// the constructor put 0 for parentCategoryId
            StoreCategory s4 = new StoreCategory("SmartPhones", 1);
            StoreCategory s5 = new StoreCategory("Lamps", 1);
            StoreCategory s6 = new StoreCategory("xBox Games", 2);
            StoreCategory s7 = new StoreCategory("PlaySation Games", 2);
            StoreCategory s8 = new StoreCategory("shirt", 3);
            StoreCategory s9 = new StoreCategory("pants", 3);

            //create Producs 
            StoreProduct p1 = new StoreProduct(4, "iPhone 14 pro Max", 5500, true);
            StoreProduct p2 = new StoreProduct(4, "iPhone 13 pro Max", 3500, true);
            StoreProduct p3 = new StoreProduct(4, "iPhone 14 pro", 4000, true);

            StoreProduct p4 = new StoreProduct(5, "Kitchen Lamp", 200, true);
            StoreProduct p5 = new StoreProduct(5, "toylet Lamp", 300, false);
            StoreProduct p6 = new StoreProduct(5, "room Lamp", 100, true);

            var obj = ProductsService.GetInstance();
            obj.AddNewCategory("Cameras", 0);

        }
    }
}