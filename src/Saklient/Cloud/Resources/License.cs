using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using LicenseInfo = Saklient.Cloud.Resources.LicenseInfo;

namespace Saklient.Cloud.Resources
{

	/// <summary>ライセンスの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class License : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		/// <summary>ライセンス種別情報
		/// </summary>
		internal LicenseInfo M_info;
		
		internal override string _ApiPath()
		{
			return "/license";
		}
		
		internal override string _RootKey()
		{
			return "License";
		}
		
		internal override string _RootKeyM()
		{
			return "Licenses";
		}
		
		public override string _ClassName()
		{
			return "License";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}

        /// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
        /// </summary>
        /// <returns>this</returns>
        public License Save()
		{
			return ((License)(this._Save()));
		}

        /// <summary>最新のリソース情報を再取得します。
        /// </summary>
        /// <returns>this</returns>
        public License Reload()
		{
			return ((License)(this._Reload()));
		}
		
		public License(Client client, object obj, bool wrapped=false) : base(client)
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
		
		private bool N_info = false;
		
		private LicenseInfo Get_info()
		{
			return this.M_info;
		}
		
		private LicenseInfo Set_info(LicenseInfo v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.License#Set_info");
			}
			this.M_info = v;
			this.N_info = true;
			return this.M_info;
		}
		
		/// <summary>ライセンス種別情報
		/// </summary>
		public LicenseInfo Info
		{
			get { return this.Get_info(); }
			set { this.Set_info(value); }
		}

        /// <summary>(This method is generated in Translator_default#buildImpl)
        /// </summary>
        /// <param name="r" />
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
			if (Util.ExistsPath(r, "LicenseInfo")) {
				this.M_info = Util.GetByPath(r, "LicenseInfo") == null ? null : new LicenseInfo(this._Client, Util.GetByPath(r, "LicenseInfo"));
			}
			else {
				this.M_info = null;
				this.IsIncomplete = true;
			}
			this.N_info = false;
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
			if (withClean || this.N_info) {
				Util.SetByPath(ret, "LicenseInfo", withClean ? (this.M_info == null ? ((LicenseInfo)(null)) : this.M_info.ApiSerialize(withClean)) : (this.M_info == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_info.ApiSerializeID()));
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("info");
				}
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the License creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
