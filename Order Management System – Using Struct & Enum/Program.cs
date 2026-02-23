namespace Order_Management_System
{
    internal class Program
    {

        enum OrderStatus
        {
            Pending,
            Processing,
            Shipped,
            Delivered,
            Cancelled
        }
        struct Order
        {

            public int OrderId;
            public string CustomerName;
            public double TotalPrice;
            public OrderStatus Status;
            public Order(int Id, string Name, double Price, OrderStatus statu)
            {
                OrderId = Id;
                CustomerName = Name;
                TotalPrice = Price;
                Status = statu;

            }
            public void Display()
            {
                Console.WriteLine($" OrderdId : {OrderId}   CustomerName is :" +
                    $"{CustomerName}   TotalPrice =" +
                    $"{TotalPrice}  Status : {Status}");
            }

        }
        static void Main(string[] args)
        {
            Order order1 = new Order(1, "abc", 55.22, OrderStatus.Pending);
            Order order2= new Order(2, "abjkkkc", 100.225  , OrderStatus.Processing);

                order1.Display();
            order2.Display();

            Console.WriteLine("------------ALL ORDERED---------------");
            foreach (string name in Enum.GetNames(typeof(OrderStatus)))
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(" Enter your order");
            // Parsing from user
            string order = Console.ReadLine();

            if (Enum.TryParse(order, true, out OrderStatus newstatus))
            {
                order1.Status = newstatus;

                Console.WriteLine("Succefly ordered");

            }
            else
            {
                Console.WriteLine("invalid ordered");

            }
            order1.Display() ;
            Console.WriteLine("comparing between orders");
            Console.WriteLine(order1.Equals(order2));
        }
    }
}