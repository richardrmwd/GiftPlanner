using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Planner.Models
{
    public class GiftIdea
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public string Url { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("CreatedBy")]
        public int CreatedById { get; set; }
        public virtual Person CreatedBy { get; set; }
        [ForeignKey("LastModifiedBy")]
        public int LastModifiedById { get; set; }
        public virtual Person LastModifiedBy { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public string Description { get; set; }
    }
}