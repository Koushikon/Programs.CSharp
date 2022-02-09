using System;

namespace Sinngly
{
    class Program
    {
        public ListNode head;
        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0)
            {
                this.val = val;
                this.next = null;
            }
        }

        public void PUSH_first(int data)
        {
            ListNode new_node = new ListNode(data);

            // if (head.next == null)
            //     head.next = new_node;
            // else
            // {
            new_node.next = head;
            head = new_node;
            // }
        }

        public void PUSH_middle(int data, int pos)
        {
            if (head == null)
                return;

            ListNode new_node = new ListNode(data);

            ListNode middle = head;
            int count = 1;
            while (count != pos)
            {
                if (middle.next != null)
                {
                    middle = middle.next;
                    count++;
                }
                else
                {
                    Console.WriteLine("The Given Position is Incorrect.");
                    return;
                }
            }

            new_node.next = middle.next;
            middle.next = new_node;
        }

        public void PUSH_last(int data)
        {
            ListNode new_node = new ListNode(data);
            // If In Empty ListNode try to add new_node by PUSH_last
            if (head == null)
            {
                head = new_node;
                return;
            }

            // Finding out the last ListNode
            ListNode last = head;
            while (last.next != null)
                last = last.next;

            last.next = new_node;
        }

        public void Display()
        {
            if (head == null)
                return;

            ListNode current = head;

            do
            {
                Console.Write("{0}  ", current.val);
                current = current.next;
            } while (current != null);
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Program lnode = new Program();

            {
                lnode.PUSH_last(5);
                lnode.PUSH_first(70);
                lnode.PUSH_first(10);
                lnode.Display();
                lnode.PUSH_last(110);
                lnode.PUSH_last(130);
                lnode.PUSH_middle(50, 1);
                lnode.Display();
                lnode.PUSH_middle(115, 4);
                lnode.PUSH_middle(150, 7);
                lnode.Display();
            }
        }
    }
}