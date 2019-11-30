using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class Queue
    {
        static int size = 10;
        int[] arr = new int[size];
        int head;
        int tail;
        public Queue()
        {
            head = tail = -1;
        }
        public void enqueue(int data)
        {
            if (head==-1)
            {
                head++;
            }
            if (tail==size-1)
            {
                Console.WriteLine("queue is full");
                return;
            }
            else
            {
                arr[++tail] = data;
            }
        }
        public int dequeue()
        {
            if (head == -1|| head==tail+1)
            {
                Console.WriteLine("queue is empty");
                return 0;
            }
            
            else
            {
                return arr[head++];
            }
        }
        public void print()
        {
            if (head == -1 || head == tail + 1)
            {
                Console.WriteLine("queue is empty");
                return ;
            }
            for (int i = head; i <=tail; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
