using System;
using System.Collections.Generic;
using System.Text;

namespace Unit06_Prep
{
    class Course
    {
        private static int nextCourseId = 1;
        public String CourseName { get; set; }
        public int CourseId { get; set; }
        public int CourseCredit { get; set; }
        //double to indicate the period when the student is enrolled, ie fall 2019, spring 2020, etc.
        //student class to get name, etc
        public Dictionary<double, Student> Enrollment = new Dictionary<double, Student>();

        public Course(String courseName, int courseId, int courseCredit)
        {
            CourseName = courseName;
            CourseId = nextCourseId++;
            CourseCredit = courseCredit;
        }

        public override string ToString()
        {
            return CourseName + " | " + CourseId + " | " + CourseCredit;
        }

        public override bool Equals(object obj)
        {
            //reference check
            if (obj == this) { return true; }

            //null check
            if (obj == null) { return false; }

            //class check
            if (obj.GetType() != GetType()) { return false; }

            //cast
            Course courseObj = obj as Course;
            return CourseId == courseObj.CourseId;

            //custom comparisons
        }
    }
}
