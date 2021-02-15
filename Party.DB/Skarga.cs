using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Skarga
    {
        [Key]
        public int IdSkarga { get; set; }
        [Required]
        public string Tresc { get; set; }

        public string IdUczestnik { get; set; }
        public int IdWydarzenie { get; set; }

        public Wydarzenie Wydarzenie { get; set; }
        public Uczestnik Uczestnik { get; set; }
    }
}