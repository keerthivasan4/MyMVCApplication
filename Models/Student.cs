using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }

        public Student(string n, int age, int i)
        {
            this.Age = age;
            this.Name = n;
            this.Id = i;
        }

        public Student()
        {

        }

        public Student(Student s)
        {
            this.Name = s.Name;
            this.Age = s.Age;
            this.Id = s.Id;
        }
    }
}