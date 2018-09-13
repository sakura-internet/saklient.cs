using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Cloud.Resources
{

	/// <summary>
	/// 
	/// </summary>
	public class Resource
	{
		
		internal Client _Client;
		
		internal Client Get_client()
		{
			return this._Client;
		}
		
		public Client Client
		{
			get { return this.Get_client(); }
		}
		
		internal object _Query;
		
		public void SetParam(string key, object value)
		{
			(this._Query as System.Collections.Generic.Dictionary<string, object>)[key] = value;
		}
		
		internal virtual string _ApiPath()
		{
			return null;
		}
		
		internal virtual string _RootKey()
		{
			return null;
		}
		
		internal virtual string _RootKeyM()
		{
			return null;
		}
		
		public virtual string _ClassName()
		{
			return null;
		}
		
		public virtual string _Id()
		{
			return null;
		}
		
		public Resource(Client client)
		{
			this._Client = client;
			this._Query = new System.Collections.Generic.Dictionary<string, object> {};
		}
		
		internal bool IsNew;
		
		internal bool IsIncomplete;
		
		internal virtual void _OnBeforeSave(object query)
		{
			
		}
		
		internal virtual void _OnBeforeApiDeserialize(object r, object root)
		{
			
		}
		
		internal virtual void _OnAfterApiDeserialize(object r, object root)
		{
			
		}
		
		internal virtual void _OnBeforeApiSerialize(bool withClean)
		{
			
		}
		
		internal virtual void _OnAfterApiSerialize(object r, bool withClean)
		{
			
		}
		
		internal virtual void ApiDeserializeImpl(object r)
		{
			
		}
		
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
			this._OnBeforeApiDeserialize(record, root);
			this.ApiDeserializeImpl(record);
			this._OnAfterApiDeserialize(record, root);
		}
		
		internal virtual object ApiSerializeImpl(bool withClean=false)
		{
			return null;
		}
		
		public object ApiSerialize(bool withClean=false)
		{
			this._OnBeforeApiSerialize(withClean);
			object ret = this.ApiSerializeImpl(withClean);
			this._OnAfterApiSerialize(ret, withClean);
			return ret;
		}
		
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
		
		internal string NormalizeFieldName(string name)
		{
			name = name.Substring(0, 1).ToUpper() + name.Substring(1);
			return name;
		}
		
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
			string method = this.IsNew ? "POST" : "PUT";
			string path = this._ApiPath();
			if (!this.IsNew) {
				path += "/" + Util.UrlEncode(this._Id());
			}
			object q = new System.Collections.Generic.Dictionary<string, object> {};
			(q as System.Collections.Generic.Dictionary<string, object>)[this._RootKey()] = r;
			this._OnBeforeSave(q);
			object result = this._Client.Request(method, path, q);
			this.ApiDeserialize(result, true);
			return this;
		}
		
		/// <summary>このローカルオブジェクトのIDと一致するリソースの削除リクエストをAPIに送信します。
		/// </summary>
		public void Destroy()
		{
			if (this.IsNew) {
				return;
			}
			string path = this._ApiPath() + "/" + Util.UrlEncode(this._Id());
			this.RequestRetry("DELETE", path);
		}
		
		internal Resource _Reload()
		{
			string id = this._Id();
			if (id != null) {
				object result = this.RequestRetry("GET", this._ApiPath() + "/" + Util.UrlEncode(id));
				this.ApiDeserialize(result, true);
			}
			return this;
		}
		
		/// <summary>このリソースが存在するかを調べます。
		/// </summary>
		public bool Exists()
		{
			object query = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(query, "Filter.ID", new System.Collections.Generic.List<object> { this._Id() });
			Util.SetByPath(query, "Include", new System.Collections.Generic.List<string> { "ID" });
			object result = this.RequestRetry("GET", this._ApiPath(), query);
			object cnt = (result as System.Collections.Generic.Dictionary<string, object>)["Count"];
			return System.Convert.ToInt64(cnt) == 1;
		}
		
		public object Dump()
		{
			return this.ApiSerialize(true);
		}
		
		public static Resource CreateWith(string className, Client client, object obj, bool wrapped=false)
		{
			System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { client, obj, wrapped };
			return ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + className, a)));
		}

        /// <summary>
        /// </summary>
        /// <param name="method" />
        /// <param name="path" />
        /// <param name="query" />
        /// <param name="retryCount" />
        /// <param name="retrySleep" />
        public object RequestRetry(string method, string path, object query=null, long retryCount=5, long retrySleep=5)
		{
			object ret = null;
			while (1 < retryCount) {
				bool isOk = false;
				try {
					ret = this._Client.Request(method, path, query);
					isOk = true;
				}
				catch (HttpException ex) {
					isOk = false;
				}
				if (isOk) {
					retryCount = -1;
				}
				else {
					retryCount -= 1;
					Util.Sleep(retrySleep);
				}
			}
			if (retryCount == 0) {
				ret = this._Client.Request(method, path, query);
			}
			return ret;
		}
		
	}
	
}
