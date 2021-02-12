using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Ocena
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0, 5)]
        public int Ilosc { get; set; }
    }
}