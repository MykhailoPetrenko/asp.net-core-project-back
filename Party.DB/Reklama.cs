using System;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Reklama
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DataOd { get; set; }
        [Required]
        public DateTime DataDo { get; set; }
        [Required]
        public string Opis { get; set; }
        
    }
}