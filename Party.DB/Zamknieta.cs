using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Zamknieta: Wydarzenie
    {
       [Required]
        public string Haslo { get; set; }
    }
}