using System;
using System.ComponentModel.DataAnnotations;

namespace TeamManagerDemo.Core.Entities
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        
        public bool Deleted { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}