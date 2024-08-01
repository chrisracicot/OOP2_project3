using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Utility;

namespace Assignment3.Tests
{
	internal class LinkedListTest
	{
		[Test]
		public void TestEmptyList()
		{
			ILinkedListADT list = new SLL();
			Assert.IsTrue(list.IsEmpty());
		}
	}
}
