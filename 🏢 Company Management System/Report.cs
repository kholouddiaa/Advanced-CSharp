using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal class Report : IPrintable
    {
        public string Title { get; }
        public string Details { get; }
        public string CreatedBy { get; }
        public DateTime CreatedAt { get; }

        public Report(string title, string details, string createdBy)
        {
            Title = title;
            Details = details;
            CreatedBy = createdBy;
            CreatedAt = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine("----- REPORT -----");
            Console.WriteLine($"Title     : {Title}");
            Console.WriteLine($"Details   : {Details}");
            Console.WriteLine($"CreatedBy : {CreatedBy}");
            Console.WriteLine($"CreatedAt : {CreatedAt}");
            Console.WriteLine("------------------");
        }
    }
}

