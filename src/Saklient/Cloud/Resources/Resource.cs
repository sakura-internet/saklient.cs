using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;

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
		
		internal virtual void _OnAfterApiDeserialize(object r, object root)
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
			this.ApiDeserializeImpl(record);
			this._OnAfterApiDeserialize(record, root);
		}
		
		internal virtual object ApiSerializeImpl(bool withClean=false)
		{
			return null;
		}
		
		public object ApiSerialize(bool withClean=false)
		{
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
		
		public object GetProperty(string name)
		{
			name = this.NormalizeFieldName(name);
			System.Reflection.PropertyInfo prop = this.GetType().GetProperty("M_"+name);
			return prop.GetValue(this, null);
		}
		
		public void SetProperty(string name, object value)
		{
			name = this.NormalizeFieldName(name);
			System.Reflection.PropertyInfo prop = this.GetType().GetProperty("M_"+name);
			prop.SetValue(this, System.Convert.ChangeType(value, prop.PropertyType), null);
			prop = this.GetType().GetProperty("N_"+name);
			prop.SetValue(this, System.Convert.ChangeType(true, prop.PropertyType), null);
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
			this._Client.Request("DELETE", path);
		}
		
		internal Resource _Reload()
		{
			object result = this._Client.Request("GET", this._ApiPath() + "/" + Util.UrlEncode(this._Id()));
			this.ApiDeserialize(result, true);
			return this;
		}
		
		/// <summary>このリソースが存在するかを調べます。
		/// </summary>
		public bool Exists()
		{
			object query = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(query, "Filter.ID", new System.Collections.Generic.List<object> { this._Id() });
			Util.SetByPath(query, "Include", new System.Collections.Generic.List<object> { "ID" });
			object result = this._Client.Request("GET", this._ApiPath(), query);
			object cnt = (result as System.Collections.Generic.Dictionary<string, object>)["Count"];
			return System.Convert.ToInt64(cnt) == 1;
		}
		
		public object Dump()
		{
			return this.ApiSerialize(true);
		}
		
		public virtual string TrueClassName()
		{
			return null;
		}
		
		public static Resource CreateWith(string className, Client client, object obj, bool wrapped=false)
		{
			System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { client, obj, wrapped };
			Resource ret = ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + className, a)));
			string trueClassName = ret.TrueClassName();
			if (trueClassName != null) {
				ret = ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + trueClassName, a)));
			}
			return ret;
		}
		
	}
	
}
