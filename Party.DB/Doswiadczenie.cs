using System;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Doswiadczenie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Miejsce { get; set; } 
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
    }
}