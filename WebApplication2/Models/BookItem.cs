using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class BookItem
    {
        [Key]
        public Guid ID { get; set;  }
        public StateType State { get; set; }
        public Book Book { get; set; }

    }
}