using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RouletteAPI.Models
{
    public class CreateTableSectionDTO
    {
        [Required]
        public string Description { get; set; }
    }
    public class TableSectionDTO : CreateTableSectionDTO
    {
        public int TableSectionId { get; set; }
        public virtual IList<BetDTO> Bets { get; set; }
    }
}
