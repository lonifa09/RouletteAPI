using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace RouletteAPI.Data
{
    public class Player : IdentityUser
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        //public virtual IList<Bet> Bets { get; set; }
    }
}
