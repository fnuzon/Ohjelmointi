using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create one student object
            Student student = new Student();
            student.FirstName = "Teppo";
            student.LastName = "Terävä";
            student.Address = "Piippukatu 3";
            student.Age = 24;
            student.PhoneNumber = "01-12345678";
            student.StudentID = "H8948";
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Kirsi", "Kernel", "D566");
            teacher.Age = 35;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "010-12345678";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

            student.PersonMethod();
        }
    }
}
