using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class UczestnikWydarzenie
    {
        [Key]
        public int IdUczestnikWydarzenie { get; set; }
        public int IdUczestnik { get; set; }
        public int IdWydarzenie { get; set; }
        
        public Uczestnik Uczestnik { get; set; }
        public Wydarzenie Wydarzenie { get; set; }

    }
}