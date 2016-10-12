using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        ICollection<Student> students;

        public Group()
        {
            this.students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            student.group = this;
        }           
    }
}
