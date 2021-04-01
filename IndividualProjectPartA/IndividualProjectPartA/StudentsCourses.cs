using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class StudentsCourses
    {
        public Student student { get; set; }
        public Course course { get; set; }

        public List<Course> ListCourses = new List<Course>();
        public AssignmentsCourses assignmentsCourses { get; set; }

        AssignmentsStudents AssignmentsStudents { get; set; }
        public StudentsCourses(Student aStudent)
        {
            student = aStudent;

        }
        public StudentsCourses()
        {

        }
    }
}
