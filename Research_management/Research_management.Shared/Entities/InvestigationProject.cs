using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Research_management.Shared.Entities
{
    public class InvestigationProject
    {
        public int Id { get; set; }

        [Display(Name = "ProjectName")]
        [MaxLength(100, ErrorMessage = "The {0} field must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "{0} field is required.")]
        public string ProjectName { get; set; } = null!;

        [Required(ErrorMessage = "Please insert a start date.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please insert a final date.")]
        public DateTime FinalDate { get; set; }

        [MaxLength(200)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Please insert a investigation field.")]
        public string InvestigationArea { get; set; } = null!;

    }
}
