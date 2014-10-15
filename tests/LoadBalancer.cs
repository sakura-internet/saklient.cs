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
	[Category("LoadBalancer")]
	public class LoadBalancerTest
	{
		
		const string TESTS_CONFIG_READYMADE_LB_ID = "112600809060";
		
		public static long ip2long(string str)
		{
			IPAddress ip;
			if (!IPAddress.TryParse(str, out ip)) return -1;
			Byte[] b = ip.GetAddressBytes();
			return ((long)b[0])<<24 | ((long)b[1])<<16 | ((long)b[2])<<8 | ((long)b[3]);
		}
		
		public static string long2ip(long val)
		{
			IPAddress ip;
			if (!IPAddress.TryParse(val.ToString(), out ip)) return null;
			return ip.ToString();
		}
		
		[Test]
		public void Test()
		{
			string root = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory);
			string token = System.Environment.GetEnvironmentVariable("SACLOUD_TOKEN");
			string secret = System.Environment.GetEnvironmentVariable("SACLOUD_SECRET");
			string zone = System.Environment.GetEnvironmentVariable("SACLOUD_ZONE");
			API api = API.Authorize(token, secret, zone);
			
			string name = "!cs_nunit-" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "-" + (new Regex(@"-.+")).Replace(System.Guid.NewGuid().ToString(), "");
			string description = "This instance was created by saklient.cs NUnit";
			string tag = "saklient-test";
			
			
			
			LoadBalancer lb;
			Ipv4Net net;
			Swytch swytch;
			
			// create a LB
			
			if (TESTS_CONFIG_READYMADE_LB_ID==null) {
				
				// search a switch
				Console.WriteLine("searching a swytch...");
				List<Swytch> swytches = api.Swytch.WithTag("lb-attached").Limit(1).Find();
				Assert.Greater(swytches.Count, 0);
				swytch = swytches[0];
				Assert.IsNotNull(swytch);
				Assert.Greater(swytch.Ipv4Nets.Count, 0);
				net = swytch.Ipv4Nets[0];
				Assert.IsNotNull(net);
				Console.WriteLine(net.Address + "/" + net.MaskLen + "->" + net.DefaultRoute);
				
				// create a loadbalancer
				Console.WriteLine("creating a LB...");
				long vrid = 123;
				lb = (LoadBalancer)api.Appliance.CreateLoadBalancer(swytch, vrid, new List<string>{"133.242.255.244", "133.242.255.245"}, true);
				Assert.IsNotNull(lb);
				
				bool ok = false;
				try {
					lb.Save();
				}
				catch (Saklient.Errors.SaklientException ex)
				{
					ok = true;
				}
				if (!ok) Assert.Fail("Requiredフィールドが未set時は SaklientException がスローされなければなりません");
				lb.Name = name;
				lb.Description = "";
				lb.Tags = new List<string>{ tag };
				lb.Save();
				
				lb.Reload();
				Assert.AreEqual(lb.DefaultRoute, net.DefaultRoute); 
				Console.WriteLine(lb.MaskLen + " =? " + net.MaskLen);
				Console.WriteLine(lb.Vrid + " =? " + vrid);
//				Assert.AreEqual((long?)lb.MaskLen, net.MaskLen); 
//				Assert.AreEqual((long?)lb.Vrid, vrid); 
				Assert.AreEqual(lb.SwytchId, swytch.Id); 
				
				// wait the LB becomes up
				Console.WriteLine("waiting the LB becomes up...");
				if (!lb.SleepUntilUp()) Assert.Fail("ロードバランサが正常に起動しません");
				
			}
			else {
				
				lb = (LoadBalancer)api.Appliance.GetById(TESTS_CONFIG_READYMADE_LB_ID);
				Assert.IsNotNull(lb);
				swytch = lb.GetSwytch();
				Assert.IsNotNull(swytch);
				net = swytch.Ipv4Nets[0];
				Assert.IsNotNull(net);
				Console.WriteLine(net.Address + "/" + net.MaskLen + " -> " + net.DefaultRoute);
				
			}
			
			
			
			// clear virtual ips
			
			lb.ClearVirtualIps();
			lb.Save();
			lb.Reload();
			Assert.AreEqual(lb.VirtualIps.Count, 0);
			
			
			
			// setting virtual ips test 1
			
			string vip1Ip     = long2ip(ip2long(net.DefaultRoute) + 5);
			string vip1SrvIp1 = long2ip(ip2long(net.DefaultRoute) + 6);
			string vip1SrvIp2 = long2ip(ip2long(net.DefaultRoute) + 7);
			string vip1SrvIp3 = long2ip(ip2long(net.DefaultRoute) + 8);
			string vip1SrvIp4 = long2ip(ip2long(net.DefaultRoute) + 9);
			
			lb.AddVirtualIp(new Hash{
				{"vip", vip1Ip},
				{"port", 80},
				{"delay", 15},
				{"servers", new List<object>{
					new Hash{ {"ip",vip1SrvIp1}, {"port",80}, {"protocol","http"}, {"pathToCheck","/index.html"}, {"responseExpected",200} },
					new Hash{ {"ip",vip1SrvIp2}, {"port",80}, {"protocol","https"}, {"pathToCheck","/"}, {"responseExpected",200} },
					new Hash{ {"ip",vip1SrvIp3}, {"port",80}, {"protocol","tcp"} }
				}}
			});
			
			string vip2Ip     = long2ip(ip2long(net.DefaultRoute) + 10);
			string vip2SrvIp1 = long2ip(ip2long(net.DefaultRoute) + 11);
			string vip2SrvIp2 = long2ip(ip2long(net.DefaultRoute) + 12);
			
			LbVirtualIp vip2 = lb.AddVirtualIp();
			vip2.VirtualIpAddress = vip2Ip;
			vip2.Port = 80;
			vip2.DelayLoop = 15;
			LbServer vip2Srv1 = vip2.AddServer();
			vip2Srv1.IpAddress = vip2SrvIp1;
			vip2Srv1.Port = 80;
			vip2Srv1.Protocol = "http";
			vip2Srv1.PathToCheck = "/index.html";
			vip2Srv1.ResponseExpected = 200;
			LbServer vip2Srv2 = vip2.AddServer();
			vip2Srv2.IpAddress = vip2SrvIp2;
			vip2Srv2.Port = 80;
			vip2Srv2.Protocol = "tcp";
			lb.Save();
			lb.Reload();
			
			Assert.AreEqual(lb.VirtualIps.Count, 2);
			Assert.AreEqual(lb.VirtualIps[0].VirtualIpAddress, vip1Ip);
			Assert.AreEqual(lb.VirtualIps[0].Servers.Count, 3);
			Assert.AreEqual(lb.VirtualIps[0].Servers[0].IpAddress, vip1SrvIp1);
			Assert.AreEqual(lb.VirtualIps[0].Servers[0].Port, 80);
			Assert.AreEqual(lb.VirtualIps[0].Servers[0].Protocol, "http");
			Assert.AreEqual(lb.VirtualIps[0].Servers[0].PathToCheck, "/index.html");
			Assert.AreEqual(lb.VirtualIps[0].Servers[0].ResponseExpected, 200);
			Assert.AreEqual(lb.VirtualIps[0].Servers[1].IpAddress, vip1SrvIp2);
			Assert.AreEqual(lb.VirtualIps[0].Servers[1].Port, 80);
			Assert.AreEqual(lb.VirtualIps[0].Servers[1].Protocol, "https");
			Assert.AreEqual(lb.VirtualIps[0].Servers[1].PathToCheck, "/");
			Assert.AreEqual(lb.VirtualIps[0].Servers[1].ResponseExpected, 200);
			Assert.AreEqual(lb.VirtualIps[0].Servers[2].IpAddress, vip1SrvIp3);
			Assert.AreEqual(lb.VirtualIps[0].Servers[2].Port, 80);
			Assert.AreEqual(lb.VirtualIps[0].Servers[2].Protocol, "tcp");
			Assert.AreEqual(lb.VirtualIps[1].VirtualIpAddress, vip2Ip);
			Assert.AreEqual(lb.VirtualIps[1].Servers.Count, 2);
			Assert.AreEqual(lb.VirtualIps[1].Servers[0].IpAddress, vip2SrvIp1);
			Assert.AreEqual(lb.VirtualIps[1].Servers[0].Port, 80);
			Assert.AreEqual(lb.VirtualIps[1].Servers[0].Protocol, "http");
			Assert.AreEqual(lb.VirtualIps[1].Servers[0].PathToCheck, "/index.html");
			Assert.AreEqual(lb.VirtualIps[1].Servers[0].ResponseExpected, 200);
			Assert.AreEqual(lb.VirtualIps[1].Servers[1].IpAddress, vip2SrvIp2);
			Assert.AreEqual(lb.VirtualIps[1].Servers[1].Port, 80);
			Assert.AreEqual(lb.VirtualIps[1].Servers[1].Protocol, "tcp");
			
			
			
			// setting virtual ips test 2
			
			lb.GetVirtualIpByAddress(vip1Ip).AddServer(new Hash{
				{"ip", vip1SrvIp4},
				{"port", 80},
				{"protocol", "ping"}
			});
			lb.Save();
			lb.Reload();
			
			Assert.AreEqual(lb.VirtualIps.Count, 2);
			Assert.AreEqual(lb.VirtualIps[0].Servers.Count, 4);
			Assert.AreEqual(lb.VirtualIps[0].Servers[3].IpAddress, vip1SrvIp4);
			Assert.AreEqual(lb.VirtualIps[0].Servers[3].Port, 80);
			Assert.AreEqual(lb.VirtualIps[0].Servers[3].Protocol, "ping");
			Assert.AreEqual(lb.VirtualIps[1].Servers.Count, 2);
			
			
			
			// checking status
			
			lb.ReloadStatus();
			foreach (LbVirtualIp vip in lb.VirtualIps) {
				Console.WriteLine("  vip " + vip.VirtualIpAddress + ":" + vip.Port + " every " + vip.DelayLoop + "sec(s)");
				foreach (LbServer server in vip.Servers) {
					string msg = "";
					msg += "    [" + server.Status + "(" + server.ActiveConnections + ")]";
					msg += " server " + server.Protocol + "://" + server.IpAddress;
					if (server.Port != null) msg += ":" + server.Port;
					if (server.PathToCheck != null) msg += server.PathToCheck;
					msg += " answers";
					if (server.ResponseExpected != null) msg += " " + server.ResponseExpected;
					Console.WriteLine(msg);
					Assert.AreEqual(server.Status, "down");
				}
			}
			
			
			
			// delete the LB
			
			if (TESTS_CONFIG_READYMADE_LB_ID==null) {
				
				// stop the LB
				Thread.Sleep(1);
				Console.WriteLine("stopping the LB...");
				if (!lb.Stop().SleepUntilDown()) Assert.Fail("ロードバランサが正常に停止しません");
				
				// delete the LB
				Console.WriteLine("deleting the LB...");
				lb.Destroy();
				
			}
			
		}
		
	}

}
