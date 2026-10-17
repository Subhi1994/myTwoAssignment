using System;
using System.Collections.Generic;
using System.Text;

namespace myTwoAssignment
{
    public class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public PartTimeEmployee(int id, string name, int hoursWorked, decimal hourlyRate) : base(id, name)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            Salary = CalculateSalary(); // حساب وتخزين الراتب
        }

        // تطبيق حساب الراتب للساعات
        public override decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }

        // تطبيق دالة العمل
        public override void Work()
        {
            Console.WriteLine($"{Name} is working part-time.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Employee Type: Part-Time");
            Console.WriteLine($"Salary: {Salary} JOD");
        }
    }
}