using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Swytch = Saklient.Cloud.Resources.Swytch;

namespace Saklient.Cloud.Resources
{

	/**
	 * IPv4ネットワークの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Ipv4Net
	 * @class Ipv4Net
	 * @constructor
	 * @extends Resource
	 */
	public class Ipv4Net : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Ipv4Net#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * ネットワークアドレス
		 * 
		 * @member saklient.cloud.resources.Ipv4Net#M_address
		 * @type string
		 * @internal
		 */
		internal string M_address;
		
		/**
		 * マスク長
		 * 
		 * @member saklient.cloud.resources.Ipv4Net#M_maskLen
		 * @type long?
		 * @internal
		 */
		internal long? M_maskLen;
		
		/**
		 * デフォルトルート
		 * 
		 * @member saklient.cloud.resources.Ipv4Net#M_defaultRoute
		 * @type string
		 * @internal
		 */
		internal string M_defaultRoute;
		
		/**
		 * ネクストホップ
		 * 
		 * @member saklient.cloud.resources.Ipv4Net#M_nextHop
		 * @type string
		 * @internal
		 */
		internal string M_nextHop;
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/subnet";
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
			return "Subnet";
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
			return "Subnets";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Ipv4Net";
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
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
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
		public Ipv4Net(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "object");
			Util.ValidateType(wrapped, "bool");
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * @member saklient.cloud.resources.Ipv4Net#N_id
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
		 * @member saklient.cloud.resources.Ipv4Net#N_address
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_address = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_address
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_address()
		{
			return this.M_address;
		}
		
		/**
		 * ネットワークアドレス
		 * 
		 * @property Address
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Address
		{
			get { return this.Get_address(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Ipv4Net#N_maskLen
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_maskLen = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_maskLen
		 * @private
		 * @ignore
		 * @return {long?}
		 */
		private long? Get_maskLen()
		{
			return this.M_maskLen;
		}
		
		/**
		 * マスク長
		 * 
		 * @property MaskLen
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? MaskLen
		{
			get { return this.Get_maskLen(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Ipv4Net#N_defaultRoute
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_defaultRoute = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_defaultRoute
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_defaultRoute()
		{
			return this.M_defaultRoute;
		}
		
		/**
		 * デフォルトルート
		 * 
		 * @property DefaultRoute
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string DefaultRoute
		{
			get { return this.Get_defaultRoute(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Ipv4Net#N_nextHop
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_nextHop = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_nextHop
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_nextHop()
		{
			return this.M_nextHop;
		}
		
		/**
		 * ネクストホップ
		 * 
		 * @property NextHop
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string NextHop
		{
			get { return this.Get_nextHop(); }
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
			if (Util.ExistsPath(r, "NetworkAddress")) {
				this.M_address = Util.GetByPath(r, "NetworkAddress") == null ? null : "" + Util.GetByPath(r, "NetworkAddress");
			}
			else {
				this.M_address = null;
				this.IsIncomplete = true;
			};
			this.N_address = false;
			if (Util.ExistsPath(r, "NetworkMaskLen")) {
				this.M_maskLen = Util.GetByPath(r, "NetworkMaskLen") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "NetworkMaskLen"));
			}
			else {
				this.M_maskLen = null;
				this.IsIncomplete = true;
			};
			this.N_maskLen = false;
			if (Util.ExistsPath(r, "DefaultRoute")) {
				this.M_defaultRoute = Util.GetByPath(r, "DefaultRoute") == null ? null : "" + Util.GetByPath(r, "DefaultRoute");
			}
			else {
				this.M_defaultRoute = null;
				this.IsIncomplete = true;
			};
			this.N_defaultRoute = false;
			if (Util.ExistsPath(r, "NextHop")) {
				this.M_nextHop = Util.GetByPath(r, "NextHop") == null ? null : "" + Util.GetByPath(r, "NextHop");
			}
			else {
				this.M_nextHop = null;
				this.IsIncomplete = true;
			};
			this.N_nextHop = false;
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
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			};
			if (withClean || this.N_address) {
				Util.SetByPath(ret, "NetworkAddress", this.M_address);
			};
			if (withClean || this.N_maskLen) {
				Util.SetByPath(ret, "NetworkMaskLen", this.M_maskLen);
			};
			if (withClean || this.N_defaultRoute) {
				Util.SetByPath(ret, "DefaultRoute", this.M_defaultRoute);
			};
			if (withClean || this.N_nextHop) {
				Util.SetByPath(ret, "NextHop", this.M_nextHop);
			};
			return ret;
		}
		
	}
	
}
