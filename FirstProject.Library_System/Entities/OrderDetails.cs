using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Library_System.Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int BookId { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public Order ?Order { get; set; }
    }
}
