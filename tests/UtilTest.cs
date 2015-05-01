using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Saklient.Tests
{
	
	using Hash = Dictionary<string, object>;

	[TestFixture]
	[Category("Util")]
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
			
			//
			Assert.AreEqual(0, Util.Ip2long("0.0.0.0"));
			Assert.AreEqual(0x7FFFFFFF, Util.Ip2long("127.255.255.255"));
			Assert.AreEqual(0x80000000, Util.Ip2long("128.0.0.0"));
			Assert.AreEqual(0xFFFFFFFF, Util.Ip2long("255.255.255.255"));
			Assert.AreEqual(0xDEADBEEF, Util.Ip2long("222.173.190.239"));
			//
			Assert.AreEqual("0.0.0.0", Util.Long2ip(0));
			Assert.AreEqual("127.255.255.255", Util.Long2ip(0x7FFFFFFF));
			Assert.AreEqual("128.0.0.0", Util.Long2ip(0x80000000));
			Assert.AreEqual("255.255.255.255", Util.Long2ip(0xFFFFFFFF));
			Assert.AreEqual("222.173.190.239", Util.Long2ip(0xDEADBEEF));
			Assert.AreEqual("128.0.0.0", Util.Long2ip(Util.Ip2long("127.255.255.255") + 1));
			//
			Assert.AreEqual(-1, Util.Ip2long("0"));
			Assert.AreEqual(-1, Util.Ip2long(""));
			Assert.AreEqual(-1, Util.Ip2long("x"));
			Assert.AreEqual(-1, Util.Ip2long("0.0.0"));
			Assert.AreEqual(-1, Util.Ip2long("0.0.0.x"));
			Assert.AreEqual(-1, Util.Ip2long("0.0.0.0.0"));
			Assert.AreEqual(-1, Util.Ip2long("255.255.255.256"));
			Assert.AreEqual(-1, Util.Ip2long("256.255.255.255"));
			Assert.AreEqual("0.0.0.0", Util.Long2ip(0));
			Assert.AreEqual("255.255.255.255", Util.Long2ip(Util.Ip2long("0.0.0.0") - 1));
			Assert.AreEqual("0.0.0.0", Util.Long2ip(Util.Ip2long("255.255.255.255") + 1));
			
		}
		
	}

}
