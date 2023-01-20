using System;
namespace LinkedListProblem
{
	public class SortedLinkedList
	{
		public Node head;

		public SortedLinkedList()
		{
			this.head = null;
		}

        //Refactored the last add method to take element to get in sorted order
        internal void Add(int data)
        {
            Node node = new Node(data);
            Node currentNode = this.head, previousNode = null;
            while (currentNode != null && currentNode.data < node.data)
            {
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
            if (previousNode == null)
                this.head = node;
            else
            {
                previousNode.next = node;
            }
            node.next = currentNode;
            Console.WriteLine("{0} is inserted in to linked list to get sorted ",node.data);
        }

        //creating add first method to add the element at first position in linked list
        internal void AddFirst(int data)
        {
            Node node = new Node(data);
            node.next = this.head;
            this.head = node;
            Console.WriteLine("{0} inserted into linked list ", node.data);
        }

        //creating append method to add the element at last position
        internal void Append(int data)
        {
            Add(data);
        }

        //inserting the element at particular index in linked list
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0 && temp != null)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }

                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        //deleting first element from linked list
        internal void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                head = head.next;
                Console.WriteLine("Removed first node from linked list ");
            }
        }

        //deleting last element from linked list
        internal Node RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        //search the node element
        internal void Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Given value: " + value + " is present in Linked list");
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
                Console.WriteLine("Given value: " + value + " is not present in Linked list");
        }

        //delete the given element from linkedlist
        internal void Delete(int data)
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp.next != null)
            {
                if (temp.next.data == data)
                {
                    temp.next = temp.next.next;
                    Console.WriteLine("Element is delted from the linked list");
                }
                temp = temp.next;
            }
        }

        //implementing the size of linked list
        internal void Size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("The size of linked list is " + count);
        }

        //displaying the data from linked list
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

