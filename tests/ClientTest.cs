using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using Util = Saklient.Util;

namespace Saklient.Cloud.Tests
{
	
	using Hash = Dictionary<string, object>;
	
	[TestFixture]
	public class ClientTest
	{

		[Test]
		public void Test()
		{
			string token = System.Environment.GetEnvironmentVariable("SACLOUD_TOKEN");
			string secret = System.Environment.GetEnvironmentVariable("SACLOUD_SECRET");
			string zone = System.Environment.GetEnvironmentVariable("SACLOUD_ZONE");
			
			Client client = new Client(token, secret);
			if (zone != null && zone != "") {
				if (zone=="is1x" || zone=="is1y") client.SetApiRoot("https://secure.sakura.ad.jp/cloud-test/");
				client.SetApiRootSuffix("zone/" + zone + "/");
			}
			Assert.IsInstanceOfType(typeof(Client), client);
			object query = new Hash {
				{ "Filter", new Hash {
					{ "Tags", new [] {
						new [] { "distro-centos", "distro-ver-6.5" },
						new [] { "distro-sl" }
					}}
				}}
			};
			object obj = client.Request("GET", "/archive", query);
			ArrayList archives = (ArrayList)Util.GetByPath(obj, "Archives");
			foreach (Hash archive in archives) {
				Console.WriteLine((string)archive["Name"]);
			}
		}
		
	}

}
