using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dequeue
{
    class Program
    {
        static void Main(string[] args)
        {

            Dequeue<int> dequeue = new Dequeue<int>();
            dequeue.AddFirst(5);
            dequeue.AddFirst(6);
            dequeue.AddLast(9);
            Console.WriteLine(dequeue.GetTLast());
            Console.WriteLine(dequeue.Searchtheelement(6));
            Console.WriteLine("--------------");
            Console.WriteLine(Math.Round(6.5));
            Console.WriteLine(Math.Round(11.5));
            Console.WriteLine("-------------");
            byte num = 100;
            dynamic val = num;
            Console.WriteLine(val.GetType());
            val += 100;
            Console.WriteLine(val.GetType());



        }
    }
}
