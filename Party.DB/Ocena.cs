using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Ocena
    {
        [Key]
        public int IdOcena { get; set; }
        [Required]
        [Range(0, 5)]
        public int Ilosc { get; set; }

        public string IdUczestnik { get; set; }
        public int IdWydarzenie { get; set; }

        public Wydarzenie Wydarzenie { get; set; }
        public Uczestnik Uczestnik { get; set; }
    }
}