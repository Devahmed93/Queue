using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue a = new Queue();
           
            a.enqueue(1);
            a.enqueue(2);
            a.enqueue(3);
            a.dequeue();
            a.dequeue();
            
            

            a.print();

        }
    }
}
