﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party.DB
{
    public class WydarzenieKategoria
    {
        [Key]
        public int IdWydarzenieKategoria { get; set; }
        public int IdWydarzenie { get; set; }
        public int IdKategoria { get; set; }

        public Wydarzenie IdWydarzenieNavigation{ get; set; }
        public Kategoria IdKategoriaNavigation { get; set; }
    }
}
