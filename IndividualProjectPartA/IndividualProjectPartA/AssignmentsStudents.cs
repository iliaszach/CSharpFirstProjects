using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class AssignmentsStudents
    {
        public StudentsCourses StudentCourses { get; set; }
        public List<StudentsCourses> ListStudentCourses { get; set; }
        public Course Courses { get; set; }
        public List<Assignment> ListAssignments = new List<Assignment>();
        public AssignmentsCourses AssignmentsCourses { get; set; }
        public AssignmentsStudents(StudentsCourses aStudentCourses)
        {
            StudentCourses = aStudentCourses;
        }
        public AssignmentsStudents(AssignmentsCourses aAssignmentsCourses)
        {
            AssignmentsCourses = aAssignmentsCourses;
        }
        public AssignmentsStudents(AssignmentsCourses aAssignmentsCourses, StudentsCourses aStudentCourses)
        {
            StudentCourses = aStudentCourses;
            AssignmentsCourses = aAssignmentsCourses;
        }
        public AssignmentsStudents()
        {

        }
    }
}
