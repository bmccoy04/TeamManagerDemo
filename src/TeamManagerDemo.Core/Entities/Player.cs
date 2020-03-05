using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TeamManagerDemo.Core.Entities
{
    public class Player : Entity
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [MaxLength(50)]
        public string LastName { get; set; }
        
        public ContactInfo ContactInfo{ get; set; }
    }
}