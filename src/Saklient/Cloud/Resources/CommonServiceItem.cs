using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using CommonServiceProvider = Saklient.Cloud.Resources.CommonServiceProvider;

namespace Saklient.Cloud.Resources
{

	/// <summary>共通サービス契約の実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class CommonServiceItem : Resource
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
		
		/// <summary>タグ文字列の配列
		/// </summary>
		internal System.Collections.Generic.List<string> M_tags;
		
		/// <summary>アイコン
		/// </summary>
		internal Icon M_icon;
		
		/// <summary>共通サービスプロバイダ情報
		/// </summary>
		internal CommonServiceProvider M_provider;
		
		/// <summary>設定の生データ
		/// </summary>
		internal object M_rawSettings;
		
		/// <summary>ステータスの生データ
		/// </summary>
		internal object M_rawStatus;
		
		internal override string _ApiPath()
		{
			return "/commonserviceitem";
		}
		
		internal override string _RootKey()
		{
			return "CommonServiceItem";
		}
		
		internal override string _RootKeyM()
		{
			return "CommonServiceItems";
		}
		
		public override string _ClassName()
		{
			return "CommonServiceItem";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}

        /// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
        /// </summary>
        /// <returns>this</returns>
        public CommonServiceItem Save()
		{
			return ((CommonServiceItem)(this._Save()));
		}

        /// <summary>最新のリソース情報を再取得します。
        /// </summary>
        /// <returns>this</returns>
        public CommonServiceItem Reload()
		{
			return ((CommonServiceItem)(this._Reload()));
		}
		
		public CommonServiceItem(Client client, object obj, bool wrapped=false) : base(client)
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
		
		private bool N_tags = false;
		
		private System.Collections.Generic.List<string> Get_tags()
		{
			this.N_tags = true;
			return this.M_tags;
		}
		
		private System.Collections.Generic.List<string> Set_tags(System.Collections.Generic.List<string> v)
		{
			this.M_tags = v;
			this.N_tags = true;
			return this.M_tags;
		}
		
		/// <summary>タグ文字列の配列
		/// </summary>
		public System.Collections.Generic.List<string> Tags
		{
			get { return this.Get_tags(); }
			set { this.Set_tags(value); }
		}
		
		private bool N_icon = false;
		
		private Icon Get_icon()
		{
			return this.M_icon;
		}
		
		private Icon Set_icon(Icon v)
		{
			this.M_icon = v;
			this.N_icon = true;
			return this.M_icon;
		}
		
		/// <summary>アイコン
		/// </summary>
		public Icon Icon
		{
			get { return this.Get_icon(); }
			set { this.Set_icon(value); }
		}
		
		private bool N_provider = false;
		
		private CommonServiceProvider Get_provider()
		{
			return this.M_provider;
		}
		
		/// <summary>共通サービスプロバイダ情報
		/// </summary>
		public CommonServiceProvider Provider
		{
			get { return this.Get_provider(); }
		}
		
		private bool N_rawSettings = false;
		
		private object Get_rawSettings()
		{
			this.N_rawSettings = true;
			return this.M_rawSettings;
		}
		
		private object Set_rawSettings(object v)
		{
			this.M_rawSettings = v;
			this.N_rawSettings = true;
			return this.M_rawSettings;
		}
		
		/// <summary>設定の生データ
		/// </summary>
		public object RawSettings
		{
			get { return this.Get_rawSettings(); }
			set { this.Set_rawSettings(value); }
		}
		
		private bool N_rawStatus = false;
		
		private object Get_rawStatus()
		{
			return this.M_rawStatus;
		}
		
		/// <summary>ステータスの生データ
		/// </summary>
		public object RawStatus
		{
			get { return this.Get_rawStatus(); }
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
			if (Util.ExistsPath(r, "Description")) {
				this.M_description = Util.GetByPath(r, "Description") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Description");
			}
			else {
				this.M_description = null;
				this.IsIncomplete = true;
			}
			this.N_description = false;
			if (Util.ExistsPath(r, "Tags")) {
				if (Util.GetByPath(r, "Tags") == null) {
					this.M_tags = new System.Collections.Generic.List<string> {  };
				}
				else {
					this.M_tags = new System.Collections.Generic.List<string> {  };
					for (int __it1=0; __it1 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags"))) as System.Collections.IList).Count; __it1++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags")))[__it1];
						string v1 = null;
						v1 = t == null ? ((string)(null)) : "" + t;
						(this.M_tags as System.Collections.IList).Add(v1);
					}
				}
			}
			else {
				this.M_tags = null;
				this.IsIncomplete = true;
			}
			this.N_tags = false;
			if (Util.ExistsPath(r, "Icon")) {
				this.M_icon = Util.GetByPath(r, "Icon") == null ? null : new Icon(this._Client, Util.GetByPath(r, "Icon"));
			}
			else {
				this.M_icon = null;
				this.IsIncomplete = true;
			}
			this.N_icon = false;
			if (Util.ExistsPath(r, "CommonServiceProvider")) {
				this.M_provider = Util.GetByPath(r, "CommonServiceProvider") == null ? null : new CommonServiceProvider(this._Client, Util.GetByPath(r, "CommonServiceProvider"));
			}
			else {
				this.M_provider = null;
				this.IsIncomplete = true;
			}
			this.N_provider = false;
			if (Util.ExistsPath(r, "Settings")) {
				this.M_rawSettings = Util.GetByPath(r, "Settings");
			}
			else {
				this.M_rawSettings = null;
				this.IsIncomplete = true;
			}
			this.N_rawSettings = false;
			if (Util.ExistsPath(r, "Status")) {
				this.M_rawStatus = Util.GetByPath(r, "Status");
			}
			else {
				this.M_rawStatus = null;
				this.IsIncomplete = true;
			}
			this.N_rawStatus = false;
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
			if (withClean || this.N_tags) {
				Util.SetByPath(ret, "Tags", new System.Collections.Generic.List<object> {  });
				for (int __it1=0; __it1 < (this.M_tags as System.Collections.IList).Count; __it1++) {
					var r1 = this.M_tags[__it1];
					object v = null;
					v = r1;
					((ret as System.Collections.Generic.Dictionary<string, object>)["Tags"] as System.Collections.IList).Add(v);
				}
			}
			if (withClean || this.N_icon) {
				Util.SetByPath(ret, "Icon", withClean ? (this.M_icon == null ? ((Icon)(null)) : this.M_icon.ApiSerialize(withClean)) : (this.M_icon == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_icon.ApiSerializeID()));
			}
			if (withClean || this.N_provider) {
				Util.SetByPath(ret, "CommonServiceProvider", withClean ? (this.M_provider == null ? ((CommonServiceProvider)(null)) : this.M_provider.ApiSerialize(withClean)) : (this.M_provider == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_provider.ApiSerializeID()));
			}
			if (withClean || this.N_rawSettings) {
				Util.SetByPath(ret, "Settings", this.M_rawSettings);
			}
			if (withClean || this.N_rawStatus) {
				Util.SetByPath(ret, "Status", this.M_rawStatus);
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the CommonServiceItem creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
