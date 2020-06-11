using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7
{
    class Animal6
    {
        public Animal6()
        {
            Console.WriteLine("Animal construct without parameters");
        }
        public Animal6(String Name)
        {
            Console.WriteLine("Animal constructor with a string parameter");
        }
    }
    class Canine : Animal6
    {
        public Canine() : base("Lion")
        {
            Console.WriteLine("Derived Canine");
        }
    }
    class Details
    {
        static void Main6()
        {
            Canine objCanine = new Canine();
        }
    }
}
