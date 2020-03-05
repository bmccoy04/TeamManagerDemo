using System.ComponentModel.DataAnnotations;

namespace TeamManagerDemo.Core.Entities
{
    public class Sport : Entity
    {
        [MaxLength(50)]
        public string Name { get; set; }
    }
}