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
        public ICollection<Skarga> Skarga { get; set; }
        public ICollection<Kometaz> Kometaz { get; set; }
        public ICollection<Ocena> Ocena { get; set; }


    }
}