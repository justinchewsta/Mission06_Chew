﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Chew.Models
{
    public class Application
    {
        [Key] public int MovieID { get; set; }

        [ForeignKey("CategoryID")]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }

        public string? Notes { get; set; }
    }
}
