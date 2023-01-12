using RouletteAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace RouletteAPI.Models
{
    public class SpinDTO : CreateSpinDTO
    {
        public int SpinId { get; set; }
        public Wheel Wheel { get; set; }
        public Bet Bet { get; set; }
    }
    public class CreateSpinDTO
    {
        public DateTime SpinDate { get; set; }
        public int WheelId { get; set; }
        public int BetId { get; set; }
    }
}
