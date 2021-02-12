using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Uczestnik
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Status { get; set; }

        public List<Preferencja> Preferencja { get; set; } = new List<Preferencja>();
    }
}