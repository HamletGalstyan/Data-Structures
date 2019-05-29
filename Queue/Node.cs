using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Node<T>
    {
        private T node;
        private Node<T> next;

        public Node(T node)
        {
            Node1 = node;
           
        }

        public Node()
        {

        }

        public T Node1 { get => node; set => node = value; }
        public Node<T> Next { get => next; set => next = value; }

    }
}
