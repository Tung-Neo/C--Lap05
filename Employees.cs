using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7
{
    class Employees
    {
        int emlId = 1;
        string empName = "James Anderson";
        int age = 25;
        public void Display()
        {
            Console.WriteLine("Employee ID: " + emlId);
            Console.WriteLine("Employee Name: " + empName);
        }
    }
    class Department : Employees
    {
        int deptID = 501;
        string deptName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("Department ID: " + deptID);
            Console.WriteLine("Department Name: " + deptName);
        }
        static void Main5()
        {
            Department objDepartment = new Department();
            objDepartment.Display();
        }
    }
}
