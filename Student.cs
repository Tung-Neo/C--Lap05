using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7
{
    class Student
    {
        string studentName = "James";
        string address = "California";
        public virtual void PrintDetails()
        {
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Address: " + address);
        }
    }
    class Grade : Student
    {
        string _class = "Four";
        float percent = 71.25F;
        public override void PrintDetails()
        {
            Console.WriteLine("Class: " + _class);
            Console.WriteLine("Percentage: " + percent);
        }
        static void Main()
        {
            Student objStudent = new Student();
            Grade objGrade = new Grade();
            objStudent.PrintDetails();
            objGrade.PrintDetails();
        }
    }
}
