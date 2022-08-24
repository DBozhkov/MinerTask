using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Student
    {
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
    }
}
