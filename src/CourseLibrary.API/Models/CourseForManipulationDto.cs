using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models
{
    public abstract class CourseForManipulationDto : IValidatableObject
    {
        [Required(ErrorMessage = "Title should not be empty..")]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(1500, ErrorMessage = "The description should not be more than 1500.")]
        public virtual string Description { get; set; } = string.Empty;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title == Description)
            {
                yield return new ValidationResult("Title should not be same as description.", new[] { "Course" });
            }
        }
    }
}
