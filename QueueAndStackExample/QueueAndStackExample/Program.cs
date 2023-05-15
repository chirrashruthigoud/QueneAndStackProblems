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
          StackQueue stack = new StackQueue();
            stack.PushNode(56);
            stack.PushNode(30);
            stack.PushNode(70);
            stack.Display();
            Console.ReadLine();
        }
    }
}
