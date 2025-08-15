using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public double GPA { get; set; }

        public Student(int id, string name, string subject, double gpa)
        {
            ID = id;
            Name = name;
            Subject = subject;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Subject: {Subject}, GPA: {GPA}";
        }
    }
}
