using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Library_System.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string ?CustomerId { get; set; }

        public List<OrderDetails> OrderList { get; set; } = new List<OrderDetails>();
    }
}
