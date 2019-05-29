using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dequeue
{
    class Dequeue<T>
    {
        private int count;
        public bool IsEmpty => count == 0;
        private Node<T> head;
        private Node<T> tail;
        public void AddLast(T data)
        {

            Node<T> node = new Node<T>(data);
            if (IsEmpty)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                node.Prev = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            if (IsEmpty)
            {
                tail = node;
                head = node;
            }
            else
            {
                node.Next = head;
                head.Prev = node;
              
            }
            head = node;
            count++;
        }
        public T RemoveLast()
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty, you cannot delete a element");
            }
            T tmp = head.Value;
            if (count == 1)
            {
                tail = head = null;
                count = 0;
            }
            else
            {
                tail = tail.Prev;
                tail.Next = null;
                count--;
            }
            return tmp;
        }

        public T RemoveFirst()
        {
            
            if (IsEmpty)
            {
                throw new Exception("List is empty, you cannot delete a element");
            }
            T tmp = head.Value;
            if (count == 1)
            {
                head = null;
                tail = null;
                count = 0;
            }
            else
            {
               
                head = head.Next;
                head.Prev = null;
                count--;
                
            }
            return head.Value;
           
        }
        public T GetTLast()
        {
            if(IsEmpty)
            {
                throw new Exception();
            }
            return tail.Value;
        }
       
        public bool Searchtheelement(T data)
        {
            Node<T> tmp = head;
            while(tmp!=null)
            {
                if (tmp.Value.Equals(data))
                    return true;
                tmp = tmp.Next;
            }
            return false;
        }
            


        


       
    }
}
