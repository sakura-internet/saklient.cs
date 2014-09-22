using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using EScope = Saklient.Cloud.Enums.EScope;

namespace Saklient.Cloud.Resources
{

	/**
	 * アイコンの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Icon
	 * @class Icon
	 * @constructor
	 * @extends Resource
	 */
	public class Icon : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Icon#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * スコープ {@link EScope}
		 * 
		 * @member saklient.cloud.resources.Icon#M_scope
		 * @type string
		 * @internal
		 */
		internal string M_scope;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.Icon#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * URL
		 * 
		 * @member saklient.cloud.resources.Icon#M_url
		 * @type string
		 * @internal
		 */
		internal string M_url;
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/icon";
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
			return "Icon";
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
			return "Icons";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Icon";
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
		 * @return {Icon} this
		 */
		public Icon Save()
		{
			return ((Icon)(this._save()));
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
		 * @chainable
		 * @public
		 * @return {Icon} this
		 */
		public Icon Reload()
		{
			return ((Icon)(this._reload()));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 */
		public Icon(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * @member saklient.cloud.resources.Icon#N_id
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
		 * @member saklient.cloud.resources.Icon#N_scope
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_scope = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_scope
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_scope()
		{
			return this.M_scope;
		}
		
		/**
		 * スコープ {@link EScope}
		 * 
		 * @property Scope
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Scope
		{
			get { return this.Get_scope(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Icon#N_name
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
		 * @member saklient.cloud.resources.Icon#N_url
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_url = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_url
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_url()
		{
			return this.M_url;
		}
		
		/**
		 * URL
		 * 
		 * @property Url
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Url
		{
			get { return this.Get_url(); }
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
			if (Util.ExistsPath(r, "Scope")) {
				this.M_scope = Util.GetByPath(r, "Scope") == null ? null : "" + Util.GetByPath(r, "Scope");
			}
			else {
				this.M_scope = null;
				this.IsIncomplete = true;
			}
			this.N_scope = false;
			if (Util.ExistsPath(r, "Name")) {
				this.M_name = Util.GetByPath(r, "Name") == null ? null : "" + Util.GetByPath(r, "Name");
			}
			else {
				this.M_name = null;
				this.IsIncomplete = true;
			}
			this.N_name = false;
			if (Util.ExistsPath(r, "URL")) {
				this.M_url = Util.GetByPath(r, "URL") == null ? null : "" + Util.GetByPath(r, "URL");
			}
			else {
				this.M_url = null;
				this.IsIncomplete = true;
			}
			this.N_url = false;
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
			System.Collections.Generic.List<string> missing = new System.Collections.Generic.List<string> {  };
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_scope) {
				Util.SetByPath(ret, "Scope", this.M_scope);
			}
			if (withClean || this.N_name) {
				Util.SetByPath(ret, "Name", this.M_name);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("name");
				}
			}
			if (withClean || this.N_url) {
				Util.SetByPath(ret, "URL", this.M_url);
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Icon creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
