using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Linked_Lists
{
    public class Node
    {
        public int value;
        public Node next;
    }
    public class LinkedList
    {
        private Node head;
        private Node current;
        public int count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtLast(int data)
        {
            Node newNode = new Node();
            newNode.value = data;

            current.next = newNode;
            current = newNode;
            count += 1;
        }

        public void AddAtStart(int data)
        {
            Node newNode = new Node { value = data };

            newNode.next = head.next;
            head.next = newNode;
            count += 1;

            current = newNode;
        }

        public void RemoveFromStart()
        {
            if (count > 0)
            {
                head.next = head.next.next;
                count -= 1;
            }
            else
            {
                Console.WriteLine($"Can't remove from start. LinkedList is empty.");
            }
        }

        public void RemoveFromLast()
        {
            if (count > 0)
            {

            }
            else
            {
                Console.WriteLine($"Can't remove from last. LinkedList is empty.");
            }
        }
    }
}
