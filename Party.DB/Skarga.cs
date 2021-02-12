using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Skarga
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tresc { get; set; }
    }
}