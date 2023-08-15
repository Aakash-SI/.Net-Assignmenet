using System;
using System.Collections.Generic;

namespace StudentRecordManagement
{
    class Student
    {
        private string name;
        private int age;
        private string gender;
        private string student_ID;
        private List<string> course_Enrollment = new List<string>();
        private double gpa;

        public string Name{get { return name; } set { name = value; }}

        public int Age{get { return age; }set { age = value; }}
        public string Gender{get { return gender; }set { gender = value; }}

        public string Student_ID{get { return student_ID; } set { student_ID = value; }}

        public List<string> Course_Enrollment{get { return course_Enrollment; }set { course_Enrollment = value; }}

        public double GPA{get { return Calculate_GPA(); }}

        private double Calculate_GPA()
        {
            double p = 0;
            return p / course_Enrollment.Count;
        }
    }

    class School
    {
        private List<Student> students = new List<Student>();

        public void Add_Student(Student student)
        {
            students.Add(student);
        }

        public void Display_Students()
        {
            Console.WriteLine("Student List:");
            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, ID: {student.Student_ID}");
            }
        }

        public double Calculate_Overall_GPA()
        {
            double total_GPA = 0;
            foreach (Student student in students)
            {
                total_GPA += student.GPA;
            }

            return total_GPA / students.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            Student student1 = new Student();
            student1.Name = "Aakash";
            student1.Age = 21;
            student1.Gender = "Male";
            student1.Student_ID = "1";
            student1.Course_Enrollment = new List<string> { "Web Development", "C++" };

            school.Add_Student(student1);
            school.Display_Students();
            Console.WriteLine($"GPA: {school.Calculate_Overall_GPA():F2}");
        }
    }
}
