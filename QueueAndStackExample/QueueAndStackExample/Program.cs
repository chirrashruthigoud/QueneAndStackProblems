using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStackExample
{
    public class Program
    {
       public static void Main(string[] args)
        {
            StackQueue queue = new StackQueue();
            queue.EnqueueMethod(56);
            queue.EnqueueMethod(30);
            queue.EnqueueMethod(70);
            queue.DequeueMethod();
            queue.Display();
          //StackQueue stack = new StackQueue();
          //  stack.PushNode(56);
          //  stack.PushNode(30);
          //  stack.PushNode(70);
          //      stack.PopNode();
          //      stack.PeekNode();
          //  stack.Display();
            Console.ReadLine();
        }
    }
}
