using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Skarga
    {
        [Key]
        public int IdSkarga { get; set; }
        [Required]
        public string Tresc { get; set; }
        
        public Wydarzenie Wydarzenie { get; set; }
    }
}