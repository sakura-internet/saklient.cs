using System;
using System.IO;
using System.Net;
using System.Text;
using Client = Saklient.Cloud.Client;

namespace Saklient.Cloud {
	
	public class Client {
		
		private string token;
		private string secret;
		private string apiRoot;
		private string apiRootSuffix;
		private string authorization;
		
		public Client(string token, string secret)
		{
			this.apiRoot = "https://secure.sakura.ad.jp/cloud/";
			this.apiRootSuffix = null;
			this.SetAccessKey(token, secret);
		}
		
		public Client CloneInstance()
		{
			Client ret = new Client(this.token, this.secret);
			ret.SetApiRoot(this.apiRoot);
			ret.SetApiRootSuffix(this.apiRootSuffix);
			return ret;
		}
		
		public void SetApiRoot(string url)
		{
			this.apiRoot = url;
		}
		
		public void SetApiRootSuffix(string suffix)
		{
			this.apiRootSuffix = suffix;
		}
		
		public void SetAccessKey(string token, string secret)
		{
			this.token = token;
			this.secret = secret;
			
			this.authorization = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(token+":"+secret));
		}
		
		public object Request(string method, string path, object parameters=null)
		{
			method = method.ToUpper();
			string json = parameters==null ? null : Util.EncodeJson(parameters);
			WebRequest req = WebRequest.Create(path);
			req.Method = method;
			if (method != "GET") {
				req.ContentType = "application/json";
				req.ContentLength = json.Length;
				Stream stream = req.GetRequestStream();
				StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding("UTF-8"));
				writer.Write(json, 0, json.Length);
				writer.Flush();
				writer.Dispose();
				stream.Close();
			}
			
			System.Net.WebResponse response = req.GetResponse();
			StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
			string dataSrc = reader.ReadToEnd();
			reader.Close();
			object data = Util.DecodeJson(dataSrc);
			return data;
			
		}
		
	}
	
}
