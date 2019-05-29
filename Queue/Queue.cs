using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Queue<T>
    {
        public Node<T> first;
        public Node<T> last;
        private int count = 0;

        public bool IsEmpty => count == 0;
        
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if(IsEmpty)
            {
                last = node;
                 first = last;
            }
            node.Next = last;
            last = node;
            count++;
        }
        public void Remove()
        {
            Node<T> node = last; 
            while(node!=first)
            {
                node = node.Next;

            }
            first = node;
            first = null;
            
        }
        public void QueuePrint()
        {

            if (last == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine(first.Node1);
           

        }





            

        

    }
}
