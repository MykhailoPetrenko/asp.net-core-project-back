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
        public string Opis { get; set; } = string.Empty;
        public List<Kometaz> Kometaz { get; set; } = new List<Kometaz>();
        public List<Ocena> Ocena { get; set; } = new List<Ocena>();
        public List<Kategoria> Kategoria { get; set; } = new List<Kategoria>();
        
    }
}