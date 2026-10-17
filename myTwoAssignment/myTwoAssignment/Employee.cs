using System;
using System.Collections.Generic;
using System.Text;

namespace myTwoAssignment
{
    public abstract class Employee : IWorkable
    {
        // Encapsulation: جعل حقل الراتب خاص (private)
        private decimal salary;

        public int Id { get; set; }
        public string Name { get; set; }

        // خاصية الراتب للتحكم بالوصول
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Constructor
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // دالة مجردة سيتم تطبيقها في الأصناف الابنة (Polymorphism)
        public abstract decimal CalculateSalary();

        // دالة العمل المطلوبة من الواجهة IWorkable
        public abstract void Work();

        // دالة لعرض المعلومات
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }
    }
}