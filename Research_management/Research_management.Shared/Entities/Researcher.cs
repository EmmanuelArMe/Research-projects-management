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

        [Required(ErrorMessage = "Please insert a institutional affiliation ")]
        public string InstitutionalAffiliation { get; set; } = null!;

        [Required(ErrorMessage = "Please insert a specialization ")]
        public string Specialization { get; set; } = null!;

        [Required(ErrorMessage = "Please insert a role ")]
        public string Role { get; set; } = null!;   
    }
}
