using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Course(string aTitle, string aStream, string aType, DateTime aStartDate, DateTime aEndDate)
        {
            Title = aTitle;
            Stream = aStream;
            Type = aType;
            StartDate = aStartDate;
            EndDate = aEndDate;
        }
    }
}
