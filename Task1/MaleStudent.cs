using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class MaleStudent:Student
    {
        public override double GetGrant()
        {
            Console.WriteLine("Стипендия мальчиков.");
            return 0;
        }
    }
}
