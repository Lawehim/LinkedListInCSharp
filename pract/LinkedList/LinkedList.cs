using System;
using System.Collections.Generic;
using System.Text;

namespace pract.LinkedList
{
    public class SingleLinkedList
    {
        Node head = null;
        Node tail = null;
       



        public void AddToLast(object data)
        {
            // if the head is empty, add a new node and assign the method parameter to it, then point it to null.
            Node newItem = new Node
            {
                data = data
            };

            if (head == null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                // if the head is not empty, create a new field to represent the current node and assign the head to it
                /*Node current = head;

                // use a loop to keep checking if the current node is empty
                while (current.next != null)
                {
                    current = current.next;
                }

                // this is the last node
                current.next = newItem;
                newItem.next = null;*/
                head.next = newItem;
                tail = head.next;
            }
        }

        public void AddToFisrt(object data)
        {
            Node newItem = new Node
            {
                data = data
            };
            
            if (head == null)
            {
                head = newItem;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }

        }

        public void ReadAll()
        {
            Node currentNode = head;
            while (currentNode.next != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
            Console.WriteLine(currentNode.data);

        }
    }
}
