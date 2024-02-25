using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Lib
{
    public class MergeableStack
    {
        class Node
        {
            public Node next;
            public Node prev;
            public int data;

            public Node(int value)
            {
                data = value;
                next = null;
                prev = null;
            }
        }

        Node head;
        Node tail;

        public MergeableStack()
        {
            head = null;
            tail = null;
        }

        public void Push(int  value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
                head.next = null;
                head.prev = null;
                tail = node;
            }
            else
            {
                head.prev = node;
                head = node;
            }
        }

        public void Pop()
        {
            if (head == null)
                Console.WriteLine("stack underflow");
            if(head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                Node newHead = head.next;
                head = newHead;
            }
        }

        public void display()
        {
            if(tail != null)
            {
                Node n = tail;
                while(n != null)
                {
                    Console.WriteLine(n.data +" ");
                    n = n.prev;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Stack Underflow!");
            }
        }

        public void merge(MergeableStack s)
        {
            head.prev = s.tail;
            s.tail.next = head;
            head = s.head;
            s.tail = null;
            s.head = null;
        }


    }
}
