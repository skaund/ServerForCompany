using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDiplomVasilenkoTepaykim.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NameProduct { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public double Quantity { get; set; }

        public int UnitId { get; set; }

        [ForeignKey("UnitId")]
        public virtual Unit Unit { get; set; }

        public DateTime ProductionDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; } 

    }
}
