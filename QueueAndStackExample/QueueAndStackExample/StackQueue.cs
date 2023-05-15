using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QueueAndStackExample
{
    public class StackQueue
    {
        public Node top;

        public void StackMethod()
        {
            top = null;
        }
        public void PushNode(int value)
        {
            Node node = new Node(value);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine("Pushed values :" + value);
        }
        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine("stack values : " + temp.data);
                temp = temp.next;
            }

        }

    }
    
}
