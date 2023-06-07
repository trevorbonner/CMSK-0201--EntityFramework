namespace Domain
{
    public class Course : Entity
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
        }

        public string Name { get; set; }
        public int Hours { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
