using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Prywatny
    {
        [Key]
        public int IdPrywatny { get; set; }
        [Required]
        public string NazwaOrganizacja { get; set; }
    }
}