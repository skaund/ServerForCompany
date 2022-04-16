using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDiplomVasilenkoTepaykim.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public double TotalAmount { get; set; }

        public int StaffId { get; set; }

        [ForeignKey("StaffId")] 
        public Staff Staff { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public int LocationDeliveryId { get; set; }

        [ForeignKey("LocationDeliveryId")]
        public LocationDelivery LocationDelivery { get; set; }











    }
}
