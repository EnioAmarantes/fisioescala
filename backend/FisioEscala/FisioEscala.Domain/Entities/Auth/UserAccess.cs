using FisioEscala.Domain.Entities.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FisioEscala.Domain.Entities.Auth
{
    public class UserAccess : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress] 
        public string Email { get; set; }

        [Required]
        [PasswordPropertyText(true)]
        public string Password { get; set; }
    }
}
