using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSer
{
    [Serializable]
    class Student1
    {
        public int age, gpa;
        public string name;

        public Student1()
        {
            name = "Almas";
            age = 18;
            gpa = 4;
        }

        public Student1(int age, int gpa, string name)
        {
            this.age = age;
            this.gpa = gpa;
            this.name = name;
        }
    }
}
