using System.Collections.Generic;

namespace RouletteAPI.Data
{
    public class Wheel
    {
        public int WheelId { get; set; }
        public int Number { get; set; }
        public string Color { get; set; }
        public virtual IList<Spin> Spins { get; set; }
    }
}
