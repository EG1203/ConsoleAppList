using System;
class List
{
	Node head;

	public class Node
	{
		public int data;
		public Node next;
		public Node(int d)
		{
			data = d;
			next = null;
		}
	}


	public void push(int new_data)
	{
		Node new_node = new Node(new_data);
		new_node.next = head;
		head = new_node;
	}


	void deleteNode(int key)
	{

		Node temp = head, prev = null;


		if (temp != null &&
			temp.data == key)
		{

			head = temp.next;
			return;
		}


		while (temp != null &&
			temp.data != key)
		{
			prev = temp;
			temp = temp.next;
		}


		if (temp == null)
			return;


		prev.next = temp.next;
	}


	void deleteEvenNodes()
	{
		Node ptr = head;


		while (ptr != null)
		{

			if (ptr.data % 2 == 0)
			{

				deleteNode(ptr.data);
			}
			ptr = ptr.next;
		}
	}


	public void printList()
	{
		Node ptr = head;
		while (ptr != null)
		{
			Console.Write(ptr.data + "-> ");
			ptr = ptr.next;
		}
	}


	public static void Main(string[] args)
	{
		List head = new List();

		head.push(19);
		head.push(18);
		head.push(3);
		head.push(4);
		head.push(1);

		Console.Write("\nВесь список: ");
		head.printList();

		head.deleteEvenNodes();

		Console.Write("\nИтоговый список: ");
		head.printList();
	}
}
