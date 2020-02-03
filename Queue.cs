using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue11
    {
        static void Main()
        {
            Queue q = new Queue();
            q.Push(6);
            q.Push(3);
            q.Push(2);
            q.Push(5);
            q.Write();
            q.Pull();
            Console.WriteLine(q.IsEmpty());
            q.Write();
            q.Delete();
            q.Write();
        }
        class QueueNode
        {
            private int value;
            public QueueNode Next { get; private set; }
            public QueueNode(int value)
            {
                this.value = value;
                Next = null;
            }
            public void Push(int newval)
            {
                if (Next == null)
                    Next = new QueueNode(newval);
                else
                    Next.Push(newval);
            }
            public void Pull()
            {
                if (Next == null) Console.WriteLine("Queue has been updated");
                else
                {
                    value = Next.value;
                }
            }
            public void Write()
            {
                if (Next != null)
                {
                    Console.Write(value + "   ");
                    Next.Write();
                }
                else
                {
                    Console.Write(value);
                    Console.WriteLine();
                }
               
            }
        }
        class Queue
        {
            private QueueNode first;
            public Queue()
            {
                first = null;
            }
            public void Top()
            {
                Console.WriteLine(first);
            }
            public void Push(int newval)
            {
                if (first == null)
                    first = new QueueNode(newval);
                else
                    first.Push(newval);
            }
            public void Pull()
            {
                if (first == null)
                    Console.WriteLine("No queue");
                else
                    first = first.Next;
            }
            public bool IsEmpty()
            {
                if (first == null) return true;
                else return false;
            }
            public void Delete()
            {
                while (!IsEmpty())
                {
                    Pull();
                }
            }
            public void Write()
            {
                if (first == null)
                    Console.WriteLine("No tree");
                else
                    first.Write();
            }
        }

    }
}
