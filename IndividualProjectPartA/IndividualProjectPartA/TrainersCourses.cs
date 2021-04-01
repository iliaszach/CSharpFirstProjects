using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class TrainersCourses
    {
        public Trainer trainer { get; set; }
        public List<Course> ListCourses = new List<Course>();
        public TrainersCourses(Trainer aTrainer)
        {
            trainer = aTrainer;
        }
        public TrainersCourses()
        {

        }
    }
}
