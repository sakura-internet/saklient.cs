using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using CommonServiceItem = Saklient.Cloud.Resources.CommonServiceItem;
using GslbServer = Saklient.Cloud.Resources.GslbServer;

namespace Saklient.Cloud.Resources
{

	/// <summary>GSLBの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Gslb : CommonServiceItem
	{
		
		internal System.Collections.Generic.List<GslbServer> _Servers;
		
		public System.Collections.Generic.List<GslbServer> Get_servers()
		{
			return this._Servers;
		}
		
		/// <summary>仮想IPアドレス <see cref="Saklient.Cloud.Resources.GslbServer" /> の配列
		/// </summary>
		public System.Collections.Generic.List<GslbServer> Servers
		{
			get { return this.Get_servers(); }
		}
		
		public string Get_protocol()
		{
			string raw = ((string)(Util.GetByPath(this.RawSettings, "GSLB.HealthCheck.Protocol")));
			if (raw == null) {
				throw new SaklientException("invalid_data", "Data of the resource is invalid");
			}
			return raw;
		}
		
		public string Set_protocol(string v)
		{
			this._Normalize();
			Util.SetByPath(this.RawSettings, "GSLB.HealthCheck.Protocol", v);
			return v;
		}
		
		/// <summary>監視方法
		/// </summary>
		public string Protocol
		{
			get { return this.Get_protocol(); }
			set { this.Set_protocol(value); }
		}
		
		public string Get_pathToCheck()
		{
			if (!Util.ExistsPath(this.RawSettings, "GSLB.HealthCheck.Path")) {
				return null;
			}
			string raw = ((string)(Util.GetByPath(this.RawSettings, "GSLB.HealthCheck.Path")));
			return raw;
		}
		
		public string Set_pathToCheck(string v)
		{
			this._Normalize();
			Util.SetByPath(this.RawSettings, "GSLB.HealthCheck.Path", v);
			return v;
		}
		
		/// <summary>監視対象パス
		/// </summary>
		public string PathToCheck
		{
			get { return this.Get_pathToCheck(); }
			set { this.Set_pathToCheck(value); }
		}
		
		public long Get_responseExpected()
		{
			object raw = Util.GetByPath(this.RawSettings, "GSLB.HealthCheck.Status");
			if (raw == null) {
				throw new SaklientException("invalid_data", "Data of the resource is invalid");
			}
			return (long)System.Convert.ToInt64(""+raw.ToString());
		}
		
		public long Set_responseExpected(long v)
		{
			this._Normalize();
			Util.SetByPath(this.RawSettings, "GSLB.HealthCheck.Status", v);
			return v;
		}
		
		/// <summary>監視時に期待されるレスポンスコード
		/// </summary>
		public long ResponseExpected
		{
			get { return this.Get_responseExpected(); }
			set { this.Set_responseExpected(value); }
		}
		
		public long Get_delayLoop()
		{
			string delayLoop = Util.GetByPath(this.RawSettings, "GSLB.DelayLoop").ToString();
			if (delayLoop == null) {
				throw new SaklientException("invalid_data", "Data of the resource is invalid");
			}
			return (long)System.Convert.ToInt64(""+delayLoop);
		}
		
		public long Set_delayLoop(long v)
		{
			this._Normalize();
			Util.SetByPath(this.RawSettings, "GSLB.DelayLoop", v);
			return v;
		}
		
		/// <summary>チェック間隔(秒)
		/// </summary>
		public long DelayLoop
		{
			get { return this.Get_delayLoop(); }
			set { this.Set_delayLoop(value); }
		}
		
		public bool Get_weighted()
		{
			string weighted = Util.GetByPath(this.RawSettings, "GSLB.Weighted").ToString();
			if (weighted == null) {
				throw new SaklientException("invalid_data", "Data of the resource is invalid");
			}
			return weighted.ToLower() == "true";
		}
		
		public bool Set_weighted(bool v)
		{
			this._Normalize();
			Util.SetByPath(this.RawSettings, "GSLB.Weighted", v ? "True" : "False");
			return v;
		}
		
		/// <summary>重み付け応答
		/// </summary>
		public bool Weighted
		{
			get { return this.Get_weighted(); }
			set { this.Set_weighted(value); }
		}
		
		public Gslb(Client client, object obj, bool wrapped=false) : base(client, obj, wrapped)
		{
			/*!base!*/;
			this._Normalize();
		}
		
		private void _Normalize()
		{
			if (this._Servers == null) {
				this._Servers = new System.Collections.Generic.List<GslbServer> {  };
			}
			if (this.RawSettings == null) {
				this.RawSettings = new System.Collections.Generic.Dictionary<string, object> {};
			}
			if (!Util.ExistsPath(this.RawSettings, "GSLB")) {
				Util.SetByPath(this.RawSettings, "GSLB", new System.Collections.Generic.Dictionary<string, object> {});
			}
			if (!Util.ExistsPath(this.RawSettings, "GSLB.HealthCheck")) {
				Util.SetByPath(this.RawSettings, "GSLB.HealthCheck", new System.Collections.Generic.Dictionary<string, object> {});
			}
			if (!Util.ExistsPath(this.RawSettings, "GSLB.Servers")) {
				Util.SetByPath(this.RawSettings, "GSLB.Servers", new System.Collections.Generic.List<object> {  });
			}
		}
		
		internal override void _OnAfterApiDeserialize(object r, object root)
		{
			this._Normalize();
			this._Servers = new System.Collections.Generic.List<GslbServer> {  };
			object settings = this.RawSettings;
			if (settings != null) {
				object raw = Util.GetByPath(settings, "GSLB.Servers");
				if (raw != null) {
					System.Collections.Generic.List<object> servers = ((System.Collections.Generic.List<object>)(raw));
					for (int __it1=0; __it1 < (servers as System.Collections.IList).Count; __it1++) {
						var server = servers[__it1];
						(this._Servers as System.Collections.IList).Add(new GslbServer(server));
					}
				}
			}
		}
		
		internal override void _OnBeforeApiSerialize(bool withClean)
		{
			this._Normalize();
			System.Collections.Generic.List<object> servers = new System.Collections.Generic.List<object> {  };
			for (int __it1=0; __it1 < (this._Servers as System.Collections.IList).Count; __it1++) {
				var server = this._Servers[__it1];
				(servers as System.Collections.IList).Add(server.ToRawSettings());
			}
			Util.SetByPath(this.RawSettings, "GSLB.Servers", servers);
		}
		
		internal override void _OnAfterApiSerialize(object r, bool withClean)
		{
			if (r == null) {
				return;
			}
			Util.SetByPath(r, "Provider", new System.Collections.Generic.Dictionary<string, object> {});
			Util.SetByPath(r, "Provider.Class", "gslb");
		}
		
		/// <summary>
		/// 
		/// <param name="protocol" />
		/// <param name="delayLoop" />
		/// <param name="weighted" />
		/// </summary>
		public Gslb SetInitialParams(string protocol, long delayLoop=10, bool weighted=true)
		{
			object settings = this.RawSettings;
			this.Protocol = protocol;
			this.DelayLoop = delayLoop;
			this.Weighted = weighted;
			return this;
		}
		
		/// <summary>監視対象サーバ設定を追加します。
		/// 
		/// <param name="settings">設定オブジェクト</param>
		/// </summary>
		public GslbServer AddServer(object settings=null)
		{
			GslbServer ret = new GslbServer(settings);
			(this._Servers as System.Collections.IList).Add(ret);
			return ret;
		}
		
	}
	
}
