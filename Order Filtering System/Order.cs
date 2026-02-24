using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Depi
{
    internal class Order
    {

        public int Id { get; set; }
        public string CustomerName { get; set; } = "";
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public bool IsDelivered { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Customer={CustomerName}, Price={TotalPrice}, Date={Date:yyyy-MM-dd}, Delivered={IsDelivered}";
        }
    

}
}
