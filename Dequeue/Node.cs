using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dequeue
{
    class Node<T>
    {
        private T value;
        private Node<T> next;
        private Node<T> prev;

        public Node() { }
        public Node(T value)
        {
            Value = value;
           
        }

        public T Value{ get => value; set => this.value = value; }
        internal Node<T> Next { get => next; set => next = value; }
        internal Node<T> Prev { get => prev; set => prev = value; }
    }
}
