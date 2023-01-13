using RouletteAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace RouletteAPI.Models
{
    public class CreateBetDTO
    {
        public decimal Amount { get; set; }
        public DateTime BetDate { get; set; }
        public string Status { get; set; }
        public int TableId { get; set; }
        public int TableSectionId { get; set; }
        public int PlayerId { get; set; }
    }
    public class BetDTO : CreateBetDTO
    {
        public int BetId { get; set; }
        public TableDTO Tables { get; set; }
        public TableSectionDTO TableSections { get; set; }
        public PlayerDTO Players { get; set; }
        public virtual IList<PayOutDTO> PayOuts { get; set; }
    }
}
