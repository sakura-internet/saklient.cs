using NUnit.Framework;
using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using Saklient;
using Saklient.Cloud;
using Saklient.Cloud.Resources;

namespace Saklient.Cloud.Tests
{
	
	using Hash = Dictionary<string, object>;
	
	[TestFixture]
	[Category("Bridge")]
	public class BridgeTest
	{
		
		const bool USE_STATIC_RESOURCE = false;
		
		[Test]
		public void Test()
		{
			string root = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory);
			string token = System.Environment.GetEnvironmentVariable("SACLOUD_TOKEN");
			string secret = System.Environment.GetEnvironmentVariable("SACLOUD_SECRET");
			string zone = System.Environment.GetEnvironmentVariable("SACLOUD_ZONE");
			API api = API.Authorize(token, secret, zone);
			
			string name = "!cs_nunit-" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "-" + (new Regex(@"-.+")).Replace(System.Guid.NewGuid().ToString(), "");
			
			Console.WriteLine("リージョンを検索しています...");
			List<Region> regions = api.Facility.Region.Find();
			
			Console.WriteLine("ブリッジを作成しています...");
			Bridge bridge = api.Bridge.Create();
			bridge.Name = name;
			bridge.Region = regions[0];
			bridge.Save();
			
			Console.WriteLine("ブリッジを削除しています...");
			bridge.Destroy();
			
		}
		
	}

}
