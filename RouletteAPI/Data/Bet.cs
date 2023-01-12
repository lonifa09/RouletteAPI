using RouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RouletteAPI.Data
{
    public class Bet
    {
        public int BetId { get; set; }
        public decimal Amount { get; set; }
        public DateTime BetDate { get; set; }

        [ForeignKey(nameof(Table))]
        public int TableId { get; set; }
        public Table Table { get; set; }

        [ForeignKey(nameof(TableSection))]
        public int TableSectionId { get; set; }
        public TableSection TableSection { get; set; }

        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public virtual IList<Bet> Bets { get; set; }
    }
}
