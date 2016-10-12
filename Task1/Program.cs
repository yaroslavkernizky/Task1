using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student male = new MaleStudent();
            Student female = new FemaleStudent();

            male.GetGrant();

            female.GetGrant();

            Group gp = new Group();

            gp.AddStudent(male);
            gp.AddStudent(female);
        }
    }
}
