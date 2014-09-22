using NUnit.Framework;
using System;
using System.Collections.Generic;
using Saklient.Cloud.Enums;

namespace Saklient.Tests
{
	
	[TestFixture]
	[Category("Enum")]
	public class EnumTest
	{

		[Test]
		public void ObjectAccessByPath()
		{
			Assert.AreEqual(EServerInstanceStatus.UP, "up");
			Assert.AreEqual(EServerInstanceStatus.DOWN, "down");
			
			Assert.AreEqual(EServerInstanceStatus.Compare("up", "up"), 0);
			Assert.AreEqual(EServerInstanceStatus.Compare("up", "down"), 1);
			Assert.AreEqual(EServerInstanceStatus.Compare("down", "up"), -1);
			Assert.IsNull(EServerInstanceStatus.Compare("UNDEFINED-SYMBOL", "up"));
			Assert.IsNull(EServerInstanceStatus.Compare("up", "UNDEFINED-SYMBOL"));
			Assert.IsNull(EServerInstanceStatus.Compare(null, "up"));
			Assert.IsNull(EServerInstanceStatus.Compare("up", null));
			Assert.IsNull(EServerInstanceStatus.Compare(null, null));
		}
		
	}

}
