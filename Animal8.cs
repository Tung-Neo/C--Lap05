using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7
{
    class Animal8
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
        protected void DoSomeThing()
        {
            Console.WriteLine("Every animal does something");
        }
    }
    class Cat8 : Animal8
    {
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }
        static void Main8()
        {
            Cat8 objCat = new Cat8();
            objCat.Eat();
        }
    }
}
