using System.ComponentModel.DataAnnotations;

namespace FisioEscala.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
    }
}
