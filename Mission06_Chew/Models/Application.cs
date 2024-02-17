using System.ComponentModel.DataAnnotations;

namespace Mission06_Chew.Models
{
    public class Application
    {
        [Key] public int MovieID { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [RegularExpression(@"^(\d{4}|\d{4}-\d{4})$", ErrorMessage = "Year must be a four-digit number or a range (e.g., 2001-2002)")]
        public string Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string? LentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be more than 25 characters long.")]
        public string? Notes { get; set; }
    }
}
