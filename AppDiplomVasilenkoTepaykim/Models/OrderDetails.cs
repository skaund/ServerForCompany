using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDiplomVasilenkoTepaykim.Models
{
    [Keyless]
    public class OrderDetails
    {
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]

        public Order Order { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public int Discount { get; set; }

    }
}
