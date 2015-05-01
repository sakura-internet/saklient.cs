using NUnit.Framework;
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using Saklient;
using Saklient.Cloud;
using Saklient.Cloud.Resources;

namespace Saklient.Cloud.Tests
{
	
	[TestFixture]
	[Category("IsoImage")]
	public class IsoImageTest
	{
		
		[Test]
		public void Test()
		{
			string root = Path.GetDirectoryName(Environment.CurrentDirectory);
			string token = System.Environment.GetEnvironmentVariable("SACLOUD_TOKEN");
			string secret = System.Environment.GetEnvironmentVariable("SACLOUD_SECRET");
			string zone = System.Environment.GetEnvironmentVariable("SACLOUD_ZONE");
			API api = API.Authorize(token, secret, zone);
			
			string name = "!cs_nunit-" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "-" + (new Regex(@"-.+")).Replace(System.Guid.NewGuid().ToString(), "");
			string description = "This instance was created by saklient.cs NUnit";
			string tag = "saklient-test";
			
			// create/upload
			{
				IsoImage iso = api.IsoImage.Create();
				iso.Name = name;
				iso.Description = description;
				iso.Tags = new List<string> {tag};
				iso.SizeMib = 5120;
				iso.Save();
				
				//
				FtpInfo ftp = iso.FtpInfo;
				Assert.IsNotNull(ftp.HostName);
				Assert.IsNotNull(ftp.User);
				Assert.IsNotNull(ftp.Password);
				FtpInfo ftp2 = iso.OpenFtp(true).FtpInfo;
				Assert.IsNotNull(ftp2.HostName);
				Assert.IsNotNull(ftp2.User);
				Assert.IsNotNull(ftp2.Password);
				Assert.AreNotEqual(ftp.Password, ftp2.Password);
				
				//
				Console.WriteLine("FTPS: " + ftp2.User+":"+ftp2.Password + "@" + ftp2.HostName);
				ServicePointManager.ServerCertificateValidationCallback = (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
				Uri uri = new Uri("ftp://" + ftp2.HostName + "/image.iso");
				FtpWebRequest ftpReq = FtpWebRequest.Create(uri) as FtpWebRequest;
				ftpReq.EnableSsl = true;
				ftpReq.Credentials = new NetworkCredential(ftp2.User, ftp2.Password);
				ftpReq.Method = WebRequestMethods.Ftp.UploadFile;
//				ftpReq.KeepAlive = true;
//				ftpReq.UseBinary = true;
//				ftpReq.UsePassive = true;
//				ftpReq.ContentLength = 1024 * 256;
				Stream stream = ftpReq.GetRequestStream();
				Random rnd = new Random();
				byte[] buffer = new byte[1024];
				for (int i=0; i<256; i++) {
					rnd.NextBytes(buffer);
					stream.Write(buffer, 0, buffer.Length);
				}
				stream.Close();
				FtpWebResponse ftpRes = ftpReq.GetResponse() as FtpWebResponse;
				Console.WriteLine("{0}: {1}", ftpRes.StatusCode, ftpRes.StatusDescription);
				ftpRes.Close();
				
				iso.CloseFtp();
				
				//
				iso.Destroy();
			}
			
			
			
			/////////////////////////////////////////////////////////////////////////////////////////////////////////
			// insert/eject
			{
				// search iso images
				Console.WriteLine("searching iso images...");
				List<IsoImage> isos = api.IsoImage
					.WithNameLike("CentOS 6. 64bit")
					.WithSharedScope()
					.Limit(1)
					.Find();
				Assert.Greater(isos.Count, 0);
				IsoImage iso = isos[0];
				
				// create a server
				Console.WriteLine("creating a server...");
				Server server = api.Server.Create();
				server.Name = name;
				server.Description = description;
				server.Tags = new List<string> {tag};
				server.Plan = api.Product.Server.GetBySpec(1, 1);
				server.Save();
				
				// insert iso image while the server is down
				Console.WriteLine("inserting an ISO image to the server...");
				server.InsertIsoImage(iso);
				Assert.AreEqual(iso.Id, server.Instance.IsoImage.Id);
				
				// eject iso image while the server is down
				Console.WriteLine("ejecting the ISO image from the server...");
				server.EjectIsoImage();
				Assert.IsNull(server.Instance.IsoImage);
				
				// boot
				Console.WriteLine("booting the server...");
				server.Boot();
				Thread.Sleep(3);
				
				// insert iso image while the server is up
				Console.WriteLine("inserting an ISO image to the server...");
				server.InsertIsoImage(iso);
				Assert.AreEqual(iso.Id, server.Instance.IsoImage.Id);
				
				// eject iso image while the server is up
				Console.WriteLine("ejecting the ISO image from the server...");
				server.EjectIsoImage();
				Assert.IsNull(server.Instance.IsoImage);
				
				// stop
				Thread.Sleep(1);
				Console.WriteLine("stopping the server...");
				if (!server.Stop().SleepUntilDown()) Assert.Fail("サーバが正常に停止しません");
				
				// delete the server
				Console.WriteLine("deleting the server...");
				server.Destroy();
			}
		}
		
	}

}
