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

