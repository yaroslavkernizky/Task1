using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SingleLinkedLisd
    {
        Node Tail;
        Node Head;

        int Sum;

        public void Add(Node node)
        {
            if (node != null)
            {
                if (this.Head == null)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {
                    Tail.Next = node;
                    Tail = node;
                }
            }
        }

        public void Add(int val)
        {
            Node node = new Node() { Value = val };

            Add(node);
        }

        public int SumNodeValues()
        {
            return SumNodeValues(this.Head);
        }

        public int SumNodeValues(Node node)
        {
            if (node != null)
            {
                Sum += node.Value;
                if(node.Next != null)
                {
                    SumNodeValues(node.Next);
                }
            }

            return Sum;
        }
    }


    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
