using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Uczestnik: Osoba
    {
        [Required]
        public string Status { get; set; }

        public ICollection<PreferencjaUczestnika> PreferencjaUczestnika { get; set; }
        public ICollection<UczestnikWydarzenie> UczestnikWydarzenie { get; set; }


    }
}