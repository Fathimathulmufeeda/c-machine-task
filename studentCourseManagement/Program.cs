using studentCourseManagement;
using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("student course management system");

        StudentManager manager = new StudentManager();
        CourseManager cmanager = new CourseManager();

        Student S1 = new Student
        {
            Id = 101,
            Name ="fathima",
            Age=22,
            CourseId=1
        };
        Course c1 = new Course
        {
            CourseId = 1,
            CourseName = "c#"
        };
        Course c2 = new Course
        {
            CourseId = 2,
            CourseName = ".Net"
        };
        Course c3 = new Course
        {
            CourseId = 3,
            CourseName = "Angular"
        };

        manager.AddStudent(S1);
        cmanager.AddCourse(c1);
        cmanager.AddCourse(c2);
        cmanager.ListCourse();
        manager.ListStudent();
        manager.UpdateStudent(101);
        manager.DeleteStudent(101);

    }
}