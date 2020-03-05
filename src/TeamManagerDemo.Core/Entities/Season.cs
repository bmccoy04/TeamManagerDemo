using System.ComponentModel.DataAnnotations;

namespace TeamManagerDemo.Core.Entities
{
    public class Season : Entity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        
        public Team Team { get; set; }
        
        public Sport Sport  { get; set; }
    }
}