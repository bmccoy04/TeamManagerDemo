using System.ComponentModel.DataAnnotations;

namespace TeamManagerDemo.Core.Entities
{
    public class State : Entity
    {
        [MaxLength(50)]
        public string Name { get; set; }
    }
}