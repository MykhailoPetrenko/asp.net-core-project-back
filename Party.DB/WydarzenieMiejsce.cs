namespace Party.DB
{
    public class WydarzenieMiejsce
    {
        public int IdWydarzenieMiejsce { get; set; }
        public int IdWydarzenie { get; set; }
        public int IdMiejsce { get; set; }
        
        public Wydarzenie IdWydarzenieNavigation { get; set; }
        public Miejsce IdMiejsceNavigation { get; set; }
    }
}