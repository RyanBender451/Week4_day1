﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal(2, "Tan");
            Animal animal2 = new Animal(6, 1, 1);


            animal1.printAnimalInfo();
            animal2.printAnimalInfo();

            Cat cat1 = new Cat("Grumpy", "short", false);
            cat1.printAnimalInfo();
        }
    }
}
