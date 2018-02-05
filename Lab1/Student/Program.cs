using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    public class Student
    {
        public string surname, name;
        public double gpa;
        public int age;
        public int height;

        public Student()
        {
            surname = "Oral";
            name = "Almas";
            age = 18;
            height = 178;
            gpa = 3;
        }
        public Student(string surname, string name, int age, int height, double gpa)
        {
            this.surname = surname;
            this.name = name;
            this.age = age;
            this.height = height;
            this.gpa = gpa;
        }
        public static void getgpa(double gpa)
        {
            Console.WriteLine(gpa);
        }

        public override string ToString()
        {
            return surname + ' ' + name + ' ' + age + ' ' + height + ' ' + gpa;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            string surname, name;
            int age, height;
            double gpa;
            Surname = Console.ReadLine();
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());
            gpa = double.Parse(Console.ReadLine());

            Student a = new Student(surname, name, age, height, gpa);
            Student.getgpa(a.gpa);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}