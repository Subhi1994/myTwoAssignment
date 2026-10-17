using System;
using System.Collections.Generic;
using System.Text;

namespace myTwoAssignment
{
    public class FullTimeEmployee : Employee, IWorkable
    {
        public FullTimeEmployee(int id, string name, decimal monthlySalary) : base(id, name)
        {
            Salary = monthlySalary;
        }

        // تطبيق حساب الراتب لدوام كامل
        public override decimal CalculateSalary()
        {
            return Salary;
        }


        // تطبيق دالة العمل
        public override void Work()
        {
            Console.WriteLine($"{Name} is working full-time.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Employee Type: Full-Time");
            Console.WriteLine($"Salary: {Salary} JOD");
        }
    }
}
