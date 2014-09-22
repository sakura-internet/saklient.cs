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
		 * @member saklient.cloud.resources.Resource#_Client
		 * @type Client
		 * @internal
		 * @ignore
		 */
		internal Client _Client;
		
		/**
		 * @method Get_client
		 * @internal
		 * @ignore
		 * @return {Client}
		 */
		internal Client Get_client()
		{
			return this._Client;
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
		 * @member saklient.cloud.resources.Resource#_Query
		 * @type object
		 * @internal
		 * @ignore
		 */
		internal object _Query;
		
		/**
		 * @ignore
		 * @method SetParam
		 * @param {string} key
		 * @param {object} value
		 * @return {void}
		 */
		public void SetParam(string key, object value)
		{
			(this._Query as System.Collections.Generic.Dictionary<string, object>)[key] = value;
		}
		
		/**
		 * @private
		 * @method _ApiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _ApiPath()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _RootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _RootKey()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _RootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _RootKeyM()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _ClassName
		 * @ignore
		 * @return {string}
		 */
		public virtual string _ClassName()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _Id
		 * @ignore
		 * @return {string}
		 */
		public virtual string _Id()
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
			this._Client = client;
			this._Query = new System.Collections.Generic.Dictionary<string, object> {};
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
		 * @method _OnBeforeSave
		 * @internal
		 * @ignore
		 * @param {object} r
		 * @return {void}
		 */
		internal virtual void _OnBeforeSave(object r)
		{
			
		}
		
		/**
		 * @private
		 * @method _OnAfterApiDeserialize
		 * @internal
		 * @ignore
		 * @param {object} r
		 * @param {object} root
		 * @return {void}
		 */
		internal virtual void _OnAfterApiDeserialize(object r, object root)
		{
			
		}
		
		/**
		 * @private
		 * @method _OnAfterApiSerialize
		 * @internal
		 * @ignore
		 * @param {object} r
		 * @param {bool} withClean
		 * @return {void}
		 */
		internal virtual void _OnAfterApiSerialize(object r, bool withClean)
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
			string rkey = this._RootKey();
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
			this._OnAfterApiDeserialize(record, root);
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
			this._OnAfterApiSerialize(ret, withClean);
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
			string id = this._Id();
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
		 * @method _Save
		 * @chainable
		 * @internal
		 * @ignore
		 * @return {Resource} this
		 */
		internal Resource _Save()
		{
			object r = this.ApiSerialize();
			object query = this._Query;
			this._Query = new System.Collections.Generic.Dictionary<string, object> {};
			System.Collections.Generic.List<string> keys = Util.DictionaryKeys(query);
			for (int __it1=0; __it1 < (keys as System.Collections.IList).Count; __it1++) {
				var k = keys[__it1];
				object v = (query as System.Collections.Generic.Dictionary<string, object>)[k];
				(r as System.Collections.Generic.Dictionary<string, object>)[k] = v;
			}
			this._OnBeforeSave(r);
			string method = this.IsNew ? "POST" : "PUT";
			string path = this._ApiPath();
			if (!this.IsNew) {
				path += "/" + Util.UrlEncode(this._Id());
			}
			object q = new System.Collections.Generic.Dictionary<string, object> {};
			(q as System.Collections.Generic.Dictionary<string, object>)[this._RootKey()] = r;
			object result = this._Client.Request(method, path, q);
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
			string path = this._ApiPath() + "/" + Util.UrlEncode(this._Id());
			this._Client.Request("DELETE", path);
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @private
		 * @method _Reload
		 * @chainable
		 * @internal
		 * @ignore
		 * @return {Resource} this
		 */
		internal Resource _Reload()
		{
			object result = this._Client.Request("GET", this._ApiPath() + "/" + Util.UrlEncode(this._Id()));
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
			Util.SetByPath(query, "Filter.ID", new System.Collections.Generic.List<object> { this._Id() });
			Util.SetByPath(query, "Include", new System.Collections.Generic.List<object> { "ID" });
			object result = this._Client.Request("GET", this._ApiPath(), query);
			object cnt = (result as System.Collections.Generic.Dictionary<string, object>)["Count"];
			return System.Convert.ToInt64(cnt) == 1;
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
