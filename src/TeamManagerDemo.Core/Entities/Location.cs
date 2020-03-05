using System.ComponentModel.DataAnnotations;

namespace TeamManagerDemo.Core.Entities
{
    public class Location : Entity
    {
        [MaxLength(50)]
        public string City { get; set; }

        public State State { get; set; } 
        
        [MaxLength(50)]
        public string AddressOne { get; set; }
        
        [MaxLength(50)]
        public string AddressTwo { get; set; }

        [MaxLength(20)]
        public string ZipCode { get; set; }
    }
}