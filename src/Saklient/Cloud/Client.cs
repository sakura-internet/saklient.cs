using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Client = Saklient.Cloud.Client;

namespace Saklient.Cloud {
	
	public class Client {
		
		private string token;
		private string secret;
		private string apiRoot;
		private string apiRootSuffix;
		private string authorization;
		public object additionalParams;
		
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
			path = (new Regex(@"/$")).Replace(path, "");
			string json = null;
			if (parameters != null) json = Util.EncodeJson(parameters);
			if (path.Substring(0,4) != "http") {
				string urlRoot = this.apiRoot;
				if (this.apiRootSuffix != null) {
					urlRoot += this.apiRootSuffix;
					urlRoot = (new Regex(@"/?$")).Replace(urlRoot, "/");
				}
				path = urlRoot + "api/cloud/1.1" + path;
			}
			if (method == "GET" && json != null) {
				path += "?" + Util.UrlEncode(json);
				json = null;
			}
			//
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(path);
			req.Method = method != "GET" ? "POST" : "GET";
			req.ContentType = json != null ? "application/json" : "application/x-www-form-urlencoded";
			req.UserAgent = "saklient.cs ver-0.0.6 rev-705e6fc541c30cec41e72e5e531418d64f196863";
			req.Headers.Add(HttpRequestHeader.Authorization, this.authorization);
			req.Headers.Add("X-Requested-With", "XMLHttpRequest");
			req.Headers.Add("X-Sakura-No-Authenticate-Header", "1");
			req.Headers.Add("X-Sakura-HTTP-Method", method);
			req.Headers.Add("X-Sakura-Request-Format", "json");
			req.Headers.Add("X-Sakura-Response-Format", "json");
			req.Headers.Add("X-Sakura-Error-Level", "warning");
			if (json != null) {
				StreamWriter writer = new StreamWriter(req.GetRequestStream());
				writer.Write(json);
				writer.Flush();
				writer.Close();
			}
			
			object data = null;
			try {
				using (WebResponse response = req.GetResponse() as HttpWebResponse) {
					if (req.HaveResponse && response != null) {
						using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("UTF-8"))) {
							string dataSrc = reader.ReadToEnd();
							reader.Close();
							data = Util.DecodeJson(dataSrc);
						}
					}
				}
			}
			catch (WebException ex)
			{
				long code = 0;
				if (ex.Response != null) {
					using (HttpWebResponse response = ex.Response as HttpWebResponse) {
						code = (long)response.StatusCode;
						using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("UTF-8"))) {
							string dataSrc = reader.ReadToEnd();
							reader.Close();
							data = Util.DecodeJson(dataSrc);
						}
					}
				}
				if (!(200<=code && code<300)) {
					var uex = Saklient.Errors.ExceptionFactory.Create(
						code,
						data!=null ? Util.GetByPath(data, "error_code") as string : null,
						data!=null ? Util.GetByPath(data, "error_msg") as string : null
					);
					throw uex;
				}
			}
			return data;
			
		}
		
	}
	
}
