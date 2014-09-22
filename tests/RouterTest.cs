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
	[Category("Router")]
	public class RouterTest
	{
		
		const bool USE_STATIC_RESOURCE = false;
		
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
			long maskLen = 28;
			
			Swytch swytch = null;
			if (!USE_STATIC_RESOURCE) {
				Console.WriteLine("ルータ＋スイッチの帯域プランを検索しています...");
				List<RouterPlan> plans = api.Product.Router.Find();
				long minMbps = 0x7FFFFFFF;
				foreach (RouterPlan plan in plans) {
					Assert.Greater((long)plan.BandWidthMbps, 0);
					minMbps = Math.Min((long)plan.BandWidthMbps, minMbps);
				}
				
				Console.WriteLine("ルータ＋スイッチを作成しています...");
				Router router = api.Router.Create();
				router.Name = name;
				router.Description = description;
				router.BandWidthMbps = minMbps;
				router.NetworkMaskLen = maskLen;
				router.Save();
				
				Console.WriteLine("ルータ＋スイッチの作成完了を待機しています...");
				if (!router.SleepWhileCreating()) Assert.Fail("ルータが正常に作成されません");
				swytch = router.GetSwytch();
			}
			else {
				Console.WriteLine("既存のルータ＋スイッチを取得しています...");
				List<Swytch> swytches = api.Swytch.WithNameLike("saklient-static-1").Limit(1).Find();
				Assert.AreEqual(swytches.Count, 1);
				swytch = swytches[0];
			}
			Assert.Greater(swytch.Ipv4Nets.Count, 0);
			
			//
			Console.WriteLine("ルータ＋スイッチの帯域プランを変更しています...");
			string routerIdBefore = swytch.Router.Id;
			swytch.ChangePlan(swytch.Router.BandWidthMbps==100 ? 500 : 100);
			Assert.AreNotEqual(routerIdBefore, swytch.Router.Id);
			
			//
			if (0 < swytch.Ipv6Nets.Count) {
				Console.WriteLine("ルータ＋スイッチからIPv6ネットワークの割当を解除しています...");
				swytch.RemoveIpv6Net();
			}
			Console.WriteLine("ルータ＋スイッチにIPv6ネットワークを割り当てています...");
			Ipv6Net v6net = swytch.AddIpv6Net();
			Assert.AreEqual(1, swytch.Ipv6Nets.Count);
			
			//
			for (int i=swytch.Ipv4Nets.Count-1; 1<=i; i--) {
				Console.WriteLine("ルータ＋スイッチからスタティックルートの割当を解除しています...");
				Ipv4Net net = swytch.Ipv4Nets[i];
				swytch.RemoveStaticRoute(net);
			}
			
			Console.WriteLine("ルータ＋スイッチにスタティックルートを割り当てています...");
			Ipv4Net net0 = swytch.Ipv4Nets[0];
			string nextHop = long2ip(ip2long(net0.Address) + 4);
			Ipv4Net sroute = swytch.AddStaticRoute(28, nextHop);
			Assert.AreEqual(2, swytch.Ipv4Nets.Count);
		}
		
	}

}
