using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using EScope = Saklient.Cloud.Enums.EScope;

namespace Saklient.Cloud.Resources
{

	/// <summary>アイコンの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Icon : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>スコープ <see cref="Saklient.Cloud.Enums.EScope" />
		/// </summary>
		internal string M_scope;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		/// <summary>URL
		/// </summary>
		internal string M_url;
		
		internal override string _ApiPath()
		{
			return "/icon";
		}
		
		internal override string _RootKey()
		{
			return "Icon";
		}
		
		internal override string _RootKeyM()
		{
			return "Icons";
		}
		
		public override string _ClassName()
		{
			return "Icon";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Icon Save()
		{
			return ((Icon)(this._Save()));
		}
		
		/// <summary>最新のリソース情報を再取得します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Icon Reload()
		{
			return ((Icon)(this._Reload()));
		}
		
		public Icon(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
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
		
		private bool N_scope = false;
		
		private string Get_scope()
		{
			return this.M_scope;
		}
		
		/// <summary>スコープ <see cref="Saklient.Cloud.Enums.EScope" />
		/// </summary>
		public string Scope
		{
			get { return this.Get_scope(); }
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
		
		private bool N_url = false;
		
		private string Get_url()
		{
			return this.M_url;
		}
		
		/// <summary>URL
		/// </summary>
		public string Url
		{
			get { return this.Get_url(); }
		}
		
		/// <summary>(This method is generated in Translator_default#buildImpl)
		/// 
		/// <param name="r" />
		/// </summary>
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
