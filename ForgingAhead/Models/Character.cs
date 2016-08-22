using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ForgingAhead.Models
{
    public class Character
    { 
        [Key]        
        [Required]
        [MinLength(3, ErrorMessage="Your character name must be at least 3 characters long.")]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = false;
        
        [Required]
        [Range(1, 20, ErrorMessage = "Your level must be between 1 and 20.")]
        public int Level { get; set; } = 1;
        
        [Required]
        [Range(1, 18, ErrorMessage = "Your base strength must be between 1 and 18.")]
        public int Strength { get; set; } = new Random().Next(1,18);
        [Required(ErrorMessage = "The Dexterity field is required.")]
        [Range(1, 18, ErrorMessage = "Your base dexterity must be between 1 and 18.")]
        public int Dexterity { get; set; } = new Random().Next(1,18);
        [Required]
        [Range(1, 18, ErrorMessage = "Your base intelligence must be between 1 and 18.")]
        public int Intelligence { get; set; } = new Random().Next(1,18);
        
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();
    }
}