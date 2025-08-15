using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class StudentsManager
    {
        public List<Student> Students { get; set; }
        public StudentsManager()
        {
            Students = new List<Student>();
        }
        public Student GetStudentInfo()
        {
            int id;
            string name, subject;
            double gpa;
            Console.Write("Enter Student ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student Subject: ");
            subject = Console.ReadLine();
            Console.Write("Enter Student GPA: ");
            gpa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            return new Student(id, name, subject, gpa);
        }
        public void AddStudent()
        {
            Students.Add(GetStudentInfo());
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void DisplayStudents()
        {
            var displayedStudents = Students.Zip(Enumerable.Range(1, Students.Count), (student, index) => $"{index}. {student}");
            if(!displayedStudents.Any())
            {
                Console.WriteLine("No students available.");
                return;
            }
            foreach (var student in displayedStudents)
            {
                Console.WriteLine(student);
            }
        }

        public Student FindStudentById(int id)
        {
            return Students.FirstOrDefault(s => s.ID == id);
        }

        public double CalculateAverageGPA()
        {
            if (Students.Count == 0) return 0;
            return Students.Average(s => s.GPA);
        }

        public List<Student> FindStudentsBySubject(string subject)
        {
            return Students.Where(s => s.Subject == subject).ToList();
        }

        public Student GetStudentWithMaxGPA()
        {
            if (Students.Count == 0) return null;
            double maxGPA = Students.Max(s => s.GPA);
            return Students.FirstOrDefault(s => s.GPA == maxGPA);
        }

        public Student GetStudentWithMinGPA()
        {
            if (Students.Count == 0) return null;
            double minGPA = Students.Min(s => s.GPA);
            return Students.FirstOrDefault(s => s.GPA == minGPA);
        }
    }
}
