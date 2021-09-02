using System.ComponentModel.DataAnnotations;
using CourseLibrary.API.ValidationAttributes;

namespace CourseLibrary.API.Models
{
    public abstract class CourseForManipulationDto
    {
        [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "Title must be different from description.")]
        [Required(ErrorMessage = "Title must not be blank.")]
        [MaxLength(100, ErrorMessage = "Title shouldn't be more than 100 character.")]
        public  string Title { get; set; }
        
        [MaxLength(1500, ErrorMessage = "Description shouldn't be more than 1500 character.")]
        public virtual string Description { get; set; }
    }
}