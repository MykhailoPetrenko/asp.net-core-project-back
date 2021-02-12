using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Zamknieta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Haslo { get; set; }
    }
}