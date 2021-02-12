using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Party.DB
{
    public class Miejsce
    {
        [Key]
        public int IdMiejsce { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nazwa { get; set; } 
        public Point? Koordynaty { get; set; }
    }
}