using System;

namespace XmlSer
{
    [Serializable]
    public class Student
    {
        public int age, gpa;
        public string name;

        public Student()
        {
            name = "Almas";
            age = 18;
            gpa = 4;
        }

        public Student(int age, int gpa, string name)
        {
            this.age = age;
            this.gpa = gpa;
            this.name = name;
        }
    }
}