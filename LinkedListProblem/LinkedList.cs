using System;

namespace LinkedListProblem
{
	public class LinkedList
	{
		internal Node head;

		//creating add method to add the data in linked list sequentially
		internal void Add(int data)
		{
			Node node = new Node(data);
			if (this.head == null)
				this.head = node;
			else
			{
				Node temp = head;
				while (temp.next != null)
				{
					temp = temp.next;
				}
				temp.next = node;
			}
			Console.WriteLine("{0} inserted into the linked list", node.data);
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

		//inserting the element at particular index
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

