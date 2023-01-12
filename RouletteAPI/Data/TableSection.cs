using System.Collections.Generic;

namespace RouletteAPI.Data
{
    public class TableSection
    {
        public int TableSectionId { get; set; }
        public string Description { get; set; }
        public virtual IList<Bet> Bets { get; set; }
    }
}
