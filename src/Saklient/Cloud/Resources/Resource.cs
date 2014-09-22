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
	public class Resource
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
		 * @type object
		 * @internal
		 * @ignore
		 */
		internal object _query;
		
		/**
		 * @ignore
		 * @method SetParam
		 * @param {string} key
		 * @param {object} value
		 * @return {void}
		 */
		public void SetParam(string key, object value)
		{
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
		 * @param {object} r
		 * @return {void}
		 */
		internal virtual void _onBeforeSave(object r)
		{
			
		}
		
		/**
		 * @private
		 * @method _onAfterApiDeserialize
		 * @internal
		 * @ignore
		 * @param {object} r
		 * @param {object} root
		 * @return {void}
		 */
		internal virtual void _onAfterApiDeserialize(object r, object root)
		{
			
		}
		
		/**
		 * @private
		 * @method _onAfterApiSerialize
		 * @internal
		 * @ignore
		 * @param {object} r
		 * @param {bool} withClean
		 * @return {void}
		 */
		internal virtual void _onAfterApiSerialize(object r, bool withClean)
		{
			
		}
		
		/**
		 * @ignore
		 * @method ApiDeserializeImpl
		 * @internal
		 * @param {object} r
		 * @return {void}
		 */
		internal virtual void ApiDeserializeImpl(object r)
		{
			
		}
		
		/**
		 * @ignore
		 * @method ApiDeserialize
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 * @return {void}
		 */
		public void ApiDeserialize(object obj, bool wrapped=false)
		{
			object root = null;
			object record = null;
			string rkey = this._rootKey();
			if (obj != null) {
				if (!wrapped) {
					if (rkey != null) {
						root = new System.Collections.Generic.Dictionary<string, object> {};
						(root as System.Collections.Generic.Dictionary<string, object>)[rkey] = obj;
					}
					record = obj;
				}
				else {
					root = obj;
					record = (obj as System.Collections.Generic.Dictionary<string, object>)[rkey];
				}
			}
			this.ApiDeserializeImpl(record);
			this._onAfterApiDeserialize(record, root);
		}
		
		/**
		 * @ignore
		 * @method ApiSerializeImpl
		 * @internal
		 * @param {bool} withClean=false
		 * @return {object}
		 */
		internal virtual object ApiSerializeImpl(bool withClean=false)
		{
			return null;
		}
		
		/**
		 * @ignore
		 * @method ApiSerialize
		 * @param {bool} withClean=false
		 * @return {object}
		 */
		public object ApiSerialize(bool withClean=false)
		{
			object ret = this.ApiSerializeImpl(withClean);
			this._onAfterApiSerialize(ret, withClean);
			return ret;
		}
		
		/**
		 * @ignore
		 * @method ApiSerializeID
		 * @internal
		 * @return {object}
		 */
		internal object ApiSerializeID()
		{
			string id = this._id();
			if (id == null) {
				return null;
			}
			object r = new System.Collections.Generic.Dictionary<string, object> {};
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
			name = name.Substring(0, 1).ToUpper() + name.Substring(1);
			return name;
		}
		
		/**
		 * @ignore
		 * @method SetProperty
		 * @param {string} name
		 * @param {object} value
		 * @return {void}
		 */
		public void SetProperty(string name, object value)
		{
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
			object r = this.ApiSerialize();
			object query = this._query;
			this._query = new System.Collections.Generic.Dictionary<string, object> {};
			System.Collections.Generic.List<string> keys = Util.DictionaryKeys(query);
			for (int __it1=0; __it1 < (keys as System.Collections.IList).Count; __it1++) {
				var k = keys[__it1];
				object v = (query as System.Collections.Generic.Dictionary<string, object>)[k];
				(r as System.Collections.Generic.Dictionary<string, object>)[k] = v;
			}
			this._onBeforeSave(r);
			string method = this.IsNew ? "POST" : "PUT";
			string path = this._apiPath();
			if (!this.IsNew) {
				path += "/" + Util.UrlEncode(this._id());
			}
			object q = new System.Collections.Generic.Dictionary<string, object> {};
			(q as System.Collections.Generic.Dictionary<string, object>)[this._rootKey()] = r;
			object result = this._client.Request(method, path, q);
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
			}
			string path = this._apiPath() + "/" + Util.UrlEncode(this._id());
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
			object result = this._client.Request("GET", this._apiPath() + "/" + Util.UrlEncode(this._id()));
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
			object query = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(query, "Filter.ID", new System.Collections.Generic.List<object> { this._id() });
			Util.SetByPath(query, "Include", new System.Collections.Generic.List<object> { "ID" });
			object result = this._client.Request("GET", this._apiPath(), query);
			return ((long?)((result as System.Collections.Generic.Dictionary<string, object>)["Count"])) == 1;
		}
		
		/**
		 * @ignore
		 * @method Dump
		 * @return {object}
		 */
		public object Dump()
		{
			return this.ApiSerialize(true);
		}
		
	}
	
}
