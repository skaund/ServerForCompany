using System.ComponentModel.DataAnnotations;

namespace AppDiplomVasilenkoTepaykim.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string NameCategory { get; set; }

        public string Description { get; set; }

    }
}
