

using Microsoft.AspNetCore.Identity;
using RouletteAPI.Models;
using System.Collections.Generic;

namespace RouletteAPI.Data
{
    public class ApiUser: IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        //public virtual IList<AspNetRoles> Roles { get; set; }
    }
}
