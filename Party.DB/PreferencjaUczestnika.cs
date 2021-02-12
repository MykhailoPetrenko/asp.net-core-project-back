using Microsoft.EntityFrameworkCore;

namespace Party.DB
{
    public class PreferencjaUczestnika
    {
        public int IdPreferencjaUczestnika { get; set; }
        public int IdUczestnik { get; set; }
        public int IdPreferencja { get; set; }
        
        public Uczestnik IdUczestnikNavigation { get; set; }
        public Preferencja IdPreferencjaNavigation { get; set; }
        
    }
}