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

	/**
	 * スイッチの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Swytch
	 * @class Swytch
	 * @constructor
	 * @extends Resource
	 */
	public class Swytch : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Swytch#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.Swytch#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * 説明
		 * 
		 * @member saklient.cloud.resources.Swytch#M_description
		 * @type string
		 * @internal
		 */
		internal string M_description;
		
		/**
		 * ユーザ設定IPv4ネットワークのゲートウェイ
		 * 
		 * @member saklient.cloud.resources.Swytch#M_userDefaultRoute
		 * @type string
		 * @internal
		 */
		internal string M_userDefaultRoute;
		
		/**
		 * ユーザ設定IPv4ネットワークのマスク長
		 * 
		 * @member saklient.cloud.resources.Swytch#M_userMaskLen
		 * @type long?
		 * @internal
		 */
		internal long? M_userMaskLen;
		
		/**
		 * 接続されているルータ
		 * 
		 * @member saklient.cloud.resources.Swytch#M_router
		 * @type Router
		 * @internal
		 */
		internal Router M_router;
		
		/**
		 * IPv4ネットワーク（ルータによる自動割当）
		 * 
		 * @member saklient.cloud.resources.Swytch#M_ipv4Nets
		 * @type System.Collections.Generic.List<Ipv4Net>
		 * @internal
		 */
		internal System.Collections.Generic.List<Ipv4Net> M_ipv4Nets;
		
		/**
		 * IPv6ネットワーク（ルータによる自動割当）
		 * 
		 * @member saklient.cloud.resources.Swytch#M_ipv6Nets
		 * @type System.Collections.Generic.List<Ipv6Net>
		 * @internal
		 */
		internal System.Collections.Generic.List<Ipv6Net> M_ipv6Nets;
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/switch";
		}
		
		/**
		 * @private
		 * @method _rootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _rootKey()
		{
			return "Switch";
		}
		
		/**
		 * @private
		 * @method _rootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _rootKeyM()
		{
			return "Switches";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Swytch";
		}
		
		/**
		 * @private
		 * @method _id
		 * @ignore
		 * @return {string}
		 */
		public override string _id()
		{
			return this.Get_id();
		}
		
		/**
		 * このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		 * 
		 * @method Save
		 * @chainable
		 * @public
		 * @return {Swytch} this
		 */
		public Swytch Save()
		{
			return ((Swytch)(this._save()));
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
		 * @chainable
		 * @public
		 * @return {Swytch} this
		 */
		public Swytch Reload()
		{
			return ((Swytch)(this._reload()));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 */
		public Swytch(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "object");
			Util.ValidateType(wrapped, "bool");
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * このルータ＋スイッチでIPv6アドレスを有効にします。
		 * 
		 * @method AddIpv6Net
		 * @public
		 * @return {Ipv6Net} 有効化されたIPv6ネットワーク
		 */
		public Ipv6Net AddIpv6Net()
		{
			Ipv6Net ret = this.Get_router().AddIpv6Net();
			this.Reload();
			return ret;
		}
		
		/**
		 * このルータ＋スイッチでIPv6アドレスを無効にします。
		 * 
		 * @method RemoveIpv6Net
		 * @chainable
		 * @public
		 * @return {Swytch} this
		 */
		public Swytch RemoveIpv6Net()
		{
			System.Collections.Generic.List<Ipv6Net> nets = this.Get_ipv6Nets();
			this.Get_router().RemoveIpv6Net(nets[System.Convert.ToInt32(0)]);
			this.Reload();
			return this;
		}
		
		/**
		 * このルータ＋スイッチにスタティックルートを追加します。
		 * 
		 * @method AddStaticRoute
		 * @public
		 * @param {long} maskLen
		 * @param {string} nextHop
		 * @return {Ipv4Net} 追加されたIPv4ネットワーク
		 */
		public Ipv4Net AddStaticRoute(long maskLen, string nextHop)
		{
			Util.ValidateType(maskLen, "long");
			Util.ValidateType(nextHop, "string");
			Ipv4Net ret = this.Get_router().AddStaticRoute(maskLen, nextHop);
			this.Reload();
			return ret;
		}
		
		/**
		 * このルータ＋スイッチからスタティックルートを削除します。
		 * 
		 * @method RemoveStaticRoute
		 * @chainable
		 * @public
		 * @param {Ipv4Net} ipv4Net
		 * @return {Swytch} this
		 */
		public Swytch RemoveStaticRoute(Ipv4Net ipv4Net)
		{
			Util.ValidateType(ipv4Net, "Saklient.Cloud.Resources.Ipv4Net");
			this.Get_router().RemoveStaticRoute(ipv4Net);
			this.Reload();
			return this;
		}
		
		/**
		 * このルータ＋スイッチの帯域プランを変更します。
		 * 
		 * @method ChangePlan
		 * @chainable
		 * @public
		 * @param {long} bandWidthMbps
		 * @return {Swytch} this
		 */
		public Swytch ChangePlan(long bandWidthMbps)
		{
			Util.ValidateType(bandWidthMbps, "long");
			this.Get_router().ChangePlan(bandWidthMbps);
			this.Reload();
			return this;
		}
		
		/**
		 * @member saklient.cloud.resources.Swytch#N_id
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_id = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_id
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_id()
		{
			return this.M_id;
		}
		
		/**
		 * ID
		 * 
		 * @property Id
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Id
		{
			get { return this.Get_id(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Swytch#N_name
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_name = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_name
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_name()
		{
			return this.M_name;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_name
		 * @private
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		private string Set_name(string v)
		{
			Util.ValidateType(v, "string");
			this.M_name = v;
			this.N_name = true;
			return this.M_name;
		}
		
		/**
		 * 名前
		 * 
		 * @property Name
		 * @type string
		 * @public
		 */
		public string Name
		{
			get { return this.Get_name(); }
			set { this.Set_name(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Swytch#N_description
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_description = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_description
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_description()
		{
			return this.M_description;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_description
		 * @private
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		private string Set_description(string v)
		{
			Util.ValidateType(v, "string");
			this.M_description = v;
			this.N_description = true;
			return this.M_description;
		}
		
		/**
		 * 説明
		 * 
		 * @property Description
		 * @type string
		 * @public
		 */
		public string Description
		{
			get { return this.Get_description(); }
			set { this.Set_description(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Swytch#N_userDefaultRoute
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_userDefaultRoute = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_userDefaultRoute
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_userDefaultRoute()
		{
			return this.M_userDefaultRoute;
		}
		
		/**
		 * ユーザ設定IPv4ネットワークのゲートウェイ
		 * 
		 * @property UserDefaultRoute
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string UserDefaultRoute
		{
			get { return this.Get_userDefaultRoute(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Swytch#N_userMaskLen
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_userMaskLen = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_userMaskLen
		 * @private
		 * @ignore
		 * @return {long?}
		 */
		private long? Get_userMaskLen()
		{
			return this.M_userMaskLen;
		}
		
		/**
		 * ユーザ設定IPv4ネットワークのマスク長
		 * 
		 * @property UserMaskLen
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? UserMaskLen
		{
			get { return this.Get_userMaskLen(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Swytch#N_router
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_router = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_router
		 * @private
		 * @ignore
		 * @return {Router}
		 */
		private Router Get_router()
		{
			return this.M_router;
		}
		
		/**
		 * 接続されているルータ
		 * 
		 * @property Router
		 * @type Router
		 * @readOnly
		 * @public
		 */
		public Router Router
		{
			get { return this.Get_router(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Swytch#N_ipv4Nets
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_ipv4Nets = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_ipv4Nets
		 * @private
		 * @ignore
		 * @return {System.Collections.Generic.List<Ipv4Net>}
		 */
		private System.Collections.Generic.List<Ipv4Net> Get_ipv4Nets()
		{
			return this.M_ipv4Nets;
		}
		
		/**
		 * IPv4ネットワーク（ルータによる自動割当）
		 * 
		 * @property Ipv4Nets
		 * @type System.Collections.Generic.List<Ipv4Net>
		 * @readOnly
		 * @public
		 */
		public System.Collections.Generic.List<Ipv4Net> Ipv4Nets
		{
			get { return this.Get_ipv4Nets(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Swytch#N_ipv6Nets
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_ipv6Nets = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_ipv6Nets
		 * @private
		 * @ignore
		 * @return {System.Collections.Generic.List<Ipv6Net>}
		 */
		private System.Collections.Generic.List<Ipv6Net> Get_ipv6Nets()
		{
			return this.M_ipv6Nets;
		}
		
		/**
		 * IPv6ネットワーク（ルータによる自動割当）
		 * 
		 * @property Ipv6Nets
		 * @type System.Collections.Generic.List<Ipv6Net>
		 * @readOnly
		 * @public
		 */
		public System.Collections.Generic.List<Ipv6Net> Ipv6Nets
		{
			get { return this.Get_ipv6Nets(); }
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method ApiDeserializeImpl
		 * @internal
		 * @param {object} r
		 */
		internal override void ApiDeserializeImpl(object r)
		{
			Util.ValidateType(r, "object");
			this.IsNew = r == null;
			if (this.IsNew) {
				r = new System.Collections.Generic.Dictionary<string, object> {  };
			};
			this.IsIncomplete = false;
			if (Util.ExistsPath(r, "ID")) {
				this.M_id = Util.GetByPath(r, "ID") == null ? null : "" + Util.GetByPath(r, "ID");
			}
			else {
				this.M_id = null;
				this.IsIncomplete = true;
			};
			this.N_id = false;
			if (Util.ExistsPath(r, "Name")) {
				this.M_name = Util.GetByPath(r, "Name") == null ? null : "" + Util.GetByPath(r, "Name");
			}
			else {
				this.M_name = null;
				this.IsIncomplete = true;
			};
			this.N_name = false;
			if (Util.ExistsPath(r, "Description")) {
				this.M_description = Util.GetByPath(r, "Description") == null ? null : "" + Util.GetByPath(r, "Description");
			}
			else {
				this.M_description = null;
				this.IsIncomplete = true;
			};
			this.N_description = false;
			if (Util.ExistsPath(r, "UserSubnet.DefaultRoute")) {
				this.M_userDefaultRoute = Util.GetByPath(r, "UserSubnet.DefaultRoute") == null ? null : "" + Util.GetByPath(r, "UserSubnet.DefaultRoute");
			}
			else {
				this.M_userDefaultRoute = null;
				this.IsIncomplete = true;
			};
			this.N_userDefaultRoute = false;
			if (Util.ExistsPath(r, "UserSubnet.NetworkMaskLen")) {
				this.M_userMaskLen = Util.GetByPath(r, "UserSubnet.NetworkMaskLen") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "UserSubnet.NetworkMaskLen"));
			}
			else {
				this.M_userMaskLen = null;
				this.IsIncomplete = true;
			};
			this.N_userMaskLen = false;
			if (Util.ExistsPath(r, "Internet")) {
				this.M_router = Util.GetByPath(r, "Internet") == null ? null : new Router(this._client, Util.GetByPath(r, "Internet"));
			}
			else {
				this.M_router = null;
				this.IsIncomplete = true;
			};
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
						v1 = t == null ? null : new Ipv4Net(this._client, t);
						(this.M_ipv4Nets as System.Collections.IList).Add(v1);
					};
				};
			}
			else {
				this.M_ipv4Nets = null;
				this.IsIncomplete = true;
			};
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
						v2 = t == null ? null : new Ipv6Net(this._client, t);
						(this.M_ipv6Nets as System.Collections.IList).Add(v2);
					};
				};
			}
			else {
				this.M_ipv6Nets = null;
				this.IsIncomplete = true;
			};
			this.N_ipv6Nets = false;
		}
		
		/**
		 * @ignore
		 * @method ApiSerializeImpl
		 * @internal
		 * @param {bool} withClean=false
		 * @return {object}
		 */
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			Util.ValidateType(withClean, "bool");
			System.Collections.Generic.List<string> missing = new System.Collections.Generic.List<string> {  };
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			};
			if (withClean || this.N_name) {
				Util.SetByPath(ret, "Name", this.M_name);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("name");
				};
			};
			if (withClean || this.N_description) {
				Util.SetByPath(ret, "Description", this.M_description);
			};
			if (withClean || this.N_userDefaultRoute) {
				Util.SetByPath(ret, "UserSubnet.DefaultRoute", this.M_userDefaultRoute);
			};
			if (withClean || this.N_userMaskLen) {
				Util.SetByPath(ret, "UserSubnet.NetworkMaskLen", this.M_userMaskLen);
			};
			if (withClean || this.N_router) {
				Util.SetByPath(ret, "Internet", withClean ? (this.M_router == null ? null : this.M_router.ApiSerialize(withClean)) : (this.M_router == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_router.ApiSerializeID()));
			};
			if (withClean || this.N_ipv4Nets) {
				Util.SetByPath(ret, "Subnets", new System.Collections.Generic.List<object> {  });
				for (int __it1=0; __it1 < (this.M_ipv4Nets as System.Collections.IList).Count; __it1++) {
					var r1 = this.M_ipv4Nets[__it1];
					object v = null;
					v = withClean ? (r1 == null ? null : r1.ApiSerialize(withClean)) : (r1 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r1.ApiSerializeID());
					((ret as System.Collections.Generic.Dictionary<string, object>)["Subnets"] as System.Collections.IList).Add(v);
				};
			};
			if (withClean || this.N_ipv6Nets) {
				Util.SetByPath(ret, "IPv6Nets", new System.Collections.Generic.List<object> {  });
				for (int __it2=0; __it2 < (this.M_ipv6Nets as System.Collections.IList).Count; __it2++) {
					var r2 = this.M_ipv6Nets[__it2];
					object v = null;
					v = withClean ? (r2 == null ? null : r2.ApiSerialize(withClean)) : (r2 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r2.ApiSerializeID());
					((ret as System.Collections.Generic.Dictionary<string, object>)["IPv6Nets"] as System.Collections.IList).Add(v);
				};
			};
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Swytch creation: " + string.Join(", ", (missing).ToArray()));
			};
			return ret;
		}
		
	}
	
}
