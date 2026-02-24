using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop6
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public decimal Overtime { get; set; }

        public FullTimeEmployee(int id, string name, decimal salary, decimal overtime)
            : base(id, name)
        {
            Salary = salary;
            Overtime = overtime;
        }

        public override decimal CalculateSalary() => Salary + Overtime;

        public override void Print()
        {
            Console.WriteLine($"FullTime => Id: {Id}, Name: {Name}, Base: {Salary:0.##}, Overtime: {Overtime:0.##}, Total: {CalculateSalary():0.##}");
        }
    }

}
