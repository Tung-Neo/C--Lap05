using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7
{
    class Animal2
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
        public void DoSomeThing()
        {
            Console.WriteLine("Every animal does something.");
        }
    }
    class Cat2 : Animal2
    {
        static void Main2()
        {
            Cat2 objCat = new Cat2();
            objCat.Eat();
            objCat.DoSomeThing();
        }
    }
}
