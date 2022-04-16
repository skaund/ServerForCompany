using System.ComponentModel.DataAnnotations;

namespace AppDiplomVasilenkoTepaykim.Models
{
    public class LocationCompany
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public int ZipCode { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }


    }
}
