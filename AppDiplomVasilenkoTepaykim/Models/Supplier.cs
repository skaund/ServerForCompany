using System.ComponentModel.DataAnnotations.Schema;

namespace AppDiplomVasilenkoTepaykim.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        public string NameSuppliers { get; set; }

        public string OwnerCompany { get; set; }


        public int RequisitesId { get; set; }

        [ForeignKey("RequisitesId")]
        public RequisitesCompany RequisitesCompany { get; set; }

        public int CompanyLocationId { get; set; }

        [ForeignKey("CompanyLocationId")]

        public LocationCompany LocationCompanys { get; set; }











    }
}
