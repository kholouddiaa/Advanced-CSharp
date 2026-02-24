using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal class Manager : Employee, IReportCreator
    {
        public decimal Salary { get; set; }
        public decimal Overtime { get; set; }
        public decimal Bonus { get; set; }

        public Manager(int id, string name, decimal salary, decimal overtime, decimal bonus)
            : base(id, name)
        {
            Salary = salary;
            Overtime = overtime;
            Bonus = bonus;
        }

        public override decimal CalculateSalary() => Salary + Overtime + Bonus;

        public Report CreateReport(string title, string details)
        {
            return new Report(title, details, $"Manager: {Name}");
        }

        public override void Print()
        {
            Console.WriteLine($"Manager => Id: {Id}, Name: {Name}, Base: {Salary:0.##}, Overtime: {Overtime:0.##}, Bonus: {Bonus:0.##}, Total: {CalculateSalary():0.##}");
        }
    }
}