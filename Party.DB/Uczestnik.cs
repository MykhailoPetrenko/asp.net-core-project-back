using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Uczestnik
    {
        [Key]
        public int IdUczestnik { get; set; }
        [Required]
        public string Status { get; set; }

        public virtual ICollection<PreferencjaUczestnika> PreferencjaUczestnika { get; set; }

    }
}