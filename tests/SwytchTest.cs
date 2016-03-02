using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using Saklient;
using Saklient.Cloud;
using Saklient.Cloud.Resources;
using Tamir.SharpSsh;


namespace Saklient.Cloud.Tests
{
	
	using Hash = Dictionary<string, object>;
	
	[TestFixture]
	[Category("Swytch")]
	public class SwytchTest
	{

		[Test]
		public void Test()
		{
			string root = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory);
			string token = System.Environment.GetEnvironmentVariable("SACLOUD_TOKEN");
			string secret = System.Environment.GetEnvironmentVariable("SACLOUD_SECRET");
			string zone = System.Environment.GetEnvironmentVariable("SACLOUD_ZONE");
			API api = API.Authorize(token, secret, zone);
			
			
			/////////////////////////////////////////////////////////////////////////////////////////////////////////
			// should be CRUDed
			{
				string name = "!cs_nunit-" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "-" + (new Regex(@"-.+")).Replace(System.Guid.NewGuid().ToString(), "");
				string description = "This instance was created by saklient.cs NUnit";
				
				//
				Console.WriteLine("スイッチを作成しています...");
				Swytch swytch = api.Swytch.Create();
				swytch.Name = name;
				swytch.Description = description;
				swytch.Save();
				Assert.Greater(Convert.ToInt64(swytch.Id), 0);
				
				//
				Console.WriteLine("サーバを作成しています...");
				Server server = api.Server.Create();
				server.Name = name;
				server.Description = description;
				server.Plan = api.Product.Server.GetBySpec(1, 1);
				server.Save();
				Assert.Greater(Convert.ToInt64(server.Id), 0);
				
				//
				Console.WriteLine("インタフェースを増設しています...");
				Iface iface = server.AddIface();
				Assert.Greater(Convert.ToInt64(iface.Id), 0);
				Assert.AreEqual(server.Id, iface.ServerId);
				server.Reload();
				Assert.AreEqual(iface.Id, server.Ifaces[0].Id);
				Assert.AreEqual(server.Id, server.Ifaces[0].ServerId);
				iface.Reload();
				Assert.IsNull(iface.SwytchId);
				
				//
				Console.WriteLine("インタフェースをスイッチに接続しています...");
				iface.ConnectToSwytch(swytch);
				Assert.AreEqual(swytch.Id, iface.SwytchId);
                Assert.AreEqual(swytch.Id, api.Swytch.GetById(iface.SwytchId).Id);
				
				//
				Console.WriteLine("インタフェースをスイッチから切断しています...");
				iface.DisconnectFromSwytch();
				
				//
				Console.WriteLine("サーバを削除しています...");
				server.Destroy();
				
				//
				Console.WriteLine("スイッチを削除しています...");
				swytch.Destroy();
				
			}
			
		}
		
	}

}
