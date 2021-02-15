using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Zdjecie
    {
        [Key]
        public int IdZdjecie { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        public string Url { get; set; }

        public Tworca Tworca { get; set; }
        public Wydarzenie Wydarzenie { get; set; }
    }
}