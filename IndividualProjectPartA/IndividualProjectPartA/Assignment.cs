using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime subDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        public Assignment(string aTitle, string aDescription, DateTime asubDateTime, int aOralMark, int aTotalMark)
        {
            Title = aTitle;
            Description = aDescription;
            subDateTime = asubDateTime;
            OralMark = aOralMark;
            TotalMark = aTotalMark;
        }
        public Assignment(string aTitle, string aDescription, DateTime asubDateTime)
        {
            Title = aTitle;
            Description = aDescription;
            subDateTime = asubDateTime;
        }
    }
}
