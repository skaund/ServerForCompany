using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDiplomVasilenkoTepaykim.Models
{
    public class LocationDelivery
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