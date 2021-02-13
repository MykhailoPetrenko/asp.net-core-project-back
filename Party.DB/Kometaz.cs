using System;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Kometaz
    {
        [Key]
        public int IdKometaz { get; set; }
        [Required]
        [MaxLength(255)]
        public string Tresc { get; set; }
        
        public Wydarzenie Wydarzenie { get; set; }
    }
}