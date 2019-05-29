using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Add(5);
            queue.Add(9);
            queue.Add(6);
            queue.QueuePrint();           
            
        }
    }
}
