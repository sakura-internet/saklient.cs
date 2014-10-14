using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using Router = Saklient.Cloud.Resources.Router;
using Ipv4Net = Saklient.Cloud.Resources.Ipv4Net;
using Ipv6Net = Saklient.Cloud.Resources.Ipv6Net;

namespace Saklient.Cloud.Resources
{

	/// <summary>スイッチの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Swytch : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		/// <summary>説明
		/// </summary>
		internal string M_description;
		
		/// <summary>ユーザ設定IPv4ネットワークのゲートウェイ
		/// </summary>
		internal string M_userDefaultRoute;
		
		/// <summary>ユーザ設定IPv4ネットワークのマスク長
		/// </summary>
		internal long? M_userMaskLen;
		
		/// <summary>接続されているルータ
		/// </summary>
		internal Router M_router;
		
		/// <summary>IPv4ネットワーク（ルータによる自動割当）
		/// </summary>
		internal System.Collections.Generic.List<Ipv4Net> M_ipv4Nets;
		
		/// <summary>IPv6ネットワーク（ルータによる自動割当）
		/// </summary>
		internal System.Collections.Generic.List<Ipv6Net> M_ipv6Nets;
		
		internal override string _ApiPath()
		{
			return "/switch";
		}
		
		internal override string _RootKey()
		{
			return "Switch";
		}
		
		internal override string _RootKeyM()
		{
			return "Switches";
		}
		
		public override string _ClassName()
		{
			return "Swytch";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Swytch Save()
		{
			return ((Swytch)(this._Save()));
		}
		
		/// <summary>最新のリソース情報を再取得します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Swytch Reload()
		{
			return ((Swytch)(this._Reload()));
		}
		
		public Swytch(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		/// <summary>このルータ＋スイッチでIPv6アドレスを有効にします。
		/// 
		/// <returns>有効化されたIPv6ネットワーク</returns>
		/// </summary>
		public Ipv6Net AddIpv6Net()
		{
			Ipv6Net ret = this.Get_router().AddIpv6Net();
			this.Reload();
			return ret;
		}
		
		/// <summary>このルータ＋スイッチでIPv6アドレスを無効にします。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Swytch RemoveIpv6Net()
		{
			System.Collections.Generic.List<Ipv6Net> nets = this.Get_ipv6Nets();
			this.Get_router().RemoveIpv6Net(nets[System.Convert.ToInt32(0)]);
			this.Reload();
			return this;
		}
		
		/// <summary>このルータ＋スイッチにスタティックルートを追加します。
		/// 
		/// <param name="maskLen" />
		/// <param name="nextHop" />
		/// <returns>追加されたIPv4ネットワーク</returns>
		/// </summary>
		public Ipv4Net AddStaticRoute(long maskLen, string nextHop)
		{
			Ipv4Net ret = this.Get_router().AddStaticRoute(maskLen, nextHop);
			this.Reload();
			return ret;
		}
		
		/// <summary>このルータ＋スイッチからスタティックルートを削除します。
		/// 
		/// <param name="ipv4Net" />
		/// <returns>this</returns>
		/// </summary>
		public Swytch RemoveStaticRoute(Ipv4Net ipv4Net)
		{
			this.Get_router().RemoveStaticRoute(ipv4Net);
			this.Reload();
			return this;
		}
		
		/// <summary>このルータ＋スイッチの帯域プランを変更します。
		/// 
		/// <param name="bandWidthMbps" />
		/// <returns>this</returns>
		/// </summary>
		public Swytch ChangePlan(long bandWidthMbps)
		{
			this.Get_router().ChangePlan(bandWidthMbps);
			this.Reload();
			return this;
		}
		
		private bool N_id = false;
		
		private string Get_id()
		{
			return this.M_id;
		}
		
		/// <summary>ID
		/// </summary>
		public string Id
		{
			get { return this.Get_id(); }
		}
		
		private bool N_name = false;
		
		private string Get_name()
		{
			return this.M_name;
		}
		
		private string Set_name(string v)
		{
			this.M_name = v;
			this.N_name = true;
			return this.M_name;
		}
		
		/// <summary>名前
		/// </summary>
		public string Name
		{
			get { return this.Get_name(); }
			set { this.Set_name(value); }
		}
		
		private bool N_description = false;
		
		private string Get_description()
		{
			return this.M_description;
		}
		
		private string Set_description(string v)
		{
			this.M_description = v;
			this.N_description = true;
			return this.M_description;
		}
		
		/// <summary>説明
		/// </summary>
		public string Description
		{
			get { return this.Get_description(); }
			set { this.Set_description(value); }
		}
		
		private bool N_userDefaultRoute = false;
		
		private string Get_userDefaultRoute()
		{
			return this.M_userDefaultRoute;
		}
		
		/// <summary>ユーザ設定IPv4ネットワークのゲートウェイ
		/// </summary>
		public string UserDefaultRoute
		{
			get { return this.Get_userDefaultRoute(); }
		}
		
		private bool N_userMaskLen = false;
		
		private long? Get_userMaskLen()
		{
			return this.M_userMaskLen;
		}
		
		/// <summary>ユーザ設定IPv4ネットワークのマスク長
		/// </summary>
		public long? UserMaskLen
		{
			get { return this.Get_userMaskLen(); }
		}
		
		private bool N_router = false;
		
		private Router Get_router()
		{
			return this.M_router;
		}
		
		/// <summary>接続されているルータ
		/// </summary>
		public Router Router
		{
			get { return this.Get_router(); }
		}
		
		private bool N_ipv4Nets = false;
		
		private System.Collections.Generic.List<Ipv4Net> Get_ipv4Nets()
		{
			return this.M_ipv4Nets;
		}
		
		/// <summary>IPv4ネットワーク（ルータによる自動割当）
		/// </summary>
		public System.Collections.Generic.List<Ipv4Net> Ipv4Nets
		{
			get { return this.Get_ipv4Nets(); }
		}
		
		private bool N_ipv6Nets = false;
		
		private System.Collections.Generic.List<Ipv6Net> Get_ipv6Nets()
		{
			return this.M_ipv6Nets;
		}
		
		/// <summary>IPv6ネットワーク（ルータによる自動割当）
		/// </summary>
		public System.Collections.Generic.List<Ipv6Net> Ipv6Nets
		{
			get { return this.Get_ipv6Nets(); }
		}
		
		/// <summary>(This method is generated in Translator_default#buildImpl)
		/// 
		/// <param name="r" />
		/// </summary>
		internal override void ApiDeserializeImpl(object r)
		{
			this.IsNew = r == null;
			if (this.IsNew) {
				r = new System.Collections.Generic.Dictionary<string, object> {  };
			}
			this.IsIncomplete = false;
			if (Util.ExistsPath(r, "ID")) {
				this.M_id = Util.GetByPath(r, "ID") == null ? ((string)(null)) : "" + Util.GetByPath(r, "ID");
			}
			else {
				this.M_id = null;
				this.IsIncomplete = true;
			}
			this.N_id = false;
			if (Util.ExistsPath(r, "Name")) {
				this.M_name = Util.GetByPath(r, "Name") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Name");
			}
			else {
				this.M_name = null;
				this.IsIncomplete = true;
			}
			this.N_name = false;
			if (Util.ExistsPath(r, "Description")) {
				this.M_description = Util.GetByPath(r, "Description") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Description");
			}
			else {
				this.M_description = null;
				this.IsIncomplete = true;
			}
			this.N_description = false;
			if (Util.ExistsPath(r, "UserSubnet.DefaultRoute")) {
				this.M_userDefaultRoute = Util.GetByPath(r, "UserSubnet.DefaultRoute") == null ? ((string)(null)) : "" + Util.GetByPath(r, "UserSubnet.DefaultRoute");
			}
			else {
				this.M_userDefaultRoute = null;
				this.IsIncomplete = true;
			}
			this.N_userDefaultRoute = false;
			if (Util.ExistsPath(r, "UserSubnet.NetworkMaskLen")) {
				this.M_userMaskLen = Util.GetByPath(r, "UserSubnet.NetworkMaskLen") == null ? System.Convert.ToInt64(null) : (long)System.Convert.ToInt64("" + Util.GetByPath(r, "UserSubnet.NetworkMaskLen"));
			}
			else {
				this.M_userMaskLen = null;
				this.IsIncomplete = true;
			}
			this.N_userMaskLen = false;
			if (Util.ExistsPath(r, "Internet")) {
				this.M_router = Util.GetByPath(r, "Internet") == null ? null : new Router(this._Client, Util.GetByPath(r, "Internet"));
			}
			else {
				this.M_router = null;
				this.IsIncomplete = true;
			}
			this.N_router = false;
			if (Util.ExistsPath(r, "Subnets")) {
				if (Util.GetByPath(r, "Subnets") == null) {
					this.M_ipv4Nets = new System.Collections.Generic.List<Ipv4Net> {  };
				}
				else {
					this.M_ipv4Nets = new System.Collections.Generic.List<Ipv4Net> {  };
					for (int __it1=0; __it1 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Subnets"))) as System.Collections.IList).Count; __it1++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Subnets")))[__it1];
						Ipv4Net v1 = null;
						v1 = t == null ? null : new Ipv4Net(this._Client, t);
						(this.M_ipv4Nets as System.Collections.IList).Add(v1);
					}
				}
			}
			else {
				this.M_ipv4Nets = null;
				this.IsIncomplete = true;
			}
			this.N_ipv4Nets = false;
			if (Util.ExistsPath(r, "IPv6Nets")) {
				if (Util.GetByPath(r, "IPv6Nets") == null) {
					this.M_ipv6Nets = new System.Collections.Generic.List<Ipv6Net> {  };
				}
				else {
					this.M_ipv6Nets = new System.Collections.Generic.List<Ipv6Net> {  };
					for (int __it2=0; __it2 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "IPv6Nets"))) as System.Collections.IList).Count; __it2++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "IPv6Nets")))[__it2];
						Ipv6Net v2 = null;
						v2 = t == null ? null : new Ipv6Net(this._Client, t);
						(this.M_ipv6Nets as System.Collections.IList).Add(v2);
					}
				}
			}
			else {
				this.M_ipv6Nets = null;
				this.IsIncomplete = true;
			}
			this.N_ipv6Nets = false;
		}
		
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			System.Collections.Generic.List<string> missing = new System.Collections.Generic.List<string> {  };
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_name) {
				Util.SetByPath(ret, "Name", this.M_name);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("name");
				}
			}
			if (withClean || this.N_description) {
				Util.SetByPath(ret, "Description", this.M_description);
			}
			if (withClean || this.N_userDefaultRoute) {
				Util.SetByPath(ret, "UserSubnet.DefaultRoute", this.M_userDefaultRoute);
			}
			if (withClean || this.N_userMaskLen) {
				Util.SetByPath(ret, "UserSubnet.NetworkMaskLen", this.M_userMaskLen);
			}
			if (withClean || this.N_router) {
				Util.SetByPath(ret, "Internet", withClean ? (this.M_router == null ? ((Router)(null)) : this.M_router.ApiSerialize(withClean)) : (this.M_router == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_router.ApiSerializeID()));
			}
			if (withClean || this.N_ipv4Nets) {
				Util.SetByPath(ret, "Subnets", new System.Collections.Generic.List<object> {  });
				for (int __it1=0; __it1 < (this.M_ipv4Nets as System.Collections.IList).Count; __it1++) {
					var r1 = this.M_ipv4Nets[__it1];
					object v = null;
					v = withClean ? (r1 == null ? ((Ipv4Net)(null)) : r1.ApiSerialize(withClean)) : (r1 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r1.ApiSerializeID());
					((ret as System.Collections.Generic.Dictionary<string, object>)["Subnets"] as System.Collections.IList).Add(v);
				}
			}
			if (withClean || this.N_ipv6Nets) {
				Util.SetByPath(ret, "IPv6Nets", new System.Collections.Generic.List<object> {  });
				for (int __it2=0; __it2 < (this.M_ipv6Nets as System.Collections.IList).Count; __it2++) {
					var r2 = this.M_ipv6Nets[__it2];
					object v = null;
					v = withClean ? (r2 == null ? ((Ipv6Net)(null)) : r2.ApiSerialize(withClean)) : (r2 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r2.ApiSerializeID());
					((ret as System.Collections.Generic.Dictionary<string, object>)["IPv6Nets"] as System.Collections.IList).Add(v);
				}
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Swytch creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
