using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User : IdentityUser
    {
        [Key]
        public Guid ID { get; set; }
        [CustomValidation.UserName(ErrorMessage = "First charecters is lower  ")]
        public String FullName { get; set; }
        public String Password { get; set; }
        public UserRole Role { get; set; }
        public ICollection<ReservationBook> ReservationBooks { get; set;}
    }
}