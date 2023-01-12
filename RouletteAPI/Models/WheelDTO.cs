using RouletteAPI.Data;
using System.Collections.Generic;

namespace RouletteAPI.Models
{
    public class CreateWheelDTO
    {
        public int Number { get; set; }
        public string Color { get; set; }
    }
    public class WheelDTO : CreateWheelDTO
    {
        public int WheelId { get; set; }
        public virtual IList<SpinDTO> Spins { get; set; }
    }
}
