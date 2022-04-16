using System.ComponentModel.DataAnnotations.Schema;

namespace AppDiplomVasilenkoTepaykim.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int RequisitesId { get; set; }

        [ForeignKey("RequisitesId")]
        public RequisitesClient RequisitesClient { get; set; }

        public int CompanyLocationId { get; set; }

        [ForeignKey("CompanyLocationId")]

        public LocationDelivery LocationDelivery { get; set; }




    }
}
