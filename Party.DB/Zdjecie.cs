﻿using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Zdjecie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        public string Url { get; set; }
    }
}