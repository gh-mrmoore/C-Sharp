using System;
using System.Collections.Generic;
using System.Text;

namespace MyGradeBook
{
    class Courses
    {
        private static int nextCourseId = 1;
        public String CourseName { get; set; }
        public int CourseId { get; set; }
        public int CourseCredit { get; set; }
        //double to indicate the period when the student is enrolled, ie fall 2019, spring 2020, etc.
        //student class to get name, etc
        public Dictionary<double, Student> Enrollment = new Dictionary<double, Student>();

        public Courses(String courseName, int courseId, int courseCredit)
        {
            CourseName = courseName;
            CourseId = nextCourseId++;
            CourseCredit = courseCredit;
        }
    }
}
