using System.Collections.Generic;

namespace RouletteAPI.Data
{
    public class Table
    {
        public int TableId { get; set; }
        public int Number { get; set; }
        public string Color { get; set; }
        public string Range { get; set; }
        public string Polarity { get; set; }
        public virtual IList<Bet> Bets { get; set; }
    }
}
