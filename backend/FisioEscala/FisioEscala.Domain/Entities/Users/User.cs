using FisioEscala.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FisioEscala.Domain.Entities.Users
{
    [Table("Users")]
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; private set; }

        [Required]
        [EmailAddress]
        public string Email { get; private set; }

        public User(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
