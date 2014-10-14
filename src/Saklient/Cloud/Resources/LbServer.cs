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
		
		/// <summary>IPアドレス
		/// </summary>
		public string IpAddress
		{
			get { return this.Get_ipAddress(); }
		}
		
		internal long? _Port;
		
		public long? Get_port()
		{
			return this._Port;
		}
		
		/// <summary>ポート番号
		/// </summary>
		public long? Port
		{
			get { return this.Get_port(); }
		}
		
		internal string _Protocol;
		
		public string Get_protocol()
		{
			return this._Protocol;
		}
		
		/// <summary>監視方法
		/// </summary>
		public string Protocol
		{
			get { return this.Get_protocol(); }
		}
		
		internal string _PathToCheck;
		
		public string Get_pathToCheck()
		{
			return this._PathToCheck;
		}
		
		/// <summary>パス
		/// </summary>
		public string PathToCheck
		{
			get { return this.Get_pathToCheck(); }
		}
		
		internal long? _ExpectedStatus;
		
		public long? Get_expectedStatus()
		{
			return this._ExpectedStatus;
		}
		
		/// <summary>レスポンスコード
		/// </summary>
		public long? ExpectedStatus
		{
			get { return this.Get_expectedStatus(); }
		}
		
		public LbServer(object obj)
		{
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
			this._PathToCheck = ((string)(Util.GetByPathAny(new System.Collections.Generic.List<object> { health, obj }, new System.Collections.Generic.List<string> { "Path", "path" })));
			object port = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> { "Port", "port" });
			this._Port = null;
			if (port != null) {
				this._Port = (long)System.Convert.ToInt64(((string)(port)));
			}
			if (this._Port == 0) {
				this._Port = null;
			}
			object status = Util.GetByPathAny(new System.Collections.Generic.List<object> { health, obj }, new System.Collections.Generic.List<string> { "Status", "status" });
			this._ExpectedStatus = null;
			if (status != null) {
				this._ExpectedStatus = (long)System.Convert.ToInt64(((string)(status)));
			}
			if (this._ExpectedStatus == 0) {
				this._ExpectedStatus = null;
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
			{ "Status", this._ExpectedStatus }
			} }
			};
		}
		
	}
	
}
