using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal interface IReportCreator
    {
        Report CreateReport(string title, string details);
    }
}
