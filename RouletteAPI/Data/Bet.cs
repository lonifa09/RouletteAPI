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
        public string Status { get; set; }
        public int PlayerId { get; set; }
        public int TableId { get; set; }
        public int TableSectionId { get; set; }

        //[ForeignKey(nameof(Player))]
        //public Player Player { get; set; }

        //[ForeignKey(nameof(Table))]
        //public Table Table { get; set; }

        //[ForeignKey(nameof(TableSection))]
        //public TableSection TableSection { get; set; }
        public virtual IList<PayOut> PayOuts { get; set; }
    }
}
