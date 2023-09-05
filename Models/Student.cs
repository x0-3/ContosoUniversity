using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        /* relation with Enrollment object */
        public ICollection<Enrollment>? Enrollments { get; set; } 
    }
}
