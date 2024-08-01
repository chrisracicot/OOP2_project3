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

		public ILinkedListADT list;
		[SetUp]
		public void Setup()
		{
			User usr1 = new User(1, "Aaaaa", "aaa@mehdi.com", "apassword");
			User usr2 = new User(2, "Bbbbb", "bbb@mehdi.com", "bpassword");
			User usr3 = new User(3, "Ccccc", "ccc@mehdi.com", "cpassword");
			User usr4 = new User(4, "Ddddd", "ddd@mehdi.com", "dpassword");
			User usr5 = new User(5, "Eeeee", "eee@mehdi.com", "epassword");
			User usr6 = new User(6, "Fffff", "fff@mehdi.com", "fpassword");
			User usr7 = new User(7, "Ggggg", "ggg@mehdi.com", "gpassword");
			User usr8 = new User(8, "Hhhhh", "hhh@mehdi.com", "hpassword");

			list = new SLL();
			list.AddLast(usr1);
			list.AddLast(usr2);
			list.AddLast(usr3);
			list.AddLast(usr4);
			list.AddLast(usr5);
			list.AddLast(usr6);
			list.AddLast(usr7);
			list.AddLast(usr8);
		}

		[Test]
		public void TestEmptyList()
		{
			ILinkedListADT listerine = new SLL();
			Assert.IsTrue(listerine.IsEmpty());
		}

		[Test]
		public void TestPrepend()
		{
			User newUser = new User(529, "Crabb", "Crabb@mehdi.com", "crabpassword");
			list.AddFirst(newUser);
			Assert.AreEqual(newUser, list.GetValue(0));
		}
	}
}
