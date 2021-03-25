using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engin";
            int age = 36;

            // Yeni kurs tanımlanır. Kurs sınıfının özelliklerin tanımlanır.

            Course newCourse = new Course();
            newCourse.CourseName = "C#";
            newCourse.Teacher = "Engin Demiroğ";
            newCourse.ViewRate = 68;

            Course newCourse2 = new Course();
            newCourse2.CourseName = "Java";
            newCourse2.Teacher = "Kerem Varış";
            newCourse2.ViewRate = 64;

            Course newCourse3 = new Course();
            newCourse3.CourseName = "Python";
            newCourse3.Teacher = "Berkay Bilgin";
            newCourse3.ViewRate = 80;

            Course newCourse4 = new Course();
            newCourse4.CourseName = "C++";
            newCourse4.Teacher = "Murat Kurtboğan";
            newCourse4.ViewRate = 100;

            //Console.WriteLine(newCourse.CourseName + " " + newCourse.Teacher);

            Course[] courses = new Course[] { newCourse, newCourse2, newCourse3, newCourse4 };
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Teacher);
            }
        }
    }


    // Kurs sınıfının özellikleri tanımlanır
    class Course
    {
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public int ViewRate { get; set; }
    }
}
