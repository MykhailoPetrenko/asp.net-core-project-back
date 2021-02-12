﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Tworca
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NrKonta { get; set; }
        [Required]
        public Double StanKonta { get; set; }
    }
}