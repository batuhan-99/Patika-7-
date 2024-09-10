using System;

namespace Linq_Group_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
            new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
            new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
            new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
        };

            List<Class> classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Türkçe" },
            new Class { ClassId = 3, ClassName = "Kimya" }
        };

            var groupJoinQuery = from c in classes
                                 join s in students on c.ClassId equals s.ClassId into studentGroup
                                 select new
                                 {
                                     ClassName = c.ClassName,
                                     Students = studentGroup
                                 };

            
            foreach (var s in groupJoinQuery)
            {
                Console.WriteLine($"Sınıf: {s.ClassName}");
                foreach (var student in s.Students)
                {
                    Console.WriteLine($"  Öğrenci: {student.StudentName}");
                }
            }
        }
    }
}