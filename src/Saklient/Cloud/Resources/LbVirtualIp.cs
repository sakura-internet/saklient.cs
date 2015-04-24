using Util = Saklient.Util;
using LbServer = Saklient.Cloud.Resources.LbServer;

namespace Saklient.Cloud.Resources
{

	/// <summary>ロードバランサの仮想IPアドレス設定。
	/// </summary>
	public class LbVirtualIp
	{
		
		internal string _VirtualIpAddress;
		
		public string Get_virtualIpAddress()
		{
			return this._VirtualIpAddress;
		}
		
		public string Set_virtualIpAddress(string v)
		{
			this._VirtualIpAddress = v;
			return this._VirtualIpAddress;
		}
		
		/// <summary>VIPアドレス
		/// </summary>
		public string VirtualIpAddress
		{
			get { return this.Get_virtualIpAddress(); }
			set { this.Set_virtualIpAddress(value); }
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
		
		internal long? _DelayLoop;
		
		public long? Get_delayLoop()
		{
			return this._DelayLoop;
		}
		
		public long? Set_delayLoop(long? v)
		{
			this._DelayLoop = v;
			return this._DelayLoop;
		}
		
		/// <summary>チェック間隔 [秒]
		/// </summary>
		public long? DelayLoop
		{
			get { return this.Get_delayLoop(); }
			set { this.Set_delayLoop(value); }
		}
		
		internal System.Collections.Generic.List<LbServer> _Servers;
		
		public System.Collections.Generic.List<LbServer> Get_servers()
		{
			return this._Servers;
		}
		
		/// <summary>実サーバ <see cref="Saklient.Cloud.Resources.LbServer" /> の配列
		/// </summary>
		public System.Collections.Generic.List<LbServer> Servers
		{
			get { return this.Get_servers(); }
		}
		
		public LbVirtualIp(object obj=null)
		{
			if (obj == null) {
				obj = new System.Collections.Generic.Dictionary<string, object> {};
			}
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
				this._Port = (long)System.Convert.ToInt64(""+port);
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
				this._DelayLoop = (long)System.Convert.ToInt64(""+delayLoop);
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
		
		/// <summary>監視対象サーバ設定を追加します。
		/// 
		/// <param name="settings">設定オブジェクト</param>
		/// </summary>
		public LbServer AddServer(object settings=null)
		{
			LbServer ret = new LbServer(settings);
			(this._Servers as System.Collections.IList).Add(ret);
			return ret;
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
		
		/// <summary>指定したIPアドレスにマッチする監視対象サーバ設定のうち、最初にマッチしたものを取得します。
		/// 
		/// <param name="address">検索するIPアドレス</param>
		/// <returns>監視対象サーバ設定（見つからなかった場合はnull）</returns>
		/// </summary>
		public LbServer GetServerByAddress(string address)
		{
			for (int __it1=0; __it1 < (this._Servers as System.Collections.IList).Count; __it1++) {
				var srv = this._Servers[__it1];
				if (srv.IpAddress == address) {
					return srv;
				}
			}
			return null;
		}
		
		/// <summary>指定したIPアドレスにマッチする監視対象サーバ設定をすべて削除します。
		/// 
		/// <param name="address" />
		/// </summary>
		public LbVirtualIp RemoveServerByAddress(string address)
		{
			System.Collections.Generic.List<LbServer> servers = new System.Collections.Generic.List<LbServer> {  };
			for (int __it1=0; __it1 < (this._Servers as System.Collections.IList).Count; __it1++) {
				var srv = this._Servers[__it1];
				if (srv.IpAddress != address) {
					(servers as System.Collections.IList).Add(srv);
				}
			}
			this._Servers = servers;
			return this;
		}
		
		public LbVirtualIp UpdateStatus(System.Collections.Generic.List<object> srvs)
		{
			for (int __it1=0; __it1 < (srvs as System.Collections.IList).Count; __it1++) {
				var srvDyn = srvs[__it1];
				string ip = ((string)((srvDyn as System.Collections.Generic.Dictionary<string, object>)["IPAddress"]));
				LbServer srv = this.GetServerByAddress(ip);
				if (srv == null) {
					continue;
				}
				srv.UpdateStatus(srvDyn);
			}
			return this;
		}
		
	}
	
}
