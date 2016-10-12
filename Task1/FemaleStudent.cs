using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FemaleStudent: Student
    {
        public override double GetGrant()
        {
            Console.WriteLine("Стипендия девушек.");
            return 0;
        }
    }
}
