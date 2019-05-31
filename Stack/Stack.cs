using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        private int count=0;
        private Node<T> last;
        public int Count
        {
            get => count;
        }
        public bool IsEmpty => count == 0;

        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = last;
            last = node;
            count++;

        }
        
        public T Pop()
        {
            if(IsEmpty)
            {
                throw new Exception("Stack is empty");
            }
            T temp = last.Value;
            last = last.Next;
            count--;
            return temp;

        }
        public T Peek()
        {
            if(IsEmpty)
            {
                throw new Exception("Stack is empty, that is wy you can't return the last element ");

            }
            return last.Value;
        }
    }
}
