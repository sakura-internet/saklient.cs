using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using Router = Saklient.Cloud.Resources.Router;
using Ipv4Net = Saklient.Cloud.Resources.Ipv4Net;
using Ipv6Net = Saklient.Cloud.Resources.Ipv6Net;
using Bridge = Saklient.Cloud.Resources.Bridge;

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
		
		/// <summary>タグ文字列の配列
		/// </summary>
		internal System.Collections.Generic.List<string> M_tags;
		
		/// <summary>アイコン
		/// </summary>
		internal Icon M_icon;
		
		/// <summary>ユーザ設定IPv4ネットワークのゲートウェイ
		/// </summary>
		internal string M_userDefaultRoute;
		
		/// <summary>ユーザ設定IPv4ネットワークのマスク長
		/// </summary>
		internal long? M_userMaskLen;
		
		/// <summary>接続されているルータ
		/// </summary>
		internal Router M_router;
		
		/// <summary>接続されているブリッジ
		/// </summary>
		internal Bridge M_bridge;
		
		/// <summary>IPv4ネットワーク（ルータによる自動割当） <see cref="Saklient.Cloud.Resources.Ipv4Net" /> の配列
		/// </summary>
		internal System.Collections.Generic.List<Ipv4Net> M_ipv4Nets;
		
		/// <summary>IPv6ネットワーク（ルータによる自動割当） <see cref="Saklient.Cloud.Resources.Ipv6Net" /> の配列
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
        /// </summary>
        /// <returns>this</returns>
        public Swytch Save()
		{
			return ((Swytch)(this._Save()));
		}

        /// <summary>最新のリソース情報を再取得します。
        /// </summary>
        /// <returns>this</returns>
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
        /// </summary>
        /// <returns>有効化されたIPv6ネットワーク</returns>
        public Ipv6Net AddIpv6Net()
		{
			Ipv6Net ret = this.Get_router().AddIpv6Net();
			this.Reload();
			return ret;
		}

        /// <summary>このルータ＋スイッチでIPv6アドレスを無効にします。
        /// </summary>
        /// <returns>this</returns>
        public Swytch RemoveIpv6Net()
		{
			System.Collections.Generic.List<Ipv6Net> nets = this.Get_ipv6Nets();
			this.Get_router().RemoveIpv6Net(nets[System.Convert.ToInt32(0)]);
			this.Reload();
			return this;
		}

        /// <summary>このルータ＋スイッチにスタティックルートを追加します。
        /// </summary>
        /// <param name="maskLen" />
        /// <param name="nextHop" />
        /// <returns>追加されたIPv4ネットワーク</returns>
        public Ipv4Net AddStaticRoute(long maskLen, string nextHop)
		{
			Ipv4Net ret = this.Get_router().AddStaticRoute(maskLen, nextHop);
			this.Reload();
			return ret;
		}

        /// <summary>このルータ＋スイッチからスタティックルートを削除します。
        /// </summary>
        /// <param name="ipv4Net" />
        /// <returns>this</returns>
        public Swytch RemoveStaticRoute(Ipv4Net ipv4Net)
		{
			this.Get_router().RemoveStaticRoute(ipv4Net);
			this.Reload();
			return this;
		}

        /// <summary>このルータ＋スイッチの帯域プランを変更します。
        /// </summary>
        /// <param name="bandWidthMbps">帯域幅（api.product.router.find() から取得できる <see cref="RouterPlan" /> の bandWidthMbps を指定）。</param>
        /// <returns>this</returns>
        public Swytch ChangePlan(long bandWidthMbps)
		{
			this.Get_router().ChangePlan(bandWidthMbps);
			this.Reload();
			return this;
		}

        /// <summary>このルータ＋スイッチをブリッジに接続します。
        /// </summary>
        /// <param name="swytch">接続先のブリッジ。</param>
        /// <param name="bridge" />
        /// <returns>this</returns>
        public Swytch ConnectToBridge(Bridge bridge)
		{
			object result = this._Client.Request("PUT", this._ApiPath() + "/" + this._Id() + "/to/bridge/" + bridge._Id());
			this.Reload();
			return this;
		}

        /// <summary>このルータ＋スイッチをブリッジから切断します。
        /// </summary>
        /// <returns>this</returns>
        public Swytch DisconnectFromBridge()
		{
			object result = this._Client.Request("DELETE", this._ApiPath() + "/" + this._Id() + "/to/bridge");
			this.Reload();
			return this;
		}
		
		internal object _UsedIpv4AddressHash()
		{
			object filter = new System.Collections.Generic.Dictionary<string, object> {};
			(filter as System.Collections.Generic.Dictionary<string, object>)["Switch" + ".ID"] = this._Id();
			object query = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(query, "Count", 0);
			Util.SetByPath(query, "Filter", filter);
			Util.SetByPath(query, "Include", new System.Collections.Generic.List<string> { "IPAddress", "UserIPAddress" });
			object result = this._Client.Request("GET", "/interface", query);
			if (result == null) {
				return null;
			}
			result = (result as System.Collections.Generic.Dictionary<string, object>)["Interfaces"];
			if (result == null) {
				return null;
			}
			System.Collections.Generic.List<object> ifaces = ((System.Collections.Generic.List<object>)(result));
			if (ifaces == null) {
				return null;
			}
			object found = new System.Collections.Generic.Dictionary<string, object> {};
			for (int __it1=0; __it1 < (ifaces as System.Collections.IList).Count; __it1++) {
				var iface = ifaces[__it1];
				string ip = ((string)((iface as System.Collections.Generic.Dictionary<string, object>)["IPAddress"]));
				string userIp = ((string)((iface as System.Collections.Generic.Dictionary<string, object>)["UserIPAddress"]));
				if (ip == null) {
					ip = userIp;
				}
				if (ip != null) {
					(found as System.Collections.Generic.Dictionary<string, object>)[ip] = true;
				}
			}
			return found;
		}
		
		/// <summary>このルータ＋スイッチに接続中のインタフェースに割り当てられているIPアドレスを収集します。
		/// </summary>
		public System.Collections.Generic.List<string> CollectUsedIpv4Addresses()
		{
			object found = this._UsedIpv4AddressHash();
			return Util.SortArray(Util.DictionaryKeys(found));
		}
		
		/// <summary>このルータ＋スイッチで利用できる未使用のIPアドレスを収集します。
		/// </summary>
		public System.Collections.Generic.List<string> CollectUnusedIpv4Addresses()
		{
			System.Collections.Generic.List<Ipv4Net> nets = this.Get_ipv4Nets();
			if (nets.Count < 1) {
				return null;
			}
			object used = this._UsedIpv4AddressHash();
			System.Collections.Generic.List<string> ret = new System.Collections.Generic.List<string> {  };
			for (int __it1=0; __it1 < (nets[System.Convert.ToInt32(0)].Get_range().Get_asArray() as System.Collections.IList).Count; __it1++) {
				var ip = nets[System.Convert.ToInt32(0)].Get_range().Get_asArray()[__it1];
				if (!(used as System.Collections.Generic.Dictionary<string, object>).ContainsKey(ip)) {
					(ret as System.Collections.IList).Add(ip);
				}
			}
			return Util.SortArray(ret);
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
		
		private bool N_tags = false;
		
		private System.Collections.Generic.List<string> Get_tags()
		{
			this.N_tags = true;
			return this.M_tags;
		}
		
		private System.Collections.Generic.List<string> Set_tags(System.Collections.Generic.List<string> v)
		{
			this.M_tags = v;
			this.N_tags = true;
			return this.M_tags;
		}
		
		/// <summary>タグ文字列の配列
		/// </summary>
		public System.Collections.Generic.List<string> Tags
		{
			get { return this.Get_tags(); }
			set { this.Set_tags(value); }
		}
		
		private bool N_icon = false;
		
		private Icon Get_icon()
		{
			return this.M_icon;
		}
		
		private Icon Set_icon(Icon v)
		{
			this.M_icon = v;
			this.N_icon = true;
			return this.M_icon;
		}
		
		/// <summary>アイコン
		/// </summary>
		public Icon Icon
		{
			get { return this.Get_icon(); }
			set { this.Set_icon(value); }
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
		
		private bool N_bridge = false;
		
		private Bridge Get_bridge()
		{
			return this.M_bridge;
		}
		
		/// <summary>接続されているブリッジ
		/// </summary>
		public Bridge Bridge
		{
			get { return this.Get_bridge(); }
		}
		
		private bool N_ipv4Nets = false;
		
		private System.Collections.Generic.List<Ipv4Net> Get_ipv4Nets()
		{
			return this.M_ipv4Nets;
		}
		
		/// <summary>IPv4ネットワーク（ルータによる自動割当） <see cref="Saklient.Cloud.Resources.Ipv4Net" /> の配列
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
		
		/// <summary>IPv6ネットワーク（ルータによる自動割当） <see cref="Saklient.Cloud.Resources.Ipv6Net" /> の配列
		/// </summary>
		public System.Collections.Generic.List<Ipv6Net> Ipv6Nets
		{
			get { return this.Get_ipv6Nets(); }
		}

        /// <summary>(This method is generated in Translator_default#buildImpl)
        /// </summary>
        /// <param name="r" />
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
			if (Util.ExistsPath(r, "Tags")) {
				if (Util.GetByPath(r, "Tags") == null) {
					this.M_tags = new System.Collections.Generic.List<string> {  };
				}
				else {
					this.M_tags = new System.Collections.Generic.List<string> {  };
					for (int __it1=0; __it1 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags"))) as System.Collections.IList).Count; __it1++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags")))[__it1];
						string v1 = null;
						v1 = t == null ? ((string)(null)) : "" + t;
						(this.M_tags as System.Collections.IList).Add(v1);
					}
				}
			}
			else {
				this.M_tags = null;
				this.IsIncomplete = true;
			}
			this.N_tags = false;
			if (Util.ExistsPath(r, "Icon")) {
				this.M_icon = Util.GetByPath(r, "Icon") == null ? null : new Icon(this._Client, Util.GetByPath(r, "Icon"));
			}
			else {
				this.M_icon = null;
				this.IsIncomplete = true;
			}
			this.N_icon = false;
			if (Util.ExistsPath(r, "UserSubnet.DefaultRoute")) {
				this.M_userDefaultRoute = Util.GetByPath(r, "UserSubnet.DefaultRoute") == null ? ((string)(null)) : "" + Util.GetByPath(r, "UserSubnet.DefaultRoute");
			}
			else {
				this.M_userDefaultRoute = null;
				this.IsIncomplete = true;
			}
			this.N_userDefaultRoute = false;
			if (Util.ExistsPath(r, "UserSubnet.NetworkMaskLen")) {
				this.M_userMaskLen = Util.GetByPath(r, "UserSubnet.NetworkMaskLen") == null ? System.Convert.ToInt64(null) : (long)System.Convert.ToInt64(""+"" + Util.GetByPath(r, "UserSubnet.NetworkMaskLen"));
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
			if (Util.ExistsPath(r, "Bridge")) {
				this.M_bridge = Util.GetByPath(r, "Bridge") == null ? null : new Bridge(this._Client, Util.GetByPath(r, "Bridge"));
			}
			else {
				this.M_bridge = null;
				this.IsIncomplete = true;
			}
			this.N_bridge = false;
			if (Util.ExistsPath(r, "Subnets")) {
				if (Util.GetByPath(r, "Subnets") == null) {
					this.M_ipv4Nets = new System.Collections.Generic.List<Ipv4Net> {  };
				}
				else {
					this.M_ipv4Nets = new System.Collections.Generic.List<Ipv4Net> {  };
					for (int __it2=0; __it2 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Subnets"))) as System.Collections.IList).Count; __it2++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Subnets")))[__it2];
						Ipv4Net v2 = null;
						v2 = t == null ? null : new Ipv4Net(this._Client, t);
						(this.M_ipv4Nets as System.Collections.IList).Add(v2);
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
					for (int __it3=0; __it3 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "IPv6Nets"))) as System.Collections.IList).Count; __it3++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "IPv6Nets")))[__it3];
						Ipv6Net v3 = null;
						v3 = t == null ? null : new Ipv6Net(this._Client, t);
						(this.M_ipv6Nets as System.Collections.IList).Add(v3);
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
			if (withClean || this.N_tags) {
				Util.SetByPath(ret, "Tags", new System.Collections.Generic.List<object> {  });
				for (int __it1=0; __it1 < (this.M_tags as System.Collections.IList).Count; __it1++) {
					var r1 = this.M_tags[__it1];
					object v = null;
					v = r1;
					((ret as System.Collections.Generic.Dictionary<string, object>)["Tags"] as System.Collections.IList).Add(v);
				}
			}
			if (withClean || this.N_icon) {
				Util.SetByPath(ret, "Icon", withClean ? (this.M_icon == null ? ((Icon)(null)) : this.M_icon.ApiSerialize(withClean)) : (this.M_icon == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_icon.ApiSerializeID()));
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
			if (withClean || this.N_bridge) {
				Util.SetByPath(ret, "Bridge", withClean ? (this.M_bridge == null ? ((Bridge)(null)) : this.M_bridge.ApiSerialize(withClean)) : (this.M_bridge == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_bridge.ApiSerializeID()));
			}
			if (withClean || this.N_ipv4Nets) {
				Util.SetByPath(ret, "Subnets", new System.Collections.Generic.List<object> {  });
				for (int __it2=0; __it2 < (this.M_ipv4Nets as System.Collections.IList).Count; __it2++) {
					var r2 = this.M_ipv4Nets[__it2];
					object v = null;
					v = withClean ? (r2 == null ? ((Ipv4Net)(null)) : r2.ApiSerialize(withClean)) : (r2 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r2.ApiSerializeID());
					((ret as System.Collections.Generic.Dictionary<string, object>)["Subnets"] as System.Collections.IList).Add(v);
				}
			}
			if (withClean || this.N_ipv6Nets) {
				Util.SetByPath(ret, "IPv6Nets", new System.Collections.Generic.List<object> {  });
				for (int __it3=0; __it3 < (this.M_ipv6Nets as System.Collections.IList).Count; __it3++) {
					var r3 = this.M_ipv6Nets[__it3];
					object v = null;
					v = withClean ? (r3 == null ? ((Ipv6Net)(null)) : r3.ApiSerialize(withClean)) : (r3 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r3.ApiSerializeID());
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
