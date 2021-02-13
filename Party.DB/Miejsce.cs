using System.Collections.Generic;
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
        public int Latitude { get; set; }
        public int Longitude { get; set; }


        public ICollection<WydarzenieMiejsce> WydarzenieMiejsce { get; set; }

    }
}