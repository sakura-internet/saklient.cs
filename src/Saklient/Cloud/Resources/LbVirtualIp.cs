using Util = Saklient.Util;
using LbServer = Saklient.Cloud.Resources.LbServer;

namespace Saklient.Cloud.Resources
{

	/// <summary>ロードバランサの仮想IPアドレス。
	/// </summary>
	public class LbVirtualIp
	{
		
		internal string _VirtualIpAddress;
		
		public string Get_virtualIpAddress()
		{
			return this._VirtualIpAddress;
		}
		
		/// <summary>VIPアドレス
		/// </summary>
		public string VirtualIpAddress
		{
			get { return this.Get_virtualIpAddress(); }
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
		
		internal long? _DelayLoop;
		
		public long? Get_delayLoop()
		{
			return this._DelayLoop;
		}
		
		/// <summary>チェック間隔 [秒]
		/// </summary>
		public long? DelayLoop
		{
			get { return this.Get_delayLoop(); }
		}
		
		internal System.Collections.Generic.List<LbServer> _Servers;
		
		public System.Collections.Generic.List<LbServer> Get_servers()
		{
			return this._Servers;
		}
		
		/// <summary>実サーバ
		/// </summary>
		public System.Collections.Generic.List<LbServer> Servers
		{
			get { return this.Get_servers(); }
		}
		
		public LbVirtualIp(object obj)
		{
			object vip = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> {
				"VirtualIPAddress",
				"virtualIpAddress",
				"virtual_ip_address",
				"vip"
			});
			this._VirtualIpAddress = ((string)(vip));
			object port = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> { "Port", "port" });
			this._Port = null;
			if (port != null) {
				this._Port = (long)System.Convert.ToInt64(((string)(port)));
			}
			if (this._Port == 0) {
				this._Port = null;
			}
			object delayLoop = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> {
				"DelayLoop",
				"delayLoop",
				"delay_loop",
				"delay"
			});
			this._DelayLoop = null;
			if (delayLoop != null) {
				this._DelayLoop = (long)System.Convert.ToInt64(((string)(delayLoop)));
			}
			if (this._DelayLoop == 0) {
				this._DelayLoop = null;
			}
			this._Servers = new System.Collections.Generic.List<LbServer> {  };
			object serversDyn = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> { "Servers", "servers" });
			if (serversDyn != null) {
				System.Collections.Generic.List<object> servers = ((System.Collections.Generic.List<object>)(serversDyn));
				for (int __it1=0; __it1 < (servers as System.Collections.IList).Count; __it1++) {
					var server = servers[__it1];
					(this._Servers as System.Collections.IList).Add(new LbServer(server));
				}
			}
		}
		
		/// <summary>
		/// <param name="settings" />
		/// </summary>
		public LbVirtualIp AddServer(object settings)
		{
			(this._Servers as System.Collections.IList).Add(new LbServer(settings));
			return this;
		}
		
		public object ToRawSettings()
		{
			System.Collections.Generic.List<object> servers = new System.Collections.Generic.List<object> {  };
			for (int __it1=0; __it1 < (this._Servers as System.Collections.IList).Count; __it1++) {
				var server = this._Servers[__it1];
				(servers as System.Collections.IList).Add(server.ToRawSettings());
			}
			return new System.Collections.Generic.Dictionary<string, object> {
				{ "VirtualIPAddress", this._VirtualIpAddress },
				{ "Port", this._Port },
				{ "DelayLoop", this._DelayLoop },
				{ "Servers", servers }
			};
		}
		
	}
	
}
