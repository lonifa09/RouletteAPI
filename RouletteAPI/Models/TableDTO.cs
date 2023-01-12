using RouletteAPI.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RouletteAPI.Models
{
    public class CreateTableDTO
    {
        [Required]
        [Range(0, 38)]
        public int Number { get; set; }
        [Required]
        [StringLength(maximumLength:10, ErrorMessage = "Color name is twoo long")]
        public string Color { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string Range { get; set; }
        public string Polarity { get; set; }
    }
    public class TableDTO : CreateTableDTO
    {
        public int TableId { get; set; }
        public virtual IList<BetDTO> Bets { get; set; }

    }
}
