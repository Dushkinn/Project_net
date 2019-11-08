using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class StateType
    {
        [Key]
        public Guid Id { get; set; }

        public String StateName { get; set; }
    }
}