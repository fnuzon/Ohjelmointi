using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister
{
    class Program
    {        
        static void Main(string[] args)
        {
            int input, age;
            string name, school, studies, nat;                        
            
            List<Student> students = new List<Student>();
            do
            {
                Console.WriteLine("1. Add new student: ");
                Console.WriteLine("2. Print students: ");
                Console.WriteLine("Use 0 to end the loop");
                Console.WriteLine("Give your choice: ");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Give student name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Give student school: ");
                    school = Console.ReadLine();
                    Console.WriteLine("Give student age: ");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Give student studies: ");
                    studies = Console.ReadLine();
                    Console.WriteLine("Give student nationatily: ");
                    nat = Console.ReadLine();
                    students.Add(new Student(name, school, age, studies, nat));
                }
                if (input == 2)
                {
                    foreach (Student student in students)
                    {
                        Console.WriteLine("Name: " + student.Name + ", School: " + student.School + ", Age: " + student.Age + ", Studies: " + student.Studies + ", Nationality: " + student.Nat);
                    }
                }
            }
            while (input != 0);
        }
    }
}
