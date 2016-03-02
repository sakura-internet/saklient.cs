using Util = Saklient.Util;

namespace Saklient.Cloud.Resources
{

	/// <summary>GSLBの監視対象サーバ設定。
	/// </summary>
	public class GslbServer
	{
		
		internal bool? _Enabled;
		
		public bool? Get_enabled()
		{
			return this._Enabled;
		}
		
		public bool? Set_enabled(bool? v)
		{
			this._Enabled = v;
			return this._Enabled;
		}
		
		/// <summary>有効状態
		/// </summary>
		public bool? Enabled
		{
			get { return this.Get_enabled(); }
			set { this.Set_enabled(value); }
		}
		
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
		
		internal long? _Weight;
		
		public long? Get_weight()
		{
			return this._Weight;
		}
		
		public long? Set_weight(long? v)
		{
			this._Weight = v;
			return this._Weight;
		}
		
		/// <summary>重み値
		/// </summary>
		public long? Weight
		{
			get { return this.Get_weight(); }
			set { this.Set_weight(value); }
		}
		
		public GslbServer(object obj=null)
		{
			if (obj == null) {
				obj = new System.Collections.Generic.Dictionary<string, object> {};
			}
			object enabled = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> { "Enabled", "enabled" });
			this._Enabled = null;
			if (enabled != null) {
				string enabledStr = ((string)(enabled));
				this._Enabled = enabledStr.ToLower() == "true";
			}
			this._IpAddress = ((string)(Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> {
				"IPAddress",
				"ipAddress",
				"ip_address",
				"ip"
			})));
			object weight = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> { "Weight", "weight" });
			this._Weight = null;
			if (weight != null) {
				this._Weight = (long)System.Convert.ToInt64(""+weight);
			}
			if (this._Weight == 0) {
				this._Weight = null;
			}
		}
		
		public object ToRawSettings()
		{
			return new System.Collections.Generic.Dictionary<string, object> {
			{ "Enabled", this._Enabled == null ? null : (((bool)(this._Enabled)) ? "True" : "False") },
			{ "IPAddress", this._IpAddress },
			{ "Weight", this._Weight }
			};
		}
		
	}
	
}
