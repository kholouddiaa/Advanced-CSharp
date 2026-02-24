using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop6
{
    internal class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int Hours { get; set; }

        public PartTimeEmployee(int id, string name, decimal hourRate, int hours)
            : base(id, name)
        {
            HourRate = hourRate;
            Hours = hours;
        }

        public override decimal CalculateSalary() => HourRate * Hours;

        public override void Print()
        {
            Console.WriteLine($"PartTime => Id: {Id}, Name: {Name}, HourRate: {HourRate:0.##}, Hours: {Hours}, Total: {CalculateSalary():0.##}");
        }
    }

}
