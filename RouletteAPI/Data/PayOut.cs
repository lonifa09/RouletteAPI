using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RouletteAPI.Data
{
    public class PayOut
    {
        public int PayOutId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PayOutDate { get; set; }

        [ForeignKey(nameof(Bet))]
        public int BetId { get; set; }
        public Bet Bet { get; set; }
    }
}
