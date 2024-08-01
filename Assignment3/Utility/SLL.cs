using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3.Utility
{
	public class SLL : ILinkedListADT
	{
		public Node Head { get; set; }
		public Node Tail { get; set; }
		public int Counter { get; set; }
		public bool IsEmpty()
		{
			if (Head == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Clear()
		{
			Head = null;
			Tail = null;
			Counter = 0;
		}

		public void AddFirst(User value)
		{
			Node newNode = new Node(value);
			if (Head == null)
			{
				Head = newNode;
				Tail = newNode;

			}

			else
			{
				newNode.Next = Head;
				Head = newNode;

			}

			Counter++;
		}

		public void AddLast(User value)
		{
			if (Head == null)
			{
				AddFirst(value);
			}
			else
			{
				Node newNode = new Node(value);
				Tail.Next = newNode;
				Tail = newNode;
				Counter++;
			}

		}

		public void Add(User value, int index)
		{
			if (index == 0)
			{
				AddFirst(value);
			}
			else if (index == Counter)
			{
				AddLast(value);
			}
			else
			{
				Node newNode = new Node(value);
				Node current = Head;
				for (int i = 0; i < index - 1; i++)
				{
					current = current.Next;
				}
				newNode.Next = current.Next;
				current.Next = newNode;
				Counter++;
			}
		}

		public void Replace(User value, int index)
		{
			if (index == 0)
			{
				Head.Value = value;
			}
			else if (index == Counter - 1)
			{
				Tail.Value = value;
			}
			else
			{
				Node current = Head;
				for (int i = 0; i < index; i++)
				{
					current = current.Next;
				}
				current.Value = value;
			}
		}

		public int Count() { return Counter; }

		public void RemoveFirst()
		{
			Head = Head.Next;
			Counter--;

		}

		public void RemoveLast()
		{
			Node current = Head;
			for (int i = 0; i < Counter - 2; i++)
			{
				current = current.Next;
			}
			current.Next = null;
			Tail = current;
			Counter--;
		}

		public void Remove(int index)
		{
			if (index == 0)
			{
				RemoveFirst();
			}
			else if (index == Counter - 1)
			{
				RemoveLast();
			}
			else
			{
				Node current = Head;
				for (int i = 0; i < index - 1; i++)
				{
					current = current.Next;
				}
				current.Next = current.Next.Next;
				Counter--;
			}
		}

		public User GetValue(int index)
		{
			if (index == 0)
			{
				return Head.Value;
			}
			else if (index == Counter - 1)
			{
				return Tail.Value;
			}
			else
			{
				Node current = Head;
				for (int i = 0; i < index; i++)
				{
					current = current.Next;
				}
				return current.Value;
			}
		}

		public int IndexOf(User user)
		{
			for (int i = 0; i < Counter; i++)
			{
				if (GetValue(i).Equals(user))
				{
					return i;
				}
			}
			return -1;

		}

		public bool Contains(User user)
		{
			for (int i = 0; i < Counter; i++)
			{
				if (GetValue(i).Equals(user))
				{
					return true;
				}
			}
			return false;
		}

	}
}
