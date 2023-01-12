using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RouletteAPI.Data
{
    public class Spin
    {
        public int SpinId { get; set; }
        public DateTime SpinDate { get; set; }

        [ForeignKey(nameof(Wheel))]
        public int WheelId { get; set; }
        public Wheel Wheel { get; set; }

        [ForeignKey(nameof(Bet))]
        public int BetId { get; set; }
        public Bet Bet { get; set; }
    }
}
