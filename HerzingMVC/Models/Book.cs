﻿using System.ComponentModel.DataAnnotations;

namespace HerzingMVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
