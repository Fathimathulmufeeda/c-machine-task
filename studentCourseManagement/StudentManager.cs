using System;
using System.Collections.Generic;
using System.Text;

namespace studentCourseManagement
{
    public class StudentManager
    {
        List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("student added successfully");
        }
        public void ListStudent()
        {
            foreach (Student student in students) 
                {
                Console.WriteLine($"Id :{student.Id}");
                Console.WriteLine($"Name:{student.Name}");
                Console.WriteLine($"Age:{student.Age}");
                Console.WriteLine($"Course Id :{student.CourseId}");
                }

        }
        public void UpdateStudent(int id)
        {
            Student? student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            Console.Write("Enter new name: ");
            student.Name = Console.ReadLine() ?? "";

            Console.Write("Enter new age: ");
            student.Age = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter new course ID: ");
            student.CourseId = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Student updated successfully!");
        }
        public void DeleteStudent(int id)
        {
            Student? student = students.FirstOrDefault(s => s.Id ==id);
            if (student == null) {
                Console.WriteLine("Student not found");
                return ;
            }
            students.Remove(student);
            Console.WriteLine("Student removed successfully");
        }
    }
}
