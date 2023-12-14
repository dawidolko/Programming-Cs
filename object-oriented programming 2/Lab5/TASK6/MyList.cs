using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.TASK6
{
    public partial class MyList<T>
    {
        private Node first = null;
        private Node last = null;

        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        public void Add(T element)
        {
            Node newNode = new Node(element);
            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }

        private Node GetNode(int index)
        {
            Node current = first;
            for (int i = 0; current != null && i < index; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
            }

            return current;
        }

        public T this[int index]
        {
            get => GetNode(index).Value;
            set => GetNode(index).Value = value;
        }
    }
}
