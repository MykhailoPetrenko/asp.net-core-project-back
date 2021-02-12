using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Preferencja
    {
        [Key]
        public int IdPreferencja { get; set; }
        [Required]
        public string Nazwa { get; set; }
        [Required]
        public Kategoria Kategoria { get; set; }
        
        public virtual ICollection<PreferencjaUczestnika> PreferencjaUczestnika { get; set; }

    }
}