using System.ComponentModel.DataAnnotations;

namespace Research_management.Shared.Entities
{
    public class Researcher
    {
        public int Id { get; set; }

        [Display(Name = "Researcher")]
        [MaxLength(100, ErrorMessage = "The {0} field must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "Field {0} is required.")]
        public string Name { get; set; } = null!;

        [Required]
        public string InstitutionalAffiliation { get; set; } = null!;

        [Required]
        public string Specialization { get; set; } = null!;

        [Required]
        public string Role { get; set; } = null!;   
    }
}
