using System;
using System.Collections.Generic;
using System.Text;

namespace pract.LinkedList
{
    public class SingleLinkedList
    {
        Node head = null;
        Node newItem = new Node();



        public void AddToLast(object data)
        {
            // if the head is empty, add a new node and assign the method parameter to it, then point it to null.
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                head.next = null;
            }
            else
            {
                // if the head is not empty, create a new field to represent the current node and assign the head to it
                Node current = head;

                // use a loop to keep checking if the current node is empty
                while (current.next != null)
                {
                    current = current.next;
                }

                // this is the last node
                current.next = newItem;
                newItem.next = null;

            }
        }

        public void AddToFisrt(object data)
        {

            Node newItem = new Node();
            newItem.data = data;

            newItem.next = head;
            head = newItem;

        }

        public void ReadAll()
        {
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);

        }
    }
}
