namespace Domain
{
    public class Enrollment : Entity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public bool IsEnrolled { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
