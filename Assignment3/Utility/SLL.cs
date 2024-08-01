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
		public int Count { get; set; }
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
	}
	
}
