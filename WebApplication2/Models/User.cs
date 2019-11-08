using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        public String FullName { get; set; }
        public String Password { get; set; }
        public UserRole Role { get; set; }

    }
}