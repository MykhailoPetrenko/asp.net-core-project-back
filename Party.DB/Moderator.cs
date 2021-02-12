using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Party.DB
{
    public class Moderator
    {
        [Key]
        public int IdModerator { get; set; }
        
        public List<Doswiadczenie> Doswiadczenie { get; set; } = new List<Doswiadczenie>();
    }
}