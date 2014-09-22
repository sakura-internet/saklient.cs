using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Swytch = Saklient.Cloud.Resources.Swytch;

namespace Saklient.Cloud.Resources
{

	/**
	 * IPv6ネットワークの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Ipv6Net
	 * @class Ipv6Net
	 * @constructor
	 * @extends Resource
	 */
	public class Ipv6Net : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Ipv6Net#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * ネットワークプレフィックス
		 * 
		 * @member saklient.cloud.resources.Ipv6Net#M_prefix
		 * @type string
		 * @internal
		 */
		internal string M_prefix;
		
		/**
		 * ネットワークプレフィックス長
		 * 
		 * @member saklient.cloud.resources.Ipv6Net#M_prefixLen
		 * @type long?
		 * @internal
		 */
		internal long? M_prefixLen;
		
		/**
		 * このネットワーク範囲における最後のIPv6アドレス
		 * 
		 * @member saklient.cloud.resources.Ipv6Net#M_prefixTail
		 * @type string
		 * @internal
		 */
		internal string M_prefixTail;
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/ipv6net";
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
			return "IPv6Net";
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
			return "IPv6Nets";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Ipv6Net";
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
		public Ipv6Net(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * @member saklient.cloud.resources.Ipv6Net#N_id
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
		 * @member saklient.cloud.resources.Ipv6Net#N_prefix
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_prefix = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_prefix
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_prefix()
		{
			return this.M_prefix;
		}
		
		/**
		 * ネットワークプレフィックス
		 * 
		 * @property Prefix
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Prefix
		{
			get { return this.Get_prefix(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Ipv6Net#N_prefixLen
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_prefixLen = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_prefixLen
		 * @private
		 * @ignore
		 * @return {long?}
		 */
		private long? Get_prefixLen()
		{
			return this.M_prefixLen;
		}
		
		/**
		 * ネットワークプレフィックス長
		 * 
		 * @property PrefixLen
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? PrefixLen
		{
			get { return this.Get_prefixLen(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Ipv6Net#N_prefixTail
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_prefixTail = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_prefixTail
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_prefixTail()
		{
			return this.M_prefixTail;
		}
		
		/**
		 * このネットワーク範囲における最後のIPv6アドレス
		 * 
		 * @property PrefixTail
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string PrefixTail
		{
			get { return this.Get_prefixTail(); }
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
			this.IsNew = r == null;
			if (this.IsNew) {
				r = new System.Collections.Generic.Dictionary<string, object> {  };
			}
			this.IsIncomplete = false;
			if (Util.ExistsPath(r, "ID")) {
				this.M_id = Util.GetByPath(r, "ID") == null ? null : "" + Util.GetByPath(r, "ID");
			}
			else {
				this.M_id = null;
				this.IsIncomplete = true;
			}
			this.N_id = false;
			if (Util.ExistsPath(r, "IPv6Prefix")) {
				this.M_prefix = Util.GetByPath(r, "IPv6Prefix") == null ? null : "" + Util.GetByPath(r, "IPv6Prefix");
			}
			else {
				this.M_prefix = null;
				this.IsIncomplete = true;
			}
			this.N_prefix = false;
			if (Util.ExistsPath(r, "IPv6PrefixLen")) {
				this.M_prefixLen = Util.GetByPath(r, "IPv6PrefixLen") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "IPv6PrefixLen"));
			}
			else {
				this.M_prefixLen = null;
				this.IsIncomplete = true;
			}
			this.N_prefixLen = false;
			if (Util.ExistsPath(r, "IPv6PrefixTail")) {
				this.M_prefixTail = Util.GetByPath(r, "IPv6PrefixTail") == null ? null : "" + Util.GetByPath(r, "IPv6PrefixTail");
			}
			else {
				this.M_prefixTail = null;
				this.IsIncomplete = true;
			}
			this.N_prefixTail = false;
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
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_prefix) {
				Util.SetByPath(ret, "IPv6Prefix", this.M_prefix);
			}
			if (withClean || this.N_prefixLen) {
				Util.SetByPath(ret, "IPv6PrefixLen", this.M_prefixLen);
			}
			if (withClean || this.N_prefixTail) {
				Util.SetByPath(ret, "IPv6PrefixTail", this.M_prefixTail);
			}
			return ret;
		}
		
	}
	
}
