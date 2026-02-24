using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal abstract class Employee : IPrintable
    {
        public int Id { get; }
        public string Name { get; }

        protected Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateSalary();

        public virtual void Print()
        {
            Console.WriteLine($"{GetType().Name} => Id: {Id}, Name: {Name}, Salary: {CalculateSalary():0.##}");
        }
    }
}
