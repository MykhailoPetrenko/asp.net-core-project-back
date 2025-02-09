﻿using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Osoba
    {
        [Key]
        public string IdOsoba { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Wiek { get; set; }
    }
}