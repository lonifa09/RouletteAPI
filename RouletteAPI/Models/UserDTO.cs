using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RouletteAPI.Models
{
    public class UserDTO : LoginUserDTO
    {
        public virtual IList<RolesDTO> Roles { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
    }

    public class LoginUserDTO
    { 
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage ="You password is limited to {2} to {1} charactoers", MinimumLength = 8)]
        public string Password { get; set; }    
    
    }
}
