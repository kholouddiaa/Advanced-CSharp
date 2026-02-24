using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal class HR : Employee, IReportCreator
    {
        public decimal Salary { get; set; }
        public decimal Overtime { get; set; }

        public HR(int id, string name, decimal salary, decimal overtime)
            : base(id, name)
        {
            Salary = salary;
            Overtime = overtime;
        }

        public override decimal CalculateSalary() => Salary + Overtime;

        public Report CreateReport(string title, string details)
        {
            return new Report(title, details, $"HR: {Name}");
        }

        public override void Print()
        {
            Console.WriteLine($"HR => Id: {Id}, Name: {Name}, Base: {Salary:0.##}, Overtime: {Overtime:0.##}, Total: {CalculateSalary():0.##}");
        }
    }
}