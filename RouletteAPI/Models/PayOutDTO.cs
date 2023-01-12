using RouletteAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace RouletteAPI.Models
{
    public class CreatePayOutDTO
    {
        public decimal Amount { get; set; }
        public DateTime PayOutDate { get; set; }
        public int BetId { get; set; }
    }
    public class PayOutDTO
    {
        public int PayOutId { get; set; }
    }
}
