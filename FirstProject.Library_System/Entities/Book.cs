using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Library_System.Entities
{
    public class Book
    {
        public int BookId { get; set; }

        public string? BookName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Book Id : {this.BookId}, Book name : {this.BookName}, the price : {this.Price}";
        }
    }
}
