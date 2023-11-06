using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Student
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public string university { get; set; }

        
    }

    internal class Program
    {
        public static void Show(IEnumerable<Student> students)
        {
            Console.WriteLine();

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.first_name} {student.last_name}, Age: {student.age}, School: {student.university}");
            }
        }


        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { first_name = "qwe", last_name = "NeBro", age = 19, university = "MIT" },
                new Student { first_name = "asd", last_name = "NeBro", age = 20, university = "school 2" },
                new Student { first_name = "Boris", last_name = "Bro", age = 21, university = "Oxford" }
            };

            var allStudents = students;
            Show(allStudents);

            var borisStudents = students.Where(student => student.first_name == "Boris");
            Show(borisStudents);

            var broStudents = students.Where(student => student.last_name.StartsWith("Bro"));
            Show(broStudents);

            var oldStudents = students.Where(student => student.age > 19);
            Show(oldStudents);

            var oldestStudents = students.Where(student => student.age > 20 && student.age < 23);
            Show(oldestStudents);

            var mitStudents = students.Where(student => student.university == "MIT");
            Show(mitStudents);

            var oxfordStudentsOver18 = students.Where(student => student.university == "Oxford" && student.age > 18).OrderByDescending(student => student.age);
            Show(oxfordStudentsOver18);
        }
    }
}
