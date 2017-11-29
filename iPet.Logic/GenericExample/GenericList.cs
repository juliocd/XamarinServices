using System;
using System.Collections.Generic;

namespace iPet.Logic.GenericExample
{
    public class GenericList<T> where T : Employee
    {
        public class Node
        {
            private Node next;
            private T data;

            public Node(T t)
            {
                next = null;
                data = t;
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

		private Node head;

		public GenericList() //constructor
		{
			head = null;
		}

		public void AddHead(T t)
		{
			Node n = new Node(t);
			n.Next = head;
			head = n;
		}

		public IEnumerator<T> GetEnumerator()
		{
			Node current = head;

			while (current != null)
			{
				yield return current.Data;
				current = current.Next;
			}
		}

		public T FindFirstOccurrence(string s)
		{
			Node current = head;
			T t = null;

			while (current != null)
			{
				//The constraint enables access to the Name property.
				if (current.Data.Name == s)
				{
					t = current.Data;
					break;
				}
				else
				{
					current = current.Next;
				}
			}
			return t;
		}
    }
}
