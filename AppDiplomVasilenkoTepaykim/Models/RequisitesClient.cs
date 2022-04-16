using System.ComponentModel.DataAnnotations;

namespace AppDiplomVasilenkoTepaykim.Models
{
    public class RequisitesClient
    {
        [Key]
        public int Id { get; set; }

        public decimal PhysicalInn { get; set; }

        public decimal LegalInn { get; set; }

        public decimal KPP { get; set; }

        public string NumberPhone { get; set; }

        public string Email { get; set; }
    }
}
