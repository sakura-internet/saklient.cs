using Util = Saklient.Util;

namespace Saklient.Cloud.Resources
{

	/// <summary>ロードバランサの監視対象サーバ。
	/// </summary>
	public class LbServer
	{
		
		internal string _IpAddress;
		
		public string Get_ipAddress()
		{
			return this._IpAddress;
		}
		
		public string Set_ipAddress(string v)
		{
			this._IpAddress = v;
			return this._IpAddress;
		}
		
		/// <summary>IPアドレス
		/// </summary>
		public string IpAddress
		{
			get { return this.Get_ipAddress(); }
			set { this.Set_ipAddress(value); }
		}
		
		internal long? _Port;
		
		public long? Get_port()
		{
			return this._Port;
		}
		
		public long? Set_port(long? v)
		{
			this._Port = v;
			return this._Port;
		}
		
		/// <summary>ポート番号
		/// </summary>
		public long? Port
		{
			get { return this.Get_port(); }
			set { this.Set_port(value); }
		}
		
		internal string _Protocol;
		
		public string Get_protocol()
		{
			return this._Protocol;
		}
		
		public string Set_protocol(string v)
		{
			this._Protocol = v;
			return this._Protocol;
		}
		
		/// <summary>監視方法
		/// </summary>
		public string Protocol
		{
			get { return this.Get_protocol(); }
			set { this.Set_protocol(value); }
		}
		
		internal string _PathToCheck;
		
		public string Get_pathToCheck()
		{
			return this._PathToCheck;
		}
		
		public string Set_pathToCheck(string v)
		{
			this._PathToCheck = v;
			return this._PathToCheck;
		}
		
		/// <summary>監視対象パス
		/// </summary>
		public string PathToCheck
		{
			get { return this.Get_pathToCheck(); }
			set { this.Set_pathToCheck(value); }
		}
		
		internal long? _ResponseExpected;
		
		public long? Get_responseExpected()
		{
			return this._ResponseExpected;
		}
		
		public long? Set_responseExpected(long? v)
		{
			this._ResponseExpected = v;
			return this._ResponseExpected;
		}
		
		/// <summary>監視時に期待されるレスポンスコード
		/// </summary>
		public long? ResponseExpected
		{
			get { return this.Get_responseExpected(); }
			set { this.Set_responseExpected(value); }
		}
		
		internal long _ActiveConnections;
		
		public long Get_activeConnections()
		{
			return this._ActiveConnections;
		}
		
		/// <summary>レスポンスコード
		/// </summary>
		public long ActiveConnections
		{
			get { return this.Get_activeConnections(); }
		}
		
		internal string _Status;
		
		public string Get_status()
		{
			return this._Status;
		}
		
		/// <summary>レスポンスコード
		/// </summary>
		public string Status
		{
			get { return this.Get_status(); }
		}
		
		public LbServer(object obj=null)
		{
			if (obj == null) {
				obj = new System.Collections.Generic.Dictionary<string, object> {};
			}
			object health = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> {
				"HealthCheck",
				"healthCheck",
				"health_check",
				"health"
			});
			this._IpAddress = ((string)(Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> {
				"IPAddress",
				"ipAddress",
				"ip_address",
				"ip"
			})));
			this._Protocol = ((string)(Util.GetByPathAny(new System.Collections.Generic.List<object> { health, obj }, new System.Collections.Generic.List<string> { "Protocol", "protocol" })));
			this._PathToCheck = ((string)(Util.GetByPathAny(new System.Collections.Generic.List<object> { health, obj }, new System.Collections.Generic.List<string> {
				"Path",
				"path",
				"pathToCheck",
				"path_to_check"
			})));
			object port = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> { "Port", "port" });
			this._Port = null;
			if (port != null) {
				this._Port = (long)System.Convert.ToInt64(""+port);
			}
			if (this._Port == 0) {
				this._Port = null;
			}
			object responseExpected = Util.GetByPathAny(new System.Collections.Generic.List<object> { health, obj }, new System.Collections.Generic.List<string> {
				"Status",
				"status",
				"responseExpected",
				"response_expected"
			});
			this._ResponseExpected = null;
			if (responseExpected != null) {
				this._ResponseExpected = (long)System.Convert.ToInt64(""+responseExpected);
			}
			if (this._ResponseExpected == 0) {
				this._ResponseExpected = null;
			}
		}
		
		public object ToRawSettings()
		{
			return new System.Collections.Generic.Dictionary<string, object> {
			{ "IPAddress", this._IpAddress },
			{ "Port", this._Port },
			{ "HealthCheck", new System.Collections.Generic.Dictionary<string, object> {
			{ "Protocol", this._Protocol },
			{ "Path", this._PathToCheck },
			{ "Status", this._ResponseExpected }
			} }
			};
		}
		
		/// <summary>
		/// <param name="obj" />
		/// </summary>
		public LbServer UpdateStatus(object obj)
		{
			string connStr = ((string)((obj as System.Collections.Generic.Dictionary<string, object>)["ActiveConn"]));
			this._ActiveConnections = 0;
			if (connStr != null) {
				this._ActiveConnections = (long)System.Convert.ToInt64(""+connStr);
			}
			string status = ((string)((obj as System.Collections.Generic.Dictionary<string, object>)["Status"]));
			this._Status = status == null ? null : status.ToLower();
			return this;
		}
		
	}
	
}
