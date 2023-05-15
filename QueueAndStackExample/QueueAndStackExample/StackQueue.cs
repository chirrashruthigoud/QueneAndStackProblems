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
        public Node head;

        public void EnqueueMethod()
        {
            head = null;
        }
        public void EnqueueMethod(int value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Enqueue element :" +node.data);
        }
        public void DequeueMethod()
        {
            if (head == null)
            {
                Console.WriteLine("queue is empty");
            }
            else
            {
                this.head = this.head.next;
                Console.WriteLine("first queue is removed.");

            }
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }
}
