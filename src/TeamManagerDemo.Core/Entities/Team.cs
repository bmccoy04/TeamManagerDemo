using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamManagerDemo.Core.Entities
{
    public class Team : Entity
    {
        
        [MaxLength(100)]
        public string Name { get; set; }
        
        public ICollection<Player> Players { get; set; }
    }
}