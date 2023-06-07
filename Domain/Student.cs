namespace Domain
{
    public class Student : Entity
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        public List<Enrollment> Enrollments { get; set; }
        public string Firstname {get; set;}
        public string Lastname {get; set;}
    }
}
