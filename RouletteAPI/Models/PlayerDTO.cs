using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RouletteAPI.Models
{
    public class CreatePlayerDTO
    {
        [Required]
        public string Name { get; set; }
    }
    public class PlayerDTO : CreatePlayerDTO
    {
        public int PlayerId { get; set; }
        //public virtual IList<BetDTO> Bets { get; set; }
    }
}
