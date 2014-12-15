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
	[Category("License")]
	public class LicenseTest
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
			
			Console.WriteLine("ライセンス種別情報を検索しています...");
			List<LicenseInfo> infos = api.Product.License.Find();
			
			Console.WriteLine("ライセンスを作成しています...");
			License license = api.License.Create();
			license.Name = name;
			license.Info = infos[0];
			license.Save();
			
			Console.WriteLine("ライセンスを削除しています...");
			license.Destroy();
			
		}
		
	}

}
