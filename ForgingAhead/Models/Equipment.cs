using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models
{
    public class Equipment
    {
        [Key]        
        [Required]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters long.")]
        public string Name { get; set; }
        
        [Required]
        [Range(0, 20, ErrorMessage = "Equipment's base attack must be between 0 and 20.")]
        public int Attack { get; set; } = 0;
        
        [Required]
        [Range(0, 20, ErrorMessage = "Equipment's base defense must be between 0 and 20.")]
        public int Defense { get; set; } = 0;
    }
}