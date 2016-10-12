using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedLisd sll = new SingleLinkedLisd();
            SingleLinkedLisd sll1 = new SingleLinkedLisd();

            sll.Add(1);
            sll.Add(2);
            sll.Add(3);
            sll.Add(4);
            sll.Add(5);
            sll.Add(6);
            sll.Add(7);
            sll.Add(8);

            sll1.Add(8);
            sll1.Add(7);
            sll1.Add(6);
            sll1.Add(5);
            sll1.Add(3);
            sll1.Add(2);
            sll1.Add(1);

            Console.WriteLine(sll.SumNodeValues() - sll1.SumNodeValues());
        }
    }
}
