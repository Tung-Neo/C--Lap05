using System;

namespace Session_7
{
    class Animal3
    {
        protected string Food;
        protected string Activity;
    }
    class Cat3 : Animal3
    {
        static void Main3()
        {
            Cat3 objCat = new Cat3();
            objCat.Food = "Mouse";
            objCat.Activity = "Laze around";
            Console.WriteLine("The Cat loves to eat " + objCat.Food + ".");
            Console.WriteLine("The Cat loves to " + objCat.Activity + ".");
        }
    }
}
