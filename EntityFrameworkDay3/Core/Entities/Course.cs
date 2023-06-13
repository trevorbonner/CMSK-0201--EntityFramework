
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Course : Entity
    {
        public Course()
        {
            CourseSchedules = new List<CourseSchedule>();
        }

        [Required]
        public int CourseSection { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Must be longer than 5 chars")]
        public string CourseTitle { get; set; }

        [MaxLength(250)]
        public string CourseDescription { get; set; }

        public List<CourseSchedule> CourseSchedules { get; set; }

        [NotMapped]
        public string FullTitle
        {
            get 
            {
                return $"{CourseSection} - {CourseTitle}";
            }
        }
    }
}
