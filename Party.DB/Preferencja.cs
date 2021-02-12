using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Preferencja
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nazwa { get; set; }
        [Required]
        public Kategoria Kategoria { get; set; }
    }
}