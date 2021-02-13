using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Tworca
    {
        [Key]
        public int IdTworca { get; set; }
        [Required]
        public string NrKonta { get; set; }
        [Required]
        public Double StanKonta { get; set; }
        
        public ICollection<Wydarzenie> Wydarzenia { get; set; }
    }
}