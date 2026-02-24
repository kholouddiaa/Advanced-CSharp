using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Task_Depi
{
    internal class Program
    {
        enum FilterOption
        {
            Exit = 0,
            FilterByCustomerName = 1,
            FilterByDeliveryStatus = 2,
            FilterByPriceGreaterThan1000 = 3,
            FilterBeforeDate = 4,
            FilterAfterDate = 5,
            ShowAll = 6
        }

        static void Main(string[] args)
        {
            // Collection of orders
            List<Order> orders = new List<Order>
            {
                new Order { Id = 1, CustomerName = "Ali",     TotalPrice = 1200, Date = new DateTime(2025, 01, 10), IsDelivered = true  },
                new Order { Id = 2, CustomerName = "Mona",    TotalPrice = 800,  Date = new DateTime(2025, 01, 18), IsDelivered = false },
                new Order { Id = 3, CustomerName = "Ali",     TotalPrice = 3000, Date = new DateTime(2025, 02, 02), IsDelivered = true  },
                new Order { Id = 4, CustomerName = "Youssef", TotalPrice = 1500, Date = new DateTime(2024, 12, 25), IsDelivered = false },
                new Order { Id = 5, CustomerName = "Nada",    TotalPrice = 500,  Date = new DateTime(2025, 03, 01), IsDelivered = true  }
            };

            while (true)
            {
                PrintMenu();

                Console.Write("Choose: ");
                string input = Console.ReadLine()?.Trim() ?? "";

                if (!Enum.TryParse(input, out FilterOption choice))
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }

                if (choice == FilterOption.Exit)
                    break;

                IEnumerable<Order> result;

                switch (choice)
                {
                    case FilterOption.FilterByCustomerName:
                        Console.Write("Enter customer name: ");
                        string name = Console.ReadLine()?.Trim() ?? "";
                        result = Filter(orders, o => o.CustomerName.Equals(name, StringComparison.OrdinalIgnoreCase));
                        Print(result);
                        break;

                    case FilterOption.FilterByDeliveryStatus:
                        Console.Write("Delivered? (y/n): ");
                        string deliveredInput = Console.ReadLine()?.Trim().ToLower() ?? "";
                        bool isDelivered = deliveredInput == "y" || deliveredInput == "yes";
                        result = Filter(orders, o => o.IsDelivered == isDelivered);
                        Print(result);
                        break;

                    case FilterOption.FilterByPriceGreaterThan1000:
                        result = Filter(orders, o => o.TotalPrice > 1000);
                        Print(result);
                        break;

                    case FilterOption.FilterBeforeDate:
                        DateTime beforeDate = ReadDate("Enter date (yyyy-MM-dd): ");
                        result = Filter(orders, o => o.Date.Date < beforeDate.Date);
                        Print(result);
                        break;

                    case FilterOption.FilterAfterDate:
                        DateTime afterDate = ReadDate("Enter date (yyyy-MM-dd): ");
                        result = Filter(orders, o => o.Date.Date > afterDate.Date);
                        Print(result);
                        break;

                    case FilterOption.ShowAll:
                        Print(orders);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("\n==========================MENU ================================");
            Console.WriteLine("1) Filter by Customer Name");
            Console.WriteLine("2) Filter by Delivery Status (Delivered / Not Delivered)");
            Console.WriteLine("3) Filter by Price > 1000");
            Console.WriteLine("4) Filter orders BEFORE a specific date");
            Console.WriteLine("5) Filter orders AFTER a specific date");
            Console.WriteLine("6) Show ALL orders");
            Console.WriteLine("0) Exit");
            Console.WriteLine("=====================================================");
        }

        // Generic Filter using Predicate<T>
        static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> fn)
        {
            foreach (var item in items)
            {
                if (fn(item))
                    yield return item;
            }
        }

        static void Print(IEnumerable<Order> orders)
        {
            Console.WriteLine("\n----- Results -----");

            if (!orders.Any())
            {
                Console.WriteLine("No orders found.");
                return;
            }

            foreach (var o in orders)
                Console.WriteLine(o);
        }

        static DateTime ReadDate(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                string input = Console.ReadLine()?.Trim() ?? "";

                if (DateTime.TryParseExact(input, "yyyy-MM-dd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var dt))
                {
                    return dt;
                }

                Console.WriteLine("Invalid date format. Please use yyyy-MM-dd");
            }
        }
    }
}