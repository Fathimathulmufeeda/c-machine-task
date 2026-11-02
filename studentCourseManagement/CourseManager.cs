using System;
using System.Collections.Generic;
using System.Text;

namespace studentCourseManagement
{
    public class CourseManager
    {
        List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine("Course added");
        }
        public void ListCourse()
        {
            foreach (Course c in courses)
            {
                Console.WriteLine($"course id :{c.CourseId},Course name: {c.CourseName}");
            }
        }
    }
}
