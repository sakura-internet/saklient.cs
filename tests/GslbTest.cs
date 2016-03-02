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
	[Category("Gslb")]
	public class GslbTest
	{
		
		const string TESTS_CONFIG_READYMADE_LB_ID = null;
		
		[Test]
		public void Test()
		{
			string root = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory);
			string token = System.Environment.GetEnvironmentVariable("SACLOUD_TOKEN");
			string secret = System.Environment.GetEnvironmentVariable("SACLOUD_SECRET");
			string zone = System.Environment.GetEnvironmentVariable("SACLOUD_ZONE");
			API api = API.Authorize(token, secret, zone);
			
			string name = "!cs_nunit-" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "-" + (new Regex(@"-.+")).Replace(System.Guid.NewGuid().ToString(), "");
			
			//
			Console.WriteLine("GSLBを作成しています...");
			Gslb gslb = api.CommonServiceItem.CreateGslb("http", 10, true);
			gslb.PathToCheck = "/index.html";
			gslb.ResponseExpected = 200;
			gslb.Name = name;
			gslb.Description = "This is a test";
			gslb.Save();
			string id = gslb.Id;
			Assert.Greater(Convert.ToInt64(id), 0);
			Assert.AreEqual(name, gslb.Name);
			Assert.AreEqual(0, gslb.Servers.Count);
			
//			Console.WriteLine(api.CommonServiceItem.GetById(id).GetType());
			gslb = api.CommonServiceItem.GetById(id) as Gslb;
			Assert.AreEqual(id, gslb.Id);
			Assert.AreEqual("/index.html", gslb.PathToCheck);
			Assert.AreEqual(200, gslb.ResponseExpected);
			Assert.AreEqual(name, gslb.Name);
			Assert.AreEqual(0, gslb.Servers.Count);
			
			GslbServer server = gslb.AddServer();
			server.Enabled = true;
			server.Weight = 10;
			server.IpAddress = "49.212.82.90";
			gslb.Save();
			Assert.AreEqual(1, gslb.Servers.Count);
			
			gslb = api.CommonServiceItem.GetById(id) as Gslb;
			Assert.AreEqual(1, gslb.Servers.Count);
			
			Console.WriteLine("GSLBを削除しています...");
			gslb.Destroy();
			
			Console.WriteLine("checking the server power conflicts...");
			bool ok = false;
			try {
				gslb = api.CommonServiceItem.GetById(id) as Gslb;
			}
			catch (Saklient.Errors.HttpNotFoundException ex)
			{
				ok = true;
			}
			if (!ok) Assert.Fail("GSLBが正しく削除されていません");
			
		}
		
	}

}
