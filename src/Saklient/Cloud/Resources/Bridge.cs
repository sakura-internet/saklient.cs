using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Region = Saklient.Cloud.Resources.Region;

namespace Saklient.Cloud.Resources
{

	/// <summary>ブリッジの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Bridge : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		/// <summary>説明
		/// </summary>
		internal string M_description;
		
		/// <summary>リージョン
		/// </summary>
		internal Region M_region;
		
		internal override string _ApiPath()
		{
			return "/bridge";
		}
		
		internal override string _RootKey()
		{
			return "Bridge";
		}
		
		internal override string _RootKeyM()
		{
			return "Bridges";
		}
		
		public override string _ClassName()
		{
			return "Bridge";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Bridge Save()
		{
			return ((Bridge)(this._Save()));
		}
		
		/// <summary>最新のリソース情報を再取得します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Bridge Reload()
		{
			return ((Bridge)(this._Reload()));
		}
		
		public Bridge(Client client, object obj, bool wrapped=false) : base(client)
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
		
		private bool N_description = false;
		
		private string Get_description()
		{
			return this.M_description;
		}
		
		private string Set_description(string v)
		{
			this.M_description = v;
			this.N_description = true;
			return this.M_description;
		}
		
		/// <summary>説明
		/// </summary>
		public string Description
		{
			get { return this.Get_description(); }
			set { this.Set_description(value); }
		}
		
		private bool N_region = false;
		
		private Region Get_region()
		{
			return this.M_region;
		}
		
		private Region Set_region(Region v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Bridge#Set_region");
			}
			this.M_region = v;
			this.N_region = true;
			return this.M_region;
		}
		
		/// <summary>リージョン
		/// </summary>
		public Region Region
		{
			get { return this.Get_region(); }
			set { this.Set_region(value); }
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
				this.M_id = Util.GetByPath(r, "ID") == null ? ((string)(null)) : "" + Util.GetByPath(r, "ID");
			}
			else {
				this.M_id = null;
				this.IsIncomplete = true;
			}
			this.N_id = false;
			if (Util.ExistsPath(r, "Name")) {
				this.M_name = Util.GetByPath(r, "Name") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Name");
			}
			else {
				this.M_name = null;
				this.IsIncomplete = true;
			}
			this.N_name = false;
			if (Util.ExistsPath(r, "Description")) {
				this.M_description = Util.GetByPath(r, "Description") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Description");
			}
			else {
				this.M_description = null;
				this.IsIncomplete = true;
			}
			this.N_description = false;
			if (Util.ExistsPath(r, "Region")) {
				this.M_region = Util.GetByPath(r, "Region") == null ? null : new Region(this._Client, Util.GetByPath(r, "Region"));
			}
			else {
				this.M_region = null;
				this.IsIncomplete = true;
			}
			this.N_region = false;
		}
		
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			System.Collections.Generic.List<string> missing = new System.Collections.Generic.List<string> {  };
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_name) {
				Util.SetByPath(ret, "Name", this.M_name);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("name");
				}
			}
			if (withClean || this.N_description) {
				Util.SetByPath(ret, "Description", this.M_description);
			}
			if (withClean || this.N_region) {
				Util.SetByPath(ret, "Region", withClean ? (this.M_region == null ? ((Region)(null)) : this.M_region.ApiSerialize(withClean)) : (this.M_region == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_region.ApiSerializeID()));
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("region");
				}
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Bridge creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
