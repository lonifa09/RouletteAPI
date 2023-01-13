using RouletteAPI.Data;
using System.Collections.Generic;

namespace RouletteAPI.Models
{
    public class RolesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        //public virtual IList<ApiUser> Users { get; set; }
    }
}
