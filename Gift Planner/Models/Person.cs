using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Planner.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("Suffix")]
        public int SuffixId { get; set; }
        public virtual Suffix Suffix { get; set; }
        [ForeignKey("Prefix")]
        public int PrefixId { get; set; }
        public virtual Prefix Prefix { get; set; }
        [NotMapped]
        public string FullName { get { return Prefix + ". " + FirstName + " " + MiddleName + " " + LastName + " " + Suffix; } }
        public string Text { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}