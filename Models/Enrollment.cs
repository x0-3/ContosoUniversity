namespace ContosoUniversity.Models
{

    public enum Grade
    {
        A, B, C, D, E, F
    }

    public class Enrollment
    {

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; } // foreign key
        public int StudentID { get; set; } // foreign key
        public Grade? Grade { get; set; }

        public Course? Course { get; set; } // relation between the two entities
        public Student? Student { get; set; } // relation between the two entities
    }
}
