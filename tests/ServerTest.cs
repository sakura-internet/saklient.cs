using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Saklient;
using Saklient.Cloud;
using Saklient.Cloud.Resources;

namespace Saklient.Cloud.Tests
{
	
	using Hash = Dictionary<string, object>;
	
	[TestFixture]
	public class ServerTest
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
			// should be found
			{
				Console.WriteLine("finding servers...");
				List<Server> servers = api.Server.SortByMemory().Find();
				Assert.Greater(servers.Count, 0);
				
				int mem = 0;
				Console.WriteLine("checking each server...");
				foreach (Server server in servers) {
					Assert.Greater(server.Plan.Cpu, 0);
					Assert.Greater(server.Plan.MemoryMib, 0);
					Assert.Greater(server.Plan.MemoryGib, 0);
					Assert.AreEqual((double)server.Plan.MemoryMib / server.Plan.MemoryGib, 1024.0);
					Assert.IsTrue(mem <= server.Plan.MemoryGib);
					mem = (int)server.Plan.MemoryGib;
				}
				
				servers = api.Server.Limit(1).Find();
				Assert.AreEqual(servers.Count, 1);
			}
			
			
			/////////////////////////////////////////////////////////////////////////////////////////////////////////
			// should be CRUDed
			{
				string name = "!cs_nunit-" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "-" + (new Regex(@"-.+")).Replace(System.Guid.NewGuid().ToString(), "");
				string description = "This instance was created by saklient.cs NUnit";
				string tag = "saklient-test";
				int cpu = 1;
				int mem = 2;
				string hostName = "saklient-test";
				string sshPublicKey = "ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQC3sSg8Vfxrs3eFTx3G//wMRlgqmFGxh5Ia8DZSSf2YrkZGqKbL1t2AsiUtIMwxGiEVVBc0K89lORzra7qoHQj5v5Xlcdqodgcs9nwuSeS38XWO6tXNF4a8LvKnfGS55+uzmBmVUwAztr3TIJR5TTWxZXpcxSsSEHx7nIcr31zcvosjgdxqvSokAsIgJyPQyxCxsPK8SFIsUV+aATqBCWNyp+R1jECPkd74ipEBoccnA0pYZnRhIsKNWR9phBRXIVd5jx/gK5jHqouhFWvCucUs0gwilEGwpng3b/YxrinNskpfOpMhOD9zjNU58OCoMS8MA17yqoZv59l3u16CrnrD saklient-test@local";
				string sshPrivateKeyFile = root + "/test-sshkey.txt";
				Console.WriteLine(root);
				
				// search archives
				Console.WriteLine("searching archives...");
				List<Archive> archives = api.Archive
					.WithNameLike("CentOS 6.5 64bit")
					.WithSizeGib(20)
					.WithSharedScope()
					.Limit(1)
					.Find();
				Assert.Greater(archives.Count, 0);
				Archive archive = archives[0];
				
				// search scripts
				Console.WriteLine("searching scripts...");
				List<Script> scripts = api.Script
					.WithNameLike("WordPress")
					.WithSharedScope()
					.Limit(1)
					.Find();
				Assert.Greater(scripts.Count, 0);
				Script script = scripts[0];
				
				// create a disk
				Console.WriteLine("creating a disk...");
				Disk disk = api.Disk.Create();
				try {
					disk.Save();
				}
				catch (Saklient.Errors.SaklientException ex)
				{
				}
				disk.Name = name;
				disk.Description = description;
				disk.Tags = new List<string> { tag };
				disk.Plan = api.Product.Disk.Ssd;
				disk.Source = archive;
				disk.Save();
				
				// check an immutable field
				Console.WriteLine("updating the disk...");
				try {
					disk.SizeMib = 20480;
					disk.Save();
				}
				catch (Saklient.Errors.SaklientException ex)
				{
				}
				
				// create a server
				Console.WriteLine("creating a server...");
				Server server = api.Server.Create();
				server.Name = name;
				server.Description = description;
				server.Tags = new List<string> { tag };
				server.Plan = api.Product.Server.GetBySpec(cpu, mem);
				server.Save();
				
				// check the server properties
				Assert.Greater(Convert.ToInt64(server.Id), 0);
				Assert.AreEqual(server.Name, name);
				Assert.AreEqual(server.Description, description);
				Assert.AreEqual(server.Tags.Count, 1);
				Assert.AreEqual(server.Tags[0], tag);
				Assert.AreEqual(server.Plan.Cpu, cpu);
				Assert.AreEqual(server.Plan.MemoryGib, mem);
				
				// connect to shared segment
				Console.WriteLine("connecting the server to shared segment...");
				Iface iface = server.AddIface();
				Assert.Greater(Convert.ToInt64(iface.Id), 0);
				iface.ConnectToSharedSegment();
				
				// wait disk copy
			}
			
			
			
			
			
			
			
			
			
			
			
//			object query = new Hash {
//				{ "Filter", new Hash {
//					{ "Tags", new [] {
//						new [] { "distro-centos", "distro-ver-6.5" },
//						new [] { "distro-sl" }
//					}}
//				}}
//			};
//			object obj = client.Request("GET", "/archive", query);
//			ArrayList archives = (ArrayList)Util.GetByPath(obj, "Archives");
//			foreach (Hash archive in archives) {
//				Console.WriteLine((string)archive["Name"]);
//			}
		}
		
	}

}
