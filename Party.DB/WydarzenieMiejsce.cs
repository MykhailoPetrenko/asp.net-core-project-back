using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class WydarzenieMiejsce
    {
        [Key]
        public int IdWydarzenieMiejsce { get; set; }
        public int IdWydarzenie { get; set; }
        public int IdMiejsce { get; set; }
        
        public Wydarzenie IdWydarzenieNavigation { get; set; }
        public Miejsce IdMiejsceNavigation { get; set; }
    }
}