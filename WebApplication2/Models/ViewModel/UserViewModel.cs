using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModel
{
    public class UserViewModel
    {
        public Guid ID { get; set; }
        public String FullName { get; set; }
        public String Password { get; set; }
        public UserRole UserRole { get; set; }
        public Guid selectedRole { get; set; }
    }
}
