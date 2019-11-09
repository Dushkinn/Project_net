﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class BookItem
    {
        [Key]
        public Guid ID { get; set;  }
        [Display(Name = "Book State")]
        public StateType State { get; set; }

        [Display(Name = "Book Name")]
        [Required]
        public Book Book { get; set; }

    }
}