using System.ComponentModel.DataAnnotations;
using System;
namespace LoginReg.Models
{
    public class Quote : BaseEntity
    {
        [Key]
        public long Id {get; set;}
        [Required]
        public string contentField {get; set;}
        
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
        [ForeignKey("User")]
        public User user {get;set;}
    }
}