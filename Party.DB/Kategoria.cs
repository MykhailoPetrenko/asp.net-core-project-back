using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Kategoria
    {
        [Key]
        public int IdKategoria{ get; set; }
        public int Nazwa{ get; set; }

        public ICollection<WydarzenieKategoria> WydarzenieKategoria { get; set; }
    }
}