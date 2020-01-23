using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        static void Main()
        {
            Queue q = new Queue();
            q.Push(6);
            q.Push(3);
            q.Push(2);
            q.Push(5);
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
                    Next.Pull();
                }
            }
            public void Write()
            {
                while(Next!=null)
                {
                    Console.Write(value + ' ');
                    Next.Write();
                }
            }
        }
        class Queue
        {
            private QueueNode Top;
            public void Push(int newval)
            {
                if (Top == null)
                    Top = new QueueNode(newval);
                else
                    Top.Push(newval);
            }
            public void Pull()
            {
                if (Top == null)
                    Console.WriteLine("No queue");
                else
                    Top.Pull();
            }
            public bool IsEmpty()
            {
                if (Top == null) return true;
                else return false;
            }
            public void Delete()
            {
                while(!IsEmpty())
                {
                    Pull();
                }
            }
            public void Write()
            {
                if (Top == null)
                    Console.WriteLine("No tree");
                else
                    Top.Write();                
            }
        }

    }
}
