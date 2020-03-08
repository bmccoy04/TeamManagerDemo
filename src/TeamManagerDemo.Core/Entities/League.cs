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

    public class ManageLeagueDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ContactName { get; set; }
        public int NumberOfSeasons { get; set; }
    }
}