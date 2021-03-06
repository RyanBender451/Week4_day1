﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_day1
{
    class Cat : Animal
    {

        private string breed;
        private string furLength;

        private bool declawed;

        public Cat(string breed, string furLength, bool declawed, string color) : base(4, 3, 3, color)
        {
            this.breed = breed;
            this.furLength = furLength;
            this.declawed = declawed;
            this.color = color;
            isGoodToEat = false;
        }

        public void Speak()
        {
            Console.WriteLine("Meow!");
        }
        public override void printAnimalInfo()
        {
            Console.WriteLine("I am a cat.");
            base.printAnimalInfo();
            Console.WriteLine("The Breed is " + breed + " cat.");
            Console.WriteLine("Fur length is " + furLength);
            Console.WriteLine("Declawed: " + declawed);
        }
    }
}
