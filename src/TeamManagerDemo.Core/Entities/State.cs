using System.ComponentModel.DataAnnotations;

namespace TeamManagerDemo.Core.Entities
{
    public class State : Entity
    {
        [MaxLength(50)]
        [Required]
        [StringLength(50, ErrorMessage = "Name is to long")]
        public string Name { get; set; }
    }
}