using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Student
    {
        Guid Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public Group group { get; set; }

        public Student()
        {
            this.Id = Guid.NewGuid();
        }

        public Student(string name, double gpa):this()
        {
            this.Name = name;
            this.GPA = gpa;
        }

        public abstract double GetGrant();
        
    }
}
