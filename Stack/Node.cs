using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Node<T>
    {
        private T value;
        private Node<T> next;

        public T Value { get => value; set => this.value = value; }
        internal Node<T> Next { get => next; set => next = value; }

        public Node()
        {
                
        }

        public Node(T value)
        {

            this.Value = value;
           
        }



    }
}
