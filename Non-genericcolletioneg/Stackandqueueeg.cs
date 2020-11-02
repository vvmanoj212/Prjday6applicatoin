﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_genericcolletioneg
{
    class Stackandqueueeg
    {
        static void Main()
        {
            Stack s = new Stack();
            s.Push("java");
            s.Push(10);
            s.Push("dbms");
            s.Push(30.89);
            foreach (object item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Popped 1 time:{0}", s.Pop());// push the element out of the stack
            Console.WriteLine("Peek:{0}", s.Peek()); // shows current top element in stack
            foreach (object item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");

            Queue q = new Queue();
            q.Enqueue("hari");
            q.Enqueue("jai");
            q.Enqueue("Sivam");
            foreach (object item in q)

            {
                Console.WriteLine(item);


            }
            Console.WriteLine("Top element in queue:{0}", q.Peek());
            Console.WriteLine("Remove the element :{0}", q.Dequeue());


            foreach (object item in q)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}