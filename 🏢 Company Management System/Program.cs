namespace oop6
{
    internal class Program
    {
       
        
            static void Print(IPrintable item) => item.Print();

            static void Main(string[] args)
            {
                var e1 = new FullTimeEmployee(1, "Ali", 10000, 500);
                var e2 = new PartTimeEmployee(2, "Omar", 80, 120);
                var e3 = new Manager(3, "Sara", 15000, 700, 2000);
                var e4 = new HR(4, "Mona", 11000, 400);

                Print(e1);
                Print(e2);
                Print(e3);
                Print(e4);

                Console.WriteLine();

                List<IReportCreator> reportCreators = new()
            {
                e3,
                e4
            };

                List<Report> reports = new();
                reports.Add(reportCreators[0].CreateReport("Monthly Summary", "Sales improved by 12%."));
                reports.Add(reportCreators[1].CreateReport("Hiring Update", "2 new developers joined."));

                Console.WriteLine("=== Reports ===");

                foreach (var report in reports)
                    Print(report);
            }
        
         }
    }
