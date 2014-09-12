using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Saklient.Tests
{
	
	using Hash = Dictionary<string, object>;

	[TestFixture]
	public class UtilTest
	{

		[Test]
		public void ObjectAccessByPath()
		{
			Hash test = new Hash();
			Util.SetByPath(test, "top", 123);
			Assert.AreEqual(123, test["top"]);
			Util.SetByPath(test, "first.second", 456);
			Assert.IsNotNull(test["first"]);
			Assert.AreEqual(456, ((Hash)test["first"])["second"]);
			Util.SetByPath(test, ".weird..path", 789);
			Assert.IsNotNull(test["weird"]);
			Assert.AreEqual(789, ((Hash)test["weird"])["path"]);
			Util.SetByPath(test, "existing.null", null);
			Assert.IsNotNull(Util.GetByPath(test, "existing"));
			Assert.IsNull(Util.GetByPath(test, "existing.null"));
			//
			Assert.AreEqual(123, Util.GetByPath(test, "top"));
			Assert.AreEqual(456, Util.GetByPath(test, "first.second"));
			Assert.AreEqual(789, Util.GetByPath(test, ".weird..path"));
			//
			Assert.IsNull(Util.GetByPath(test, "nothing"));
			Assert.IsNull(Util.GetByPath(test, "nothing.child"));
			Assert.IsNull(Util.GetByPath(test, "top.child"));
			//
			Assert.IsTrue(Util.ExistsPath(test, "top"));
			Assert.IsFalse(Util.ExistsPath(test, "top.child"));
			Assert.IsTrue(Util.ExistsPath(test, "first.second"));
			Assert.IsTrue(Util.ExistsPath(test, ".weird..path"));
			Assert.IsFalse(Util.ExistsPath(test, "nothing"));
			Assert.IsFalse(Util.ExistsPath(test, "nothing.child"));
			Assert.IsTrue(Util.ExistsPath(test, "existing"));
			Assert.IsTrue(Util.ExistsPath(test, "existing.null"));
			//
			((Hash)test["first"])["second"] = (int)((Hash)test["first"])["second"] * 10;
			Assert.AreEqual(4560, Util.GetByPath(test, "first.second"));
			
		}
		
	}

}
