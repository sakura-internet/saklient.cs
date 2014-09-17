using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;

namespace Saklient.Cloud.Resources
{

	/**
	 * @ignore
	 * @module saklient.cloud.resources.Resource
	 * @class Resource
	 * @constructor
	 */
	class Resource
	{
		
		/**
		 * @private
		 * @member saklient.cloud.resources.Resource#_client
		 * @type Client
		 * @internal
		 * @ignore
		 */
		internal Client _client;
		
		/**
		 * @method Get_client
		 * @internal
		 * @ignore
		 * @return {Client}
		 */
		internal Client Get_client()
		{
			return this._client;
		}
		
		/**
		 * @ignore
		 * @property Client
		 * @type Client
		 * @readOnly
		 */
		public Client Client
		{
			get { return this.Get_client(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.Resource#_query
		 * @type dynamic
		 * @internal
		 * @ignore
		 */
		internal dynamic _query;
		
		/**
		 * @ignore
		 * @method SetParam
		 * @param {string} key
		 * @param {dynamic} value
		 * @return {void}
		 */
		public void SetParam(string key, dynamic value)
		{
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "dynamic");
			(this._query as System.Collections.Generic.Dictionary<string, object>)[key] = value;
		}
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _apiPath()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _rootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _rootKey()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _rootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _rootKeyM()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public virtual string _className()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _id
		 * @ignore
		 * @return {string}
		 */
		public virtual string _id()
		{
			return null;
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Resource(Client client)
		{
			Util.ValidateType(client, "Saklient.Cloud.Client");
			this._client = client;
			this._query = new System.Collections.Generic.Dictionary<string, object> {};
		}
		
		/**
		 * @ignore
		 * @member saklient.cloud.resources.Resource#IsNew
		 * @type bool
		 * @internal
		 */
		internal bool IsNew;
		
		/**
		 * @ignore
		 * @member saklient.cloud.resources.Resource#IsIncomplete
		 * @type bool
		 * @internal
		 */
		internal bool IsIncomplete;
		
		/**
		 * @private
		 * @method _onBeforeSave
		 * @internal
		 * @ignore
		 * @param {dynamic} r
		 * @return {void}
		 */
		internal virtual void _onBeforeSave(dynamic r)
		{
			Util.ValidateType(r, "dynamic");
		}
		
		/**
		 * @private
		 * @method _onAfterApiDeserialize
		 * @internal
		 * @ignore
		 * @param {dynamic} r
		 * @param {dynamic} root
		 * @return {void}
		 */
		internal virtual void _onAfterApiDeserialize(dynamic r, dynamic root)
		{
			Util.ValidateType(r, "dynamic");
			Util.ValidateType(root, "dynamic");
		}
		
		/**
		 * @private
		 * @method _onAfterApiSerialize
		 * @internal
		 * @ignore
		 * @param {dynamic} r
		 * @param {bool} withClean
		 * @return {void}
		 */
		internal virtual void _onAfterApiSerialize(dynamic r, bool withClean)
		{
			Util.ValidateType(r, "dynamic");
			Util.ValidateType(withClean, "bool");
		}
		
		/**
		 * @ignore
		 * @method ApiDeserializeImpl
		 * @internal
		 * @param {dynamic} r
		 * @return {void}
		 */
		internal virtual void ApiDeserializeImpl(dynamic r)
		{
			Util.ValidateType(r, "dynamic");
		}
		
		/**
		 * @ignore
		 * @method ApiDeserialize
		 * @param {dynamic} obj
		 * @param {bool} wrapped=false
		 * @return {void}
		 */
		public void ApiDeserialize(dynamic obj, bool wrapped=false)
		{
			Util.ValidateType(obj, "dynamic");
			Util.ValidateType(wrapped, "bool");
			dynamic root = null;
			dynamic record = null;
			string rkey = this._rootKey();
			if (obj != null) {
				if (!wrapped) {
					if (rkey != null) {
						root = new System.Collections.Generic.Dictionary<string, object> {};
						(root as System.Collections.Generic.Dictionary<string, object>)[rkey] = obj;
					};
					record = obj;
				}
				else {
					root = obj;
					record = (obj as System.Collections.Generic.Dictionary<string, object>)[rkey];
				};
			};
			this.ApiDeserializeImpl(record);
			this._onAfterApiDeserialize(record, root);
		}
		
		/**
		 * @ignore
		 * @method ApiSerializeImpl
		 * @internal
		 * @param {bool} withClean=false
		 * @return {dynamic}
		 */
		internal virtual dynamic ApiSerializeImpl(bool withClean=false)
		{
			Util.ValidateType(withClean, "bool");
			return null;
		}
		
		/**
		 * @ignore
		 * @method ApiSerialize
		 * @param {bool} withClean=false
		 * @return {dynamic}
		 */
		public dynamic ApiSerialize(bool withClean=false)
		{
			Util.ValidateType(withClean, "bool");
			dynamic ret = this.ApiSerializeImpl(withClean);
			this._onAfterApiSerialize(ret, withClean);
			return ret;
		}
		
		/**
		 * @ignore
		 * @method ApiSerializeID
		 * @internal
		 * @return {dynamic}
		 */
		internal dynamic ApiSerializeID()
		{
			string id = this._id();
			if (id == null) {
				return null;
			};
			dynamic r = new System.Collections.Generic.Dictionary<string, object> {};
			(r as System.Collections.Generic.Dictionary<string, object>)["ID"] = id;
			return r;
		}
		
		/**
		 * @ignore
		 * @method NormalizeFieldName
		 * @internal
		 * @param {string} name
		 * @return {string}
		 */
		internal string NormalizeFieldName(string name)
		{
			Util.ValidateType(name, "string");
			return name;
		}
		
		/**
		 * @ignore
		 * @method SetProperty
		 * @param {string} name
		 * @param {dynamic} value
		 * @return {void}
		 */
		public void SetProperty(string name, dynamic value)
		{
			Util.ValidateType(name, "string");
			Util.ValidateType(value, "dynamic");
			name = this.NormalizeFieldName(name);
			System.Reflection.PropertyInfo prop = this.GetType().GetProperty("M_"+name);
			prop.SetValue(this, System.Convert.ChangeType(value, prop.PropertyType), null);
			prop = this.GetType().GetProperty("N_"+name);
			prop.SetValue(this, System.Convert.ChangeType(true, prop.PropertyType), null);
		}
		
		/**
		 * このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		 * 
		 * @private
		 * @method _save
		 * @chainable
		 * @internal
		 * @ignore
		 * @return {Resource} this
		 */
		internal Resource _save()
		{
			dynamic r = this.ApiSerialize();
			dynamic query = this._query;
			this._query = new System.Collections.Generic.Dictionary<string, object> {};
			string[] keys = Util.DictionaryKeys(query);
			for (int __it1=0; __it1 < (keys as System.Collections.IList).Count; __it1++) {
				var k = keys[__it1];
				dynamic v = (query as System.Collections.Generic.Dictionary<string, object>)[k];
				(r as System.Collections.Generic.Dictionary<string, object>)[k] = v;
			};
			this._onBeforeSave(r);
			dynamic method = this.IsNew ? "POST" : "PUT";
			dynamic path = this._apiPath();
			if (!this.IsNew) {
				path += "/" + Util.UrlEncode(this._id());
			};
			dynamic q = new System.Collections.Generic.Dictionary<string, object> {};
			(q as System.Collections.Generic.Dictionary<string, object>)[this._rootKey()] = r;
			dynamic result = this._client.Request(method, path, q);
			this.ApiDeserialize(result, true);
			return this;
		}
		
		/**
		 * このローカルオブジェクトのIDと一致するリソースの削除リクエストをAPIに送信します。
		 * 
		 * @method Destroy
		 * @public
		 * @return {void}
		 */
		public void Destroy()
		{
			if (this.IsNew) {
				return;
			};
			dynamic path = this._apiPath() + "/" + Util.UrlEncode(this._id());
			this._client.Request("DELETE", path);
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @private
		 * @method _reload
		 * @chainable
		 * @internal
		 * @ignore
		 * @return {Resource} this
		 */
		internal Resource _reload()
		{
			dynamic result = this._client.Request("GET", this._apiPath() + "/" + Util.UrlEncode(this._id()));
			this.ApiDeserialize(result, true);
			return this;
		}
		
		/**
		 * このリソースが存在するかを調べます。
		 * 
		 * @method Exists
		 * @public
		 * @return {bool}
		 */
		public bool Exists()
		{
			dynamic query = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(query, "Filter.ID", new object[] { this._id() });
			Util.SetByPath(query, "Include", new object[] { "ID" });
			dynamic result = this._client.Request("GET", this._apiPath(), query);
			return ((int?)(dynamic)((result as System.Collections.Generic.Dictionary<string, object>)["Count"])) == 1;
		}
		
		/**
		 * @ignore
		 * @method Dump
		 * @return {dynamic}
		 */
		public dynamic Dump()
		{
			return this.ApiSerialize(true);
		}
		
	}
	
}
