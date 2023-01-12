using System.Collections.Generic;

namespace RouletteAPI.Data
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual IList<Bet> Bets { get; set; }
    }
}
