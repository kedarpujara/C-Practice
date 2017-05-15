using System;
namespace LinkedListC
{
	public class Node
	{
		public Node next;
		public int data;

		public Node()
		{
			next = null;
			data = 0;
		}

		//Constructor for a Node
		public Node(Node n, int d)
		{
			this.next = n;
			this.data = d;
		}

		public void setData(int d)
		{
			this.data = d;
		}

		public int getData()
		{
			return this.data;
		}

		public void setNext(Node n)
		{
			this.next = n;
		}

		public Node getNext()
		{
			return this.next;
		}
	}


    public class LinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            if (head == null)
                return;

            Node curr = head;
            while (curr != null)
            {
                Console.Write(curr.data);
                if (curr.getNext() != null)
                    Console.Write("->");
                curr = curr.next;
            }
        }

        public void addFront(int d)
        {
            Node newNode = new Node();
            //first node being added
            if (head == null)
            {
                head = newNode;
                head.data = d;
            }
            else
            {
                newNode.data = d;
                newNode.next = head;
                head = newNode;
            }
        }

        public void addEnd(int d)
        {
            Node newNode = new Node();
            if (head == null)
            {
                head = newNode;
                head.data = d;
            }
            else
            {
                Node curr = head;
                while (curr.getNext() != null) curr = curr.next;
                curr.next = newNode;
                newNode.data = d;
            }
        }

        public void addMiddle(int d, int pos)
        {
            Node newNode = new Node();
            if (head == null)
            {
                head = newNode;
                head.data = d;
            }
            else
            {
                Node curr = head;
                Node temp;
                int i = 0;
                while (i < pos - 1 && curr.getNext() != null)
                {
                    curr = curr.next;
                    i++;
                }
                temp = curr.next;
                curr.next = newNode;
                newNode.next = temp;
                newNode.data = d;
            }
       }

        public Boolean isEmpty() {
            return (head == null);
        }
    


	}

	class Program
	{
		static void Main(string[] args)
		{
			LinkedList lList = new LinkedList();
            //Node newNode1 = new Node()
            Console.WriteLine(lList.isEmpty());
			lList.addFront(5);
			lList.addFront(4);
			lList.addFront(3);
            lList.addFront(1);
            lList.addFront(0);
            lList.addEnd(6);
            lList.addMiddle(2,2);
			lList.printAllNodes();
            Console.WriteLine();
            Console.WriteLine(lList.isEmpty());
		}
	}

}