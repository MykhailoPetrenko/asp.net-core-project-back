using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Party.DB
{
    public class Wydarzenie
    {
        [Key]
        public int IdWydarzenie { get; set; }
        [Required]
        public DateTime DataPrzeprowadzenia { get; set; }
        [Required]
        public WecieczkaType Typ { get; set; }
        public string Opis { get; set; }
        public List<Kategoria> Kategoria { get; set; } = new List<Kategoria>();

        public Tworca Tworca { get; set; }
        public ICollection<WydarzenieMiejsce> WydarzenieMiejsce { get; set; }
        public ICollection<Skarga> Skarga { get; set; }
        public ICollection<Kometaz> Kometaze { get; set; }
        public ICollection<Ocena> Oceny { get; set; }
        public ICollection<WydarzenieKategoria> WydarzenieKategoria { get; set; }
        public ICollection<UczestnikWydarzenie> UczestnikWydarzenie { get; set; }
        public ICollection<Zdjecie> Zdjecies { get; set; }



    }
}