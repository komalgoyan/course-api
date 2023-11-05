using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models
{
    public class CourseForUpdateDto : CourseForManipulationDto
    {
        [Required(ErrorMessage = "Please enter description.")]
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
