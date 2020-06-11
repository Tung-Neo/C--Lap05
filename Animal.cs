using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
    }
    class Mammal : Animal
    {
        public void Feature()
        {
            Console.WriteLine("Mammals give birth to young ones.");
        }
    }
    class Dog : Mammal
    {
        public void Noise()
        {
            Console.WriteLine("Dog Barks.");
        }
        static void Main1()
        {
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
        }
    }
}
