using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace LoginReg.Models
{
    public abstract class BaseEntity {}
    public class User : BaseEntity 
    {
        public User(){
            quotes = new List<Quote>();
        }
        [Key]
        public int Id {get; set;}
        [Required(ErrorMessage="First name is required")]
        [MinLength(2, ErrorMessage= "First name must be at least 2 characters")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage="First name must only contain letters")]
        public string fname {get; set;}
        [Required(ErrorMessage="Last name is required")]
        [MinLength(2, ErrorMessage= "Last name must be at least 2 characters")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage="Last name must only contain letters")]
        public string lname {get; set;}
        [Required(ErrorMessage="Email is required")]
        [EmailAddress(ErrorMessage = "Email is invalid")]
        public string email{get; set;}
        [Required(ErrorMessage="Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string pass {get; set;}
        [Required(ErrorMessage="Password confirmation is required")]
        public string confpass{get;set;}
        public DateTime created_at{get;set;}
        public DateTime updated_at{get;set;}
        public ICollection<Quote> quotes {get;set;}
    }
}