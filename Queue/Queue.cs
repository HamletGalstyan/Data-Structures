using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue<T>
    {
        public class Node<T>
        {
            
            private T data;
            private Node<T> next;

            public Node()
            {

            }
            public Node(T data)
            {
                Data = data;
                
            }


            public T Data { get => data; set => data = value; }
            public Node<T> Next { get => next; set => next = value; }
            
        }


        private Node<T> last;
        public bool IsEmpty => last == null;
        public void Add(T data)
        {
            Node<T> tmp = new Node<T>(data);
            if(last==null)
            {

                

            }
        }
    }
}
