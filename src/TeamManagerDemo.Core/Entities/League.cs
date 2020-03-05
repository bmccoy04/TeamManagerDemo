using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TeamManagerDemo.Core.Entities
{
    public class League : Entity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        
        public Location Location { get; set; }
        
        public ContactInfo ContactInfo { get; set; }

        public ICollection<Season> Seasons { get; set; }
    }
}