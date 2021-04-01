using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class AssignmentsCourses
    {
        public Course course { get; set; }
        public List<Assignment> Assignments = new List<Assignment>();
        public Assignment Assignment { get; set; }


        public AssignmentsCourses(Assignment aAssignment)
        {
            Assignment = aAssignment;
        }
        public AssignmentsCourses(Course aCourse)
        {
            course = aCourse;
        }
        public AssignmentsCourses()
        {

        }
    }
}
