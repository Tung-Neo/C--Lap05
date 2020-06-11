using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7
{
    class Metals
    {
        string metalType;
        public Metals(string type)
        {
            metalType = type;
            Console.WriteLine("Metal: \t\t" + metalType);
        }
    }
    class SteelCompany : Metals
    {
        string grade;
        public SteelCompany(string grade) : base("Steel")
        {
            grade = grade;
            Console.WriteLine("Grade: \t\t" + grade);
        }
    }
    class Automobile : SteelCompany
    {
        string part;
        public Automobile(string part) : base ("Cast Iron")
        {
            part = part;
            Console.WriteLine("Part: \t\t" + part);
        }
        static void Main7()
        {
            Automobile objAutomobile = new Automobile("Chassies");
        }
    }
}
