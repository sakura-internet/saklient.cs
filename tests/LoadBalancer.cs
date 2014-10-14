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
			
			// search a switch
			Console.WriteLine("searching a swytch...");
			List<Swytch> swytches = api.Swytch.WithTag("lb-attached").Limit(1).Find();
			Assert.Greater(swytches.Count, 0);
			Swytch swytch = swytches[0];
			Assert.Greater(swytch.Ipv4Nets.Count, 0);
			Ipv4Net net = swytch.Ipv4Nets[0];
			Console.WriteLine(net.Address + "/" + net.MaskLen + "->" + net.DefaultRoute);
			
			// create a loadbalancer
			Console.WriteLine("creating a LB...");
			long vrid = 123;
			LoadBalancer lb = (LoadBalancer)api.Appliance.CreateLoadBalancer(swytch, vrid, new List<string>{"133.242.255.244", "133.242.255.245"}, true);
			
			var ok = false;
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
//			Assert.AreEqual((long?)lb.MaskLen, net.MaskLen); 
//			Assert.AreEqual((long?)lb.Vrid, vrid); 
			Assert.AreEqual(lb.SwytchId, swytch.Id); 
			
			// wait the LB becomes up
			Console.WriteLine("waiting the LB becomes up...");
			if (!lb.SleepUntilUp()) Assert.Fail("ロードバランサが正常に起動しません");
			
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
