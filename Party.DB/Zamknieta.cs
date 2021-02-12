using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Zamknieta
    {
        [Key]
        public int IdZamknieta { get; set; }
        [Required]
        public string Haslo { get; set; }
    }
}