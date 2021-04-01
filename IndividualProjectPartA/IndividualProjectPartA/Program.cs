using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class Program
    {
        #region Set methods
        private static void SetAssignToStudents(int aStudent, int aCourse, int aAssignment)
        {
            int student = aStudent - 1;
            int course = aCourse - 1;
            int assignment = aAssignment - 1;
            string title = assignments[assignment].Title;
            int assignmentIndex = 0;
            for (int i = 0; i < assignments.Count; i++)
            {
                if (title == assignments[i].Title)
                {
                    assignmentIndex = i;
                    break;
                }
            }
            int assignList = AssignmentsCourses[course].Assignments.Count;
            if (assignList == 1)
            {
                for (int i = 0; i < assignList; i++)
                {
                    if (AssignmentsCourses[course].Assignments[i].Title != title)
                    {
                        AssignmentsStudents[student].AssignmentsCourses.Assignments.Add(assignments[assignmentIndex]);
                        Console.WriteLine($"{assignments[assignmentIndex].Title} added to the course {AssignmentsCourses[course].course.Stream}");
                    }
                    else
                    {
                        Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                        break;
                    }
                }
            }
            if (assignList == 2)
            {
                for (int i = 0; i < assignList; i++)
                {
                    if (AssignmentsCourses[course].Assignments[i].Title != title)
                    {
                        i++;
                        if (AssignmentsCourses[course].Assignments[i].Title != title)
                        {
                            AssignmentsStudents[student].AssignmentsCourses.Assignments.Add(assignments[assignmentIndex]);
                            Console.WriteLine($"{assignments[assignmentIndex].Title} added to the course {AssignmentsCourses[course].course.Stream}");
                        }
                        else
                        {
                            Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                        break;
                    }
                }
            }
            if (assignList == 3)
            {
                for (int i = 0; i < assignList; i++)
                {
                    if (AssignmentsCourses[course].Assignments[i].Title != title)
                    {
                        i++;
                        if (AssignmentsCourses[course].Assignments[i].Title != title)
                        {
                            i++;
                            if (AssignmentsCourses[course].Assignments[i].Title != title)
                            {
                                AssignmentsStudents[student].AssignmentsCourses.Assignments.Add(assignments[assignmentIndex]);
                                Console.WriteLine($"{assignments[assignmentIndex].Title} added to the course {AssignmentsCourses[course].course.Stream}");
                            }
                            else
                            {
                                Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                        break;
                    }
                }
            }
            if (assignList == 4)
            {
                for (int i = 0; i < assignList; i++)
                {
                    if (AssignmentsCourses[course].Assignments[i].Title != title)
                    {
                        i++;
                        if (AssignmentsCourses[course].Assignments[i].Title != title)
                        {
                            i++;
                            if (AssignmentsCourses[course].Assignments[i].Title != title)
                            {
                                i++;
                                if (AssignmentsCourses[course].Assignments[i].Title != title)
                                {
                                    AssignmentsStudents[student].AssignmentsCourses.Assignments.Add(assignments[assignmentIndex]);
                                    Console.WriteLine($"{assignments[assignmentIndex].Title} added to the course {AssignmentsCourses[course].course.Stream}");
                                }
                                else
                                {
                                    Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                        break;
                    }
                }
            }
        }
        private static void SetAssignToCourse(int aCourse, int aAssignment)
        {
            int course = aCourse - 1;
            int assignment = aAssignment - 1;
            string title = assignments[assignment].Title;
            int assignmentIndex = 0;
            for (int i = 0; i < assignments.Count; i++)
            {
                if (title == assignments[i].Title)
                {
                    assignmentIndex = i;
                    break;
                }
            }
            int assignList = AssignmentsCourses[course].Assignments.Count;
            if (assignList == 1)
            {
                for (int i = 0; i < assignList; i++)
                {
                    if (AssignmentsCourses[course].Assignments[i].Title != title)
                    {
                        AssignmentsCourses[course].Assignments.Add(assignments[assignmentIndex]);
                        Console.WriteLine($"{assignments[assignmentIndex].Title} added to the course {AssignmentsCourses[course].course.Stream}");
                    }
                    else
                    {
                        Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                        break;
                    }
                }
            }
            if (assignList == 2)
            {
                for (int i = 0; i < assignList; i++)
                {
                    if (AssignmentsCourses[course].Assignments[i].Title != title)
                    {
                        i++;
                        if (AssignmentsCourses[course].Assignments[i].Title != title)
                        {
                            AssignmentsCourses[course].Assignments.Add(assignments[assignmentIndex]);
                            Console.WriteLine($"{assignments[assignmentIndex].Title} added to the course {AssignmentsCourses[course].course.Stream}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                        break;
                    }
                }
            }
            if (assignList == 3)
            {
                for (int i = 0; i < assignList; i++)
                {
                    if (AssignmentsCourses[course].Assignments[i].Title != title)
                    {
                        i++;
                        if (AssignmentsCourses[course].Assignments[i].Title != title)
                        {
                            i++;
                            if (AssignmentsCourses[course].Assignments[i].Title != title)
                            {
                                AssignmentsCourses[course].Assignments.Add(assignments[assignmentIndex]);
                                Console.WriteLine($"{assignments[assignmentIndex].Title} added to the course {AssignmentsCourses[course].course.Stream}");
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                        break;
                    }
                }
            }
            if (assignList == 4)
            {
                for (int i = 0; i < assignList; i++)
                {
                    if (AssignmentsCourses[course].Assignments[i].Title != title)
                    {
                        i++;
                        if (AssignmentsCourses[course].Assignments[i].Title != title)
                        {
                            i++;
                            if (AssignmentsCourses[course].Assignments[i].Title != title)
                            {
                                i++;
                                if (AssignmentsCourses[course].Assignments[i].Title != title)
                                {
                                    AssignmentsCourses[course].Assignments.Add(assignments[assignmentIndex]);
                                    Console.WriteLine($"{assignments[assignmentIndex].Title} added to the course {AssignmentsCourses[course].course.Stream}");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{assignments[assignmentIndex].Title} is already added to the course {AssignmentsCourses[course].course.Stream}");
                        break;
                    }
                }
            }
        }
        private static void SetCourseTr(int index, int course)
        {
            int trainer = index - 1;
            int acourse = course - 1;
            string stream = courses[acourse].Stream;
            int courseIndex = 0;
            for (int x = 0; x < courses.Count; x++)
            {
                if (stream == courses[x].Stream)
                {
                    courseIndex = x;
                    break;
                }
            }
            int i = 0;
            int courseList = TrainersCourses[trainer].ListCourses.Count;
            if (courseList == 1)
            {
                if (TrainersCourses[trainer].ListCourses[i].Stream != stream)
                {
                    TrainersCourses[trainer].ListCourses.Add(courses[courseIndex]);
                    Console.WriteLine($"{TrainersCourses[trainer].trainer.FirstName} {TrainersCourses[trainer].trainer.LastName} added to the course {stream}.");
                }
                else
                {
                    Console.WriteLine($"{TrainersCourses[trainer].trainer.FirstName} {TrainersCourses[trainer].trainer.LastName} is already added to {stream}");
                }
            }
            if (courseList == 2)
            {
                if (TrainersCourses[trainer].ListCourses[i].Stream != stream && TrainersCourses[trainer].ListCourses[i + 1].Stream != stream)
                {
                    TrainersCourses[trainer].ListCourses.Add(courses[courseIndex]);
                    Console.WriteLine($"{TrainersCourses[trainer].trainer.FirstName} {TrainersCourses[trainer].trainer.LastName} added to the course {stream}");
                }
                else
                {
                    Console.WriteLine($"{TrainersCourses[trainer].trainer.FirstName} {TrainersCourses[trainer].trainer.LastName} is already added to {stream}");
                }
            }
            if (courseList == 3)
            {
                if (TrainersCourses[trainer].ListCourses[i].Stream != stream && TrainersCourses[trainer].ListCourses[i + 1].Stream != stream && TrainersCourses[trainer].ListCourses[i + 2].Stream != stream)
                {
                    TrainersCourses[trainer].ListCourses.Add(courses[courseIndex]);
                    Console.WriteLine($"{TrainersCourses[trainer].trainer.FirstName} {TrainersCourses[trainer].trainer.LastName} added to the course {stream}");
                }
                else
                {
                    Console.WriteLine($"{TrainersCourses[trainer].trainer.FirstName} {TrainersCourses[trainer].trainer.LastName} is already added to {stream}");
                }
            }
            if (courseList == 4)
            {
                if (TrainersCourses[trainer].ListCourses[i].Stream != stream && TrainersCourses[trainer].ListCourses[i + 1].Stream != stream && TrainersCourses[trainer].ListCourses[i + 2].Stream != stream && TrainersCourses[trainer].ListCourses[i + 3].Stream != stream)
                {
                    TrainersCourses[trainer].ListCourses.Add(courses[courseIndex]);
                    Console.WriteLine($"{TrainersCourses[trainer].trainer.FirstName} {TrainersCourses[trainer].trainer.LastName} added to the course {stream}");
                }
                else
                {
                    Console.WriteLine($"{TrainersCourses[trainer].trainer.FirstName} {TrainersCourses[trainer].trainer.LastName} is already added to {stream}");
                }
            }
        }
        private static void SetCourseSt(int index, int course)
        {
            int student = index - 1;
            int acourse = course - 1;
            string stream = courses[acourse].Stream;
            int courseIndex = 0;
            for (int x = 0; x < courses.Count; x++)
            {
                if (stream == courses[x].Stream)
                {
                    courseIndex = x;
                    break;
                }
            }
            int i = 0;
            int courseList = StudentsCourses[student].ListCourses.Count;
            if (courseList == 1)
            {
                if (StudentsCourses[student].ListCourses[i].Stream != stream)
                {
                    StudentsCourses[student].ListCourses.Add(courses[acourse]);
                    Console.WriteLine($"{StudentsCourses[student].student.FirstName} {StudentsCourses[student].student.LastName} added to the course {stream}.");
                    AssignmentsStudents.Add(new AssignmentsStudents(StudentsCourses[StudentsCourses.Count - 1]));
                }
                else
                {
                    Console.WriteLine($"{StudentsCourses[student].student.FirstName} {StudentsCourses[student].student.LastName} is already added to {stream}");
                }
            }
            if (courseList == 2)
            {
                if (StudentsCourses[student].ListCourses[i].Stream != stream && StudentsCourses[student].ListCourses[i + 1].Stream != stream)
                {
                    StudentsCourses[student].ListCourses.Add(courses[acourse]);
                    Console.WriteLine($"{StudentsCourses[student].student.FirstName} {StudentsCourses[student].student.LastName} added to {stream}");
                    AssignmentsStudents.Add(new AssignmentsStudents(StudentsCourses[StudentsCourses.Count - 1]));
                }
                else
                {
                    Console.WriteLine($"{StudentsCourses[student].student.FirstName} {StudentsCourses[student].student.LastName} is already added to {stream}");
                }
            }
            if (courseList == 3)
            {
                if (StudentsCourses[student].ListCourses[i].Stream != stream && StudentsCourses[student].ListCourses[i + 1].Stream != stream && StudentsCourses[student].ListCourses[i + 2].Stream != stream)
                {
                    StudentsCourses[student].ListCourses.Add(courses[acourse]);
                    Console.WriteLine($"{StudentsCourses[student].student.FirstName} {StudentsCourses[student].student.LastName} added to {stream}");
                    AssignmentsStudents.Add(new AssignmentsStudents(StudentsCourses[StudentsCourses.Count - 1]));
                }
                else
                {
                    Console.WriteLine($"{StudentsCourses[student].student.FirstName} {StudentsCourses[student].student.LastName} is already added to {stream}");
                }
            }
            if (courseList == 4)
            {
                if (StudentsCourses[student].ListCourses[i].Stream != stream && StudentsCourses[student].ListCourses[i + 1].Stream != stream && StudentsCourses[student].ListCourses[i + 2].Stream != stream && StudentsCourses[student].ListCourses[i + 3].Stream != stream)
                {
                    StudentsCourses[student].ListCourses.Add(courses[acourse]);
                    Console.WriteLine($"{StudentsCourses[student].student.FirstName} {StudentsCourses[student].student.LastName} added to {stream}");
                    AssignmentsStudents.Add(new AssignmentsStudents(StudentsCourses[StudentsCourses.Count - 1]));
                }
                else
                {
                    Console.WriteLine($"{StudentsCourses[student].student.FirstName} {StudentsCourses[student].student.LastName} is already added to {stream}");
                }
            }
        }
        #endregion

        #region Students per Courses Methods
        private static void PrintDefaultStudentsMoreCourses(List<StudentsCourses> StudentsCourses)
        {
            Console.Clear();
            Console.WriteLine("List of Students that belong to more than one courses");
            int counter = 1;

            foreach (var studentPercourse in StudentsCourses)
            {
                if (studentPercourse.ListCourses.Count > 1)
                {
                    Console.WriteLine($"{counter})Student: {studentPercourse.student.FirstName} {studentPercourse.student.LastName} belongs to {studentPercourse.ListCourses.Count} courses.");
                    Console.WriteLine("Courses: ");
                    char _char = 'a';
                    for (int i = 0; i < studentPercourse.ListCourses.Count; i++)
                    {
                        Console.WriteLine($"{_char}){studentPercourse.ListCourses[i].Stream} ");
                        _char++;
                    }
                    counter++;
                }
            }
            Console.ReadKey();
        }
        private static void StudentsPerCourseInput()
        {
            Console.Clear();
            Console.WriteLine("Choose, by the index on the left, the student you want to modifie the course choice");
            int counter = 1;
            foreach (var student in StudentsCourses)
            {
                Console.WriteLine($"{counter}] {student.student.FirstName} {student.student.LastName}");
                char _char = 'a';
                for (int i = 0; i < student.ListCourses.Count; i++)
                {
                    Console.WriteLine($"\t{_char}] {student.ListCourses[i].Stream}");
                    _char++;
                }
                counter++;
            }
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose, by the index on the left, the course");
            int acounter = 1;
            foreach (var _course in courses)
            {
                Console.WriteLine($"{acounter}) Title: {_course.Stream}");
                acounter++;
            }
            int numCourse = Convert.ToInt32(Console.ReadLine());
            SetCourseSt(num, numCourse);
            Console.ReadKey();

        }
        private static void DefaultStudentsPerCourses()
        {
            StudentsCourses stcourse = new StudentsCourses();
            stcourse.student = Students[0];
            stcourse.ListCourses.Add(courses[0]);

            StudentsCourses stcourse1 = new StudentsCourses();
            stcourse1.student = Students[1];
            stcourse1.ListCourses.Add(courses[1]);
            stcourse1.ListCourses.Add(courses[3]);

            StudentsCourses stcourse2 = new StudentsCourses();
            stcourse2.student = Students[2];
            stcourse2.ListCourses.Add(courses[2]);

            StudentsCourses stcourse3 = new StudentsCourses();
            stcourse3.student = Students[3];
            stcourse3.ListCourses.Add(courses[3]);
            stcourse3.ListCourses.Add(courses[2]);
            stcourse3.ListCourses.Add(courses[1]);

            StudentsCourses stcourse4 = new StudentsCourses();
            stcourse4.student = Students[4];
            stcourse4.ListCourses.Add(courses[0]);

            StudentsCourses stcourse5 = new StudentsCourses();
            stcourse5.student = Students[5];
            stcourse5.ListCourses.Add(courses[1]);

            StudentsCourses stcourse6 = new StudentsCourses();
            stcourse6.student = Students[6];
            stcourse6.ListCourses.Add(courses[2]);

            StudentsCourses stcourse7 = new StudentsCourses();
            stcourse7.student = Students[7];
            stcourse7.ListCourses.Add(courses[3]);

            StudentsCourses stcourse8 = new StudentsCourses();
            stcourse8.student = Students[8];
            stcourse8.ListCourses.Add(courses[0]);
            stcourse8.ListCourses.Add(courses[1]);

            StudentsCourses stcourse9 = new StudentsCourses();
            stcourse9.student = Students[9];
            stcourse9.ListCourses.Add(courses[1]);

            StudentsCourses.Add(stcourse); StudentsCourses.Add(stcourse1);
            StudentsCourses.Add(stcourse2); StudentsCourses.Add(stcourse3);
            StudentsCourses.Add(stcourse4); StudentsCourses.Add(stcourse5);
            StudentsCourses.Add(stcourse6); StudentsCourses.Add(stcourse7);
            StudentsCourses.Add(stcourse8); StudentsCourses.Add(stcourse9);
        }
        private static void PrintDefaultStudentsPerCourses(List<StudentsCourses> studentPercourses)
        {
            Console.Clear();
            Console.WriteLine("Students per Courses");
            int counter = 1;
            foreach (var studentPercourse in StudentsCourses)
            {
                Console.WriteLine($"{counter})Student: {studentPercourse.student.FirstName} {studentPercourse.student.LastName}.");
                Console.WriteLine("Courses: ");
                char _char = 'a';
                for (int i = 0; i < studentPercourse.ListCourses.Count; i++)
                {
                    Console.WriteLine($"\t{_char}){studentPercourse.ListCourses[i].Stream} ");
                    _char++;
                }
                counter++;
            }
            Console.ReadKey();
        }
        #endregion

        #region Students Methods
        private static void DefaultStudents()
        {
            Console.Clear();
            Students.Add(new Student("Ilias", "Zax", new DateTime(1989, 4, 15), 5000));
            Students.Add(new Student("Kostis", "Zax", new DateTime(1990, 7, 21), 4500));
            Students.Add(new Student("Alex", "Koz", new DateTime(1992, 1, 20), 2000));
            Students.Add(new Student("Maria", "Kal", new DateTime(1994, 2, 7), 3500));
            Students.Add(new Student("Gogo", "Pap", new DateTime(1995, 5, 5), 4000));
            Students.Add(new Student("Aliki", "Kost", new DateTime(1995, 8, 8), 2000));
            Students.Add(new Student("Maria", "Pop", new DateTime(1997, 9, 25), 4500));
            Students.Add(new Student("Ioanna", "Kol", new DateTime(1992, 4, 14), 2700));
            Students.Add(new Student("Alexandra", "Lol", new DateTime(1994, 7, 11), 3500));
            Students.Add(new Student("Nefeli", "Mane", new DateTime(1992, 2, 5), 5000));
        }//
        private static void PrintDefaultStudents(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("Deafult list of Students");
            int counter = 1;
            foreach (var i in Students)
            {
                Console.WriteLine($"{counter})Name={i.FirstName} {i.LastName}, date of Birth = {i.DateOfBirth.ToShortDateString()}, Tuition fees = {i.TuitionFees}");
                counter++;
            }
            Console.ReadKey();
        }//
        private static void StudentInput()
        {
            Console.Clear();
            Console.WriteLine("Add Students");
            bool set = true;
            while (set)
            {
                Console.Write("Enter first name: ");
                string aFirstName = Console.ReadLine();
                Console.Write("Enter Last name: ");
                string aLastName = Console.ReadLine();
                Console.Write("Enter the date of  birth: ");
                DateTime aDateOfBirth = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the tuition fees: ");
                int aTuitionFees = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Choose from the above list the course for {aFirstName}: ");
                int counter = 1;
                foreach (var _course in courses)
                {
                    Console.WriteLine($"{counter}. Title: {_course.Title}, Stream: {_course.Stream}, Type: {_course.Type}, Start date: {_course.StartDate}, End Date: {_course.EndDate}");
                    counter++;
                }
                int course = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine($"{aFirstName} {aLastName} added to the course {courses[course].Stream}");

                Students.Add(new Student(aFirstName, aLastName, aDateOfBirth, aTuitionFees));
                StudentsCourses.Add(new StudentsCourses(Students[Students.Count - 1]));
                StudentsCourses[StudentsCourses.Count - 1].ListCourses.Add(courses[course]);
                Console.WriteLine("Do you want to add another student?");
                Console.WriteLine("1. Yes \n2. No");
                var answer = Console.ReadLine();
                if (answer == "2")
                {
                    set = false;
                }
                Console.Clear();
            }
            Console.ReadKey();
        }//
        #endregion

        #region Trainers per Course Methods
        private static void DefaultTrainersPerCourses()
        {
            TrainersCourses takakis = new TrainersCourses();
            takakis.trainer = trainers[0];
            takakis.ListCourses.Add(courses[0]);
            TrainersCourses georgiou = new TrainersCourses();
            georgiou.trainer = trainers[1];
            georgiou.ListCourses.Add(courses[1]);
            TrainersCourses ethi = new TrainersCourses();
            ethi.trainer = trainers[2];
            ethi.ListCourses.Add(courses[1]);
            TrainersCourses muza = new TrainersCourses();
            muza.trainer = trainers[3];
            muza.ListCourses.Add(courses[2]);
            TrainersCourses babis = new TrainersCourses();
            babis.trainer = trainers[4];
            babis.ListCourses.Add(courses[3]);

            TrainersCourses.Add(takakis);
            TrainersCourses.Add(georgiou);
            TrainersCourses.Add(ethi);
            TrainersCourses.Add(babis);

        }
        private static void PrintDefaultTrainersPerCourses(List<TrainersCourses> trainersCourses)
        {
            Console.Clear();
            Console.WriteLine("Deafult Trainers per Courses");
            int counter = 1;

            foreach (var trainerPercourse in trainersCourses)
            {
                Console.WriteLine($"{counter})Trainer {trainerPercourse.trainer.FirstName} {trainerPercourse.trainer.LastName} teaches:");
                char _char = 'a';
                for (int i = 0; i < trainerPercourse.ListCourses.Count; i++)
                {
                    Console.WriteLine($"\t{_char}) {trainerPercourse.ListCourses[i].Stream}");
                    _char++;
                }
                counter++;
            }
            Console.ReadKey();
        }
        private static void TrainerPerCourseInput()
        {
            Console.Clear();

            Console.WriteLine("Choose, by the index on the left, the trainer you want to point for the course");
            int _counter = 1;
            foreach (var trainer in TrainersCourses)
            {
                Console.WriteLine($"{_counter}] {trainer.trainer.FirstName} {trainer.trainer.LastName} teaches:");
                char _char = 'a';
                for (int i = 0; i < trainer.ListCourses.Count; i++)
                {
                    Console.WriteLine($"\t{_char}] {trainer.ListCourses[i].Stream}");
                    _char++;
                }
                _counter++;
            }
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose, by the index on the left, the course");
            int acounter = 1;
            foreach (var _course in courses)
            {
                Console.WriteLine($"{acounter}) Title: {_course.Stream}");
                acounter++;
            }
            int numCourse = Convert.ToInt32(Console.ReadLine());

            SetCourseTr(num, numCourse);

            Console.ReadKey();
        }
        #endregion

        #region Trainers Methods

        private static void DefaultTrainers()
        {
            Console.Clear();
            Console.WriteLine("Deafult list of Trainers");
            trainers.Add(new Trainer("Konstantinos", "Takakis", "C#"));
            trainers.Add(new Trainer("Panos", "Georgiou", "Java"));
            trainers.Add(new Trainer("George", "Eythimiadis", "Java"));
            trainers.Add(new Trainer("Konstantinos", "Kol", "C++"));
            trainers.Add(new Trainer("Mpampis", "Markos", "Python"));
        }
        private static void PrintDefaultTrainers(List<Trainer> trainers)
        {
            Console.Clear();
            int counter = 1;
            foreach (var _trainer in trainers)
            {
                Console.WriteLine($"{counter})Name={_trainer.FirstName} {_trainer.LastName}, Subject = {_trainer.Subject}");
                counter++;
            }
            Console.ReadKey();
        }
        private static void TrainerInput()
        {
            Console.Clear();
            Console.WriteLine("Add Trainers");
            bool set = true;
            while (set)
            {
                Console.Write("Enter first name: ");
                string aFirstName = Console.ReadLine();
                Console.Write("Enter Last name: ");
                string aLastName = Console.ReadLine();
                Console.WriteLine("Choose from the above list the subject: ");
                int counter = 1;
                foreach (var _course in courses)
                {
                    Console.WriteLine($"{counter}. Title: {_course.Title}, Stream: {_course.Stream}, Type: {_course.Type}, Start date: {_course.StartDate}, End Date: {_course.EndDate}");
                    counter++;
                }
                int course = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine($"{aFirstName} {aLastName} added to the course {courses[course].Stream}");
                string aSubject = courses[course].Stream;
                trainers.Add(new Trainer(aFirstName, aLastName, aSubject));
                TrainersCourses.Add(new TrainersCourses(trainers[trainers.Count - 1]));
                TrainersCourses[TrainersCourses.Count - 1].ListCourses.Add(courses[course]);
                Console.WriteLine("Options: \n1. Add more press enter, \n2. to exit");
                string answer = Console.ReadLine();
                if (answer == "2")
                {
                    set = false;
                }
            }
            Console.ReadKey();
        }
        #endregion

        #region DateTime Method

        public static void ShowAssignments(List<AssignmentsStudents> assignmentsStudents)
        {
            Console.Clear();
            Console.WriteLine("Give me the today date");
            DateTime baseDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"You choose the date: {baseDate:d}");
            DateTime startDay = new DateTime();
            DateTime endDay = new DateTime();

            if (baseDate.DayOfWeek == DayOfWeek.Monday)
            {
                startDay = baseDate.AddDays(0);
                endDay = baseDate.AddDays(4);
            }
            else if (baseDate.DayOfWeek == DayOfWeek.Tuesday)
            {
                startDay = baseDate.AddDays(-1);
                endDay = baseDate.AddDays(3);
            }
            else if (baseDate.DayOfWeek == DayOfWeek.Wednesday)
            {
                startDay = baseDate.AddDays(-2);
                endDay = baseDate.AddDays(2);
            }
            else if (baseDate.DayOfWeek == DayOfWeek.Thursday)
            {
                startDay = baseDate.AddDays(-3);
                endDay = baseDate.AddDays(1);
            }
            else if (baseDate.DayOfWeek == DayOfWeek.Friday)
            {
                startDay = baseDate.AddDays(-4);
                endDay = baseDate.AddDays(0);
            }
            else if (baseDate.DayOfWeek == DayOfWeek.Saturday)
            {
                startDay = baseDate.AddDays(-5);
                endDay = baseDate.AddDays(-1);
            }
            else if (baseDate.DayOfWeek == DayOfWeek.Sunday)
            {
                startDay = baseDate.AddDays(-6);
                endDay = baseDate.AddDays(-2);
            }

            Console.WriteLine($"List of Students who need to submit assignments between {startDay.ToString("d")} and {endDay.ToString("d")}");
            int count = 1;
            foreach (var student in assignmentsStudents)
            {
                for (int a = 0; a < student.AssignmentsCourses.Assignments.Count; a++)
                {
                    if (student.AssignmentsCourses.Assignments[a].subDateTime == startDay || student.AssignmentsCourses.Assignments[a].subDateTime == startDay.AddDays(1) || student.AssignmentsCourses.Assignments[a].subDateTime == startDay.AddDays(2) || student.AssignmentsCourses.Assignments[a].subDateTime == startDay.AddDays(3) || student.AssignmentsCourses.Assignments[a].subDateTime == startDay.AddDays(4))
                    {
                        Console.WriteLine($"{count}. The student {student.StudentCourses.student.FirstName} {student.StudentCourses.student.LastName} has the above assignments:");
                        count++;
                        char c = 'a';
                        for (int i = 0; i < student.AssignmentsCourses.Assignments.Count; i++)
                        {
                            Console.WriteLine($"{c}. {student.AssignmentsCourses.Assignments[i].Title} on {student.AssignmentsCourses.Assignments[i].subDateTime.ToShortDateString()}");
                            c++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("*********");
                    }
                }

            }
            Console.ReadKey();
        }

        #endregion

        #region Courses Methods
        private static void DefaultCourses()
        {
            Console.Clear();
            courses.Add(new Course("CB13", "C#", "Full Time", new DateTime(2021, 01, 15), new DateTime(2021, 09, 15)));
            courses.Add(new Course("CB14", "Java", "Full Time", new DateTime(2021, 01, 15), new DateTime(2021, 09, 15)));
            courses.Add(new Course("CB11", "C++", "Full Time", new DateTime(2021, 01, 15), new DateTime(2021, 09, 15)));
            courses.Add(new Course("CB16", "Python", "Full Time", new DateTime(2021, 01, 15), new DateTime(2021, 09, 15)));

        }
        private static void PrintDefaultCourses(List<Course> courses)
        {
            Console.Clear();
            Console.WriteLine("Deafult list of Courses");
            int counter = 1;
            foreach (var _course in courses)
            {
                Console.WriteLine($"{counter})Title={_course.Title}, Stream= {_course.Stream}, Type = {_course.Type}, Start date ={_course.StartDate.ToShortDateString()}, End Date {_course.EndDate.ToShortDateString()}");
                counter++;
            }
            Console.ReadKey();
        }
        private static void CourseInput()
        {
            Console.Clear();
            Console.WriteLine("Add Courses");
            bool set = true;
            while (set)
            {
                Console.Write("Enter the title: ");
                string aTitle = Console.ReadLine();
                Console.Write("Enter the stream: ");
                string aStream = Console.ReadLine();
                Console.Write("Enter the type: ");
                string aType = Console.ReadLine();
                Console.Write("Enter the start date: ");
                DateTime aStartDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the end date: ");
                DateTime aEndDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Choose assignment for the course:");
                int counter = 1;
                foreach (var _assignment in assignments)
                {
                    Console.WriteLine($"{counter})Title={_assignment.Title}, description= {_assignment.Description}, Substitution date = {_assignment.subDateTime.ToShortDateString()}, oral mark = {_assignment.OralMark}, total mark {_assignment.TotalMark}");
                    counter++;
                }
                int assignment = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine($"Course {aTitle} has the assignment {assignments[assignment].Title}");
                courses.Add(new Course(aTitle, aStream, aType, aStartDate, aEndDate));
                AssignmentsCourses.Add(new AssignmentsCourses(courses[courses.Count - 1]));
                AssignmentsCourses[AssignmentsCourses.Count - 1].Assignments.Add(assignments[assignment]);
                Console.WriteLine("Options: \n1.Add more \n2.exit");
                string answer = Console.ReadLine();
                if (answer == "2")
                {
                    set = false;
                }
            }
            Console.ReadKey();
        }
        #endregion

        #region Assignments per Students + per Courses
        private static void DefaultAssignStudents()
        {
            AssignmentsStudents student = new AssignmentsStudents();
            student.StudentCourses = StudentsCourses[0];
            student.AssignmentsCourses = AssignmentsCourses[0];

            AssignmentsStudents student1 = new AssignmentsStudents();
            student1.StudentCourses = StudentsCourses[1];
            student1.AssignmentsCourses = AssignmentsCourses[1];

            AssignmentsStudents student2 = new AssignmentsStudents();
            student2.StudentCourses = StudentsCourses[2];
            student2.AssignmentsCourses = AssignmentsCourses[2];

            AssignmentsStudents student3 = new AssignmentsStudents();
            student3.StudentCourses = StudentsCourses[3];
            student3.AssignmentsCourses = AssignmentsCourses[3];

            AssignmentsStudents student4 = new AssignmentsStudents();
            student4.StudentCourses = StudentsCourses[4];
            student4.AssignmentsCourses = AssignmentsCourses[0];

            AssignmentsStudents student5 = new AssignmentsStudents();
            student5.StudentCourses = StudentsCourses[5];
            student5.AssignmentsCourses = AssignmentsCourses[1];

            AssignmentsStudents student6 = new AssignmentsStudents();
            student6.StudentCourses = StudentsCourses[6];
            student6.AssignmentsCourses = AssignmentsCourses[2];

            AssignmentsStudents student7 = new AssignmentsStudents();
            student7.StudentCourses = StudentsCourses[7];
            student7.AssignmentsCourses = AssignmentsCourses[3];

            AssignmentsStudents student8 = new AssignmentsStudents();
            student8.StudentCourses = StudentsCourses[8];
            student8.AssignmentsCourses = AssignmentsCourses[0];

            AssignmentsStudents student9 = new AssignmentsStudents();
            student9.StudentCourses = StudentsCourses[9];
            student9.AssignmentsCourses = AssignmentsCourses[1];

            AssignmentsStudents.Add(student); AssignmentsStudents.Add(student1); AssignmentsStudents.Add(student2); AssignmentsStudents.Add(student3); AssignmentsStudents.Add(student4);
            AssignmentsStudents.Add(student5); AssignmentsStudents.Add(student6); AssignmentsStudents.Add(student7); AssignmentsStudents.Add(student8); AssignmentsStudents.Add(student9);
        }
        private static void PrintDefaultAssignmentsStudents(List<AssignmentsStudents> assignmentsStudents)
        {
            Console.Clear();
            Console.WriteLine("Assignments per Students");
            int count_ = 1;
            foreach (var AsPSt in assignmentsStudents)
            {
                Console.WriteLine($"{count_})Student: {AsPSt.StudentCourses.student.FirstName} {AsPSt.StudentCourses.student.LastName}");
                for (int i = 0; i < AsPSt.StudentCourses.ListCourses.Count; i++)
                {
                    Console.WriteLine($"Course: {AsPSt.StudentCourses.ListCourses[i].Stream} has the above assignments:");
                    char _char = 'a';
                    for (int x = 0; x < AsPSt.AssignmentsCourses.Assignments.Count; x++)
                    {
                        Console.WriteLine($"\t{_char}: {AsPSt.AssignmentsCourses.Assignments[x].Title}");
                        _char++;
                    }
                }
                count_++;
            }
            Console.ReadKey();
        }
        private static void AssignmentsPerStudentsInput()
        {
            Console.Clear();
            string answer = "Type your answer: ";
            Console.WriteLine("Choose the student by the index on the left");
            int counter = 1;
            foreach (var student_ in StudentsCourses)
            {
                Console.WriteLine($"\t{counter}] {student_.student.FirstName} {student_.student.LastName}");
                counter++;
            }
            Console.Write(answer.ToUpper());
            int aStudent = Convert.ToInt32(Console.ReadLine()); //exoyme ton Student
            /****************************************************************/
            Console.Clear();
            Console.WriteLine("Choose the student's course"); //choose the course            
            int acounter = 1;
            for (int i_ = 0; i_ < StudentsCourses[aStudent - 1].ListCourses.Count; i_++)
            {
                Console.WriteLine($"{acounter}] {StudentsCourses[aStudent - 1].ListCourses[i_].Stream}");
                acounter++;
            }
            Console.Write(answer.ToUpper());
            int aCourse = Convert.ToInt32(Console.ReadLine()); //exoyme to course
            string aStream = StudentsCourses[aStudent - 1].ListCourses[aCourse - 1].Stream;
            /****************************************************************///choose the assignments
            Console.Clear();
            Console.WriteLine("Choose the assignment for course");
            int ar = 1;
            char _char = 'A';
            int index = 0;
            Console.WriteLine($"{ar}){StudentsCourses[aStudent - 1].ListCourses[aCourse - 1].Stream}:");
            Console.WriteLine("The course already has these assignments:");
            char _achar = 'a';
            if (StudentsCourses[aStudent - 1].ListCourses[aCourse - 1].Stream == "C#")
            {
                for (int y = 0; y < AssignmentsCourses[index].Assignments.Count; y++)
                {
                    Console.WriteLine($"{_achar}] {AssignmentsCourses[index].Assignments[y].Title}.");
                    _achar++;
                }
            }
            else if (StudentsCourses[aStudent - 1].ListCourses[aCourse - 1].Stream == "Java")
            {
                for (int y = 0; y < AssignmentsCourses[index + 1].Assignments.Count; y++)
                {
                    Console.WriteLine($"{_achar}] {AssignmentsCourses[index].Assignments[y].Title}.");
                    _achar++;
                }
            }
            else if (StudentsCourses[aStudent - 1].ListCourses[aCourse - 1].Stream == "C++")
            {
                for (int y = 0; y < AssignmentsCourses[index + 2].Assignments.Count; y++)
                {
                    Console.WriteLine($"{_achar}] {AssignmentsCourses[index].Assignments[y].Title}.");
                    _achar++;
                }
            }
            else if (StudentsCourses[aStudent - 1].ListCourses[aCourse - 1].Stream == "Python")
            {
                for (int y = 0; y < AssignmentsCourses[index + 3].Assignments.Count; y++)
                {
                    Console.WriteLine($"{_achar}] {AssignmentsCourses[index].Assignments[y].Title}.");
                    _achar++;
                }
            }
            _char++;

            Console.WriteLine("List of assignments"); //choose the assignments
            int counter1 = 1;
            foreach (var _assignment in assignments)
            {
                Console.WriteLine($"{counter1}){_assignment.Title}.");
                counter1++;
            }
            Console.Write(answer.ToUpper());
            int aAssignment = Convert.ToInt32(Console.ReadLine());

            SetAssignToStudents(aStudent, aCourse, aAssignment);

            Console.ReadKey();
        }

        private static void DefaultAssignmentsPerCourse()
        {
            AssignmentsCourses assign = new AssignmentsCourses();
            assign.course = courses[0];
            assign.Assignments.Add(assignments[2]);
            assign.Assignments.Add(assignments[3]);

            AssignmentsCourses assign1 = new AssignmentsCourses();
            assign1.course = courses[1];
            assign1.Assignments.Add(assignments[0]);
            assign1.Assignments.Add(assignments[3]);

            AssignmentsCourses assign2 = new AssignmentsCourses();
            assign2.course = courses[2];
            assign2.Assignments.Add(assignments[0]);


            AssignmentsCourses assign3 = new AssignmentsCourses();
            assign3.course = courses[3];
            assign3.Assignments.Add(assignments[1]);
            assign3.Assignments.Add(assignments[3]);

            AssignmentsCourses.Add(assign); AssignmentsCourses.Add(assign2);
            AssignmentsCourses.Add(assign1); AssignmentsCourses.Add(assign3);
        }
        private static void PrintDefaultAssignmentsPerCourse(List<AssignmentsCourses> AssignmentsCourses)
        {
            Console.Clear();
            Console.WriteLine("Deafult Assignments per Courses");
            int counter = 1;
            foreach (var course in AssignmentsCourses)
            {
                char char_ = 'a';
                Console.WriteLine($"{counter}. The course {course.course.Stream}");
                Console.WriteLine("Assignments: ");
                for (int i = 0; i < course.Assignments.Count; i++)
                {
                    Console.WriteLine($"{char_}] {course.Assignments[i].Title}");
                    char_++;
                }
                counter++;
            }
            Console.ReadKey();
        }
        private static void AssignmentsPerCourseInput()
        {
            Console.Clear();

            Console.WriteLine("Choose by the left index the course you want to modify:");
            int counter = 1;
            foreach (var assignPercourse in AssignmentsCourses)
            {
                char char_ = 'a';
                Console.WriteLine($"{counter}. The course {assignPercourse.course.Stream}");
                Console.WriteLine("Assignments: ");
                for (int i = 0; i < assignPercourse.Assignments.Count; i++)
                {
                    Console.WriteLine($"{char_}] {assignPercourse.Assignments[i].Title}");
                    char_++;
                }
                counter++;
            }
            int acourse = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose by the left index the assignment you want to add to the selecteed course:");
            int acounter = 1;
            foreach (var _assignment in assignments)
            {
                Console.WriteLine($"{acounter}){_assignment.Title}");
                acounter++;
            }
            int aAssignment = Convert.ToInt32(Console.ReadLine());
            SetAssignToCourse(acourse, aAssignment);
            Console.ReadKey();
        }
        #endregion

        #region Assignments

        private static void DefaultAssignments()
        {
            Console.Clear();
            Console.WriteLine("Deafult list of Assignments");
            assignments.Add(new Assignment("Intro Test", "Test the basics", new DateTime(2021, 2, 15), 5, 10));
            assignments.Add(new Assignment("Pro Test", "Advanced Tests", new DateTime(2021, 4, 15), 5, 10));
            assignments.Add(new Assignment("Super Test", "Semi-Pro Test", new DateTime(2021, 6, 15), 5, 10));
            assignments.Add(new Assignment("Final Test", "Professional Tests", new DateTime(2021, 9, 2), 5, 10));
        }
        private static void PrintDefaultAssignments(List<Assignment> assignments)
        {
            Console.Clear();
            Console.WriteLine("List of Assignments");
            int counter = 1;
            foreach (var _assignment in assignments)
            {
                Console.WriteLine($"{counter})Title={_assignment.Title}, description= {_assignment.Description}, Substitution date = {_assignment.subDateTime.ToShortDateString()}, oral mark = {_assignment.OralMark}, total mark {_assignment.TotalMark}");
                counter++;
            }
            Console.ReadKey();
        }
        private static void AssignmentInput()
        {
            Console.Clear();
            Console.WriteLine("Add Assignments");

            bool set = true;
            while (set)
            {
                Console.Write("Enter the title: ");
                string aTitle = Console.ReadLine();
                Console.Write("Enter the description: ");
                string aDescription = Console.ReadLine();
                Console.Write("Enter the substitution date: ");
                DateTime aSubDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the oral mark: ");
                int aOralMark = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the total mark: ");
                int aTotalMark = Convert.ToInt32(Console.ReadLine());
                assignments.Add(new Assignment(aTitle, aDescription, aSubDate, aOralMark, aTotalMark));
                AssignmentsCourses.Add(new AssignmentsCourses(assignments[assignments.Count - 1]));
                Console.WriteLine("Options: \n1. Add more\n2.Exit");
                string answer = Console.ReadLine();
                if (answer == "2")
                {
                    set = false;
                }
            }
            Console.ReadKey();
        }
        #endregion

        #region Lists
        public static List<Student> Students = new List<Student>();
        public static List<Course> courses = new List<Course>();
        public static List<StudentsCourses> StudentsCourses = new List<StudentsCourses>();
        public static List<Trainer> trainers = new List<Trainer>();
        public static List<Assignment> assignments = new List<Assignment>();
        public static List<TrainersCourses> TrainersCourses = new List<TrainersCourses>();
        public static List<AssignmentsCourses> AssignmentsCourses = new List<AssignmentsCourses>();
        public static List<AssignmentsStudents> AssignmentsStudents = new List<AssignmentsStudents>();
        #endregion

        #region Main Menu
        private static bool MainMenu()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Welcome to our School!!!");
            Console.WriteLine("Do you want Synthetic data?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    InputData();
                    return true;
                case "2":
                    DefaultData();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }

        }
        private static void InputData()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = InputDataMenu();
            }
        }
        private static bool InputDataMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Input Data");
            Console.WriteLine("2) List Menu");
            Console.WriteLine("3) Back");
            switch (Console.ReadLine())
            {
                case "1":
                    TheInputDataMenu();
                    return true;
                case "2":
                    TheListMenu();
                    return true;
                case "3":
                    Console.WriteLine("Back");
                    return false;
                default:
                    return true;
            }
        }

        private static void TheListMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ExteListMenu();
            }
        }

        private static bool ExteListMenu()
        {
            Console.Clear();
            Console.WriteLine("List Menu");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. List of Students");
            Console.WriteLine("2. List of Trainers");
            Console.WriteLine("3. List of Courses");
            Console.WriteLine("4. List of Assignments");
            Console.WriteLine("5. List of Students per course");
            Console.WriteLine("6. List of Trainers per course");
            Console.WriteLine("7. List of Assignments per course");
            Console.WriteLine("8. List of Assignments per Students");
            Console.WriteLine("9. List of Students that belong to more than one courses");
            Console.WriteLine("10. List of Students who need to submit assignments in the calendar week ");
            Console.WriteLine("11. Back");
            switch (Console.ReadLine())
            {
                case "1":
                    PrintDefaultStudents(Students);
                    return true;
                case "2":
                    PrintDefaultTrainers(trainers);
                    return true;
                case "3":
                    PrintDefaultCourses(courses);
                    return true;
                case "4":
                    PrintDefaultAssignments(assignments);
                    return true;
                case "5":
                    PrintDefaultStudentsPerCourses(StudentsCourses);
                    return true;
                case "6":
                    PrintDefaultTrainersPerCourses(TrainersCourses);
                    return true;
                case "7":
                    PrintDefaultAssignmentsPerCourse(AssignmentsCourses);
                    return true;
                case "8":
                    PrintDefaultAssignmentsStudents(AssignmentsStudents);
                    return true;
                case "9":
                    PrintDefaultStudentsMoreCourses(StudentsCourses);
                    return true;
                case "10":
                    ShowAssignments(AssignmentsStudents);
                    return true;
                case "11":
                    Console.WriteLine("Back");
                    return false;
                default:
                    return true;
            }
        }

        private static void TheInputDataMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ExteDataMenu();
            }
        }

        private static bool ExteDataMenu()
        {
            Console.Clear();
            Console.WriteLine("Input Menu");
            Console.WriteLine("1. Input Students");
            Console.WriteLine("2. Input Trainers");
            Console.WriteLine("3. Input Courses");
            Console.WriteLine("4. Input Assignments");
            Console.WriteLine("5. Set Students per course");
            Console.WriteLine("6. Set Trainers per course");
            Console.WriteLine("7. Set Assignments per course");
            Console.WriteLine("8. Set Assignments per Students");
            Console.WriteLine("9. Back");
            switch (Console.ReadLine())
            {
                case "1":
                    StudentInput();
                    return true;
                case "2":
                    TrainerInput();
                    return true;
                case "3":
                    CourseInput();
                    return true;
                case "4":
                    AssignmentInput();
                    return true;
                case "5":
                    StudentsPerCourseInput();
                    return true;
                case "6":
                    TrainerPerCourseInput();
                    return true;
                case "7":
                    AssignmentsPerCourseInput();
                    return true;
                case "8":
                    AssignmentsPerStudentsInput();
                    return true;
                case "9":
                    Console.WriteLine("Back");
                    return false;
                default:
                    return true;
            }
        }



        private static void DefaultData()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = DefaultDataMenu();
            }
        }

        private static bool DefaultDataMenu()
        {
            Console.Clear();
            Console.WriteLine("Default List Menu");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. List of Students");
            Console.WriteLine("2. List of Trainers");
            Console.WriteLine("3. List of Courses");
            Console.WriteLine("4. List of Assignments");
            Console.WriteLine("5. List of Students per course");
            Console.WriteLine("6. List of Trainers per course");
            Console.WriteLine("7. List of Assignments per course");
            Console.WriteLine("8. List of Assignments per Students");
            Console.WriteLine("9. List of Students that belong to more than one courses");
            Console.WriteLine("10. List of Students who need to submit assignments in the calendar week ");
            Console.WriteLine("11. Back");
            switch (Console.ReadLine())
            {
                case "1":
                    PrintDefaultStudents(Students);
                    return true;
                case "2":
                    PrintDefaultTrainers(trainers);
                    return true;
                case "3":
                    PrintDefaultCourses(courses);
                    return true;
                case "4":
                    PrintDefaultAssignments(assignments);
                    return true;
                case "5":
                    PrintDefaultStudentsPerCourses(StudentsCourses);
                    return true;
                case "6":
                    PrintDefaultTrainersPerCourses(TrainersCourses);
                    return true;
                case "7":
                    PrintDefaultAssignmentsPerCourse(AssignmentsCourses);
                    return true;
                case "8":
                    PrintDefaultAssignmentsStudents(AssignmentsStudents);
                    return true;
                case "9":
                    PrintDefaultStudentsMoreCourses(StudentsCourses);
                    return true;
                case "10":
                    ShowAssignments(AssignmentsStudents);
                    return true;
                case "11":
                    Console.WriteLine("Back");
                    return false;
                default:
                    return true;
            }

        }
        #endregion
        static void Main(string[] args)
        {
            DefaultStudents();
            DefaultTrainers();
            DefaultCourses();
            DefaultAssignments();
            DefaultStudentsPerCourses();
            DefaultTrainersPerCourses();
            DefaultAssignmentsPerCourse();
            DefaultAssignStudents();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
    }
}
