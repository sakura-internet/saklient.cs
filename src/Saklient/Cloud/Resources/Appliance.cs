using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using Iface = Saklient.Cloud.Resources.Iface;
using EApplianceClass = Saklient.Cloud.Enums.EApplianceClass;

namespace Saklient.Cloud.Resources
{

	/// <summary>アプライアンスの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Appliance : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>クラス <see cref="Saklient.Cloud.Enums.EApplianceClass" />
		/// </summary>
		internal string M_clazz;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		/// <summary>説明
		/// </summary>
		internal string M_description;
		
		/// <summary>タグ
		/// </summary>
		internal System.Collections.Generic.List<string> M_tags;
		
		/// <summary>アイコン
		/// </summary>
		internal Icon M_icon;
		
		/// <summary>プラン
		/// </summary>
		internal System.Collections.Generic.List<Iface> M_ifaces;
		
		/// <summary>注釈
		/// </summary>
		internal object M_annotation;
		
		/// <summary>設定の生データ
		/// </summary>
		internal object M_rawSettings;
		
		internal string M_rawSettingsHash;
		
		/// <summary>サービスクラス
		/// </summary>
		internal string M_serviceClass;
		
		internal override string _ApiPath()
		{
			return "/appliance";
		}
		
		internal override string _RootKey()
		{
			return "Appliance";
		}
		
		internal override string _RootKeyM()
		{
			return "Appliances";
		}
		
		public override string _ClassName()
		{
			return "Appliance";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Appliance Save()
		{
			return ((Appliance)(this._Save()));
		}
		
		/// <summary>最新のリソース情報を再取得します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Appliance Reload()
		{
			return ((Appliance)(this._Reload()));
		}
		
		public override string TrueClassName()
		{
			switch (this.Get_clazz()) {
				case "loadbalancer": {
					return "LoadBalancer";
				}
				case "vpcrouter": {
					return "VpcRouter";
				}
			}
			
			return null;
		}
		
		public Appliance(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		internal override void _OnBeforeSave(object query)
		{
			Util.SetByPath(query, "OriginalSettingsHash", this.Get_rawSettingsHash());
		}
		
		/// <summary>アプライアンスを起動します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Appliance Boot()
		{
			this._Client.Request("PUT", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/power");
			return this;
		}
		
		/// <summary>アプライアンスをシャットダウンします。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Appliance Shutdown()
		{
			this._Client.Request("DELETE", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/power");
			return this;
		}
		
		/// <summary>アプライアンスを強制停止します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Appliance Stop()
		{
			this._Client.Request("DELETE", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/power", new System.Collections.Generic.Dictionary<string, object> { { "Force", true } });
			return this;
		}
		
		/// <summary>アプライアンスを強制再起動します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Appliance Reboot()
		{
			this._Client.Request("PUT", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/reset");
			return this;
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
		
		private bool N_clazz = false;
		
		private string Get_clazz()
		{
			return this.M_clazz;
		}
		
		private string Set_clazz(string v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Appliance#Set_clazz");
			}
			this.M_clazz = v;
			this.N_clazz = true;
			return this.M_clazz;
		}
		
		/// <summary>クラス <see cref="Saklient.Cloud.Enums.EApplianceClass" />
		/// </summary>
		public string Clazz
		{
			get { return this.Get_clazz(); }
			set { this.Set_clazz(value); }
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
		
		/// <summary>タグ
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
		
		private bool N_ifaces = false;
		
		private System.Collections.Generic.List<Iface> Get_ifaces()
		{
			return this.M_ifaces;
		}
		
		/// <summary>プラン
		/// </summary>
		public System.Collections.Generic.List<Iface> Ifaces
		{
			get { return this.Get_ifaces(); }
		}
		
		private bool N_annotation = false;
		
		private object Get_annotation()
		{
			return this.M_annotation;
		}
		
		/// <summary>注釈
		/// </summary>
		public object Annotation
		{
			get { return this.Get_annotation(); }
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
		
		private bool N_rawSettingsHash = false;
		
		private string Get_rawSettingsHash()
		{
			return this.M_rawSettingsHash;
		}
		
		public string RawSettingsHash
		{
			get { return this.Get_rawSettingsHash(); }
		}
		
		private bool N_serviceClass = false;
		
		private string Get_serviceClass()
		{
			return this.M_serviceClass;
		}
		
		/// <summary>サービスクラス
		/// </summary>
		public string ServiceClass
		{
			get { return this.Get_serviceClass(); }
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
			if (Util.ExistsPath(r, "Class")) {
				this.M_clazz = Util.GetByPath(r, "Class") == null ? null : "" + Util.GetByPath(r, "Class");
			}
			else {
				this.M_clazz = null;
				this.IsIncomplete = true;
			}
			this.N_clazz = false;
			if (Util.ExistsPath(r, "Name")) {
				this.M_name = Util.GetByPath(r, "Name") == null ? null : "" + Util.GetByPath(r, "Name");
			}
			else {
				this.M_name = null;
				this.IsIncomplete = true;
			}
			this.N_name = false;
			if (Util.ExistsPath(r, "Description")) {
				this.M_description = Util.GetByPath(r, "Description") == null ? null : "" + Util.GetByPath(r, "Description");
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
						v1 = t == null ? null : "" + t;
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
			if (Util.ExistsPath(r, "Interfaces")) {
				if (Util.GetByPath(r, "Interfaces") == null) {
					this.M_ifaces = new System.Collections.Generic.List<Iface> {  };
				}
				else {
					this.M_ifaces = new System.Collections.Generic.List<Iface> {  };
					for (int __it2=0; __it2 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Interfaces"))) as System.Collections.IList).Count; __it2++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Interfaces")))[__it2];
						Iface v2 = null;
						v2 = t == null ? null : new Iface(this._Client, t);
						(this.M_ifaces as System.Collections.IList).Add(v2);
					}
				}
			}
			else {
				this.M_ifaces = null;
				this.IsIncomplete = true;
			}
			this.N_ifaces = false;
			if (Util.ExistsPath(r, "Remark")) {
				this.M_annotation = Util.GetByPath(r, "Remark");
			}
			else {
				this.M_annotation = null;
				this.IsIncomplete = true;
			}
			this.N_annotation = false;
			if (Util.ExistsPath(r, "Settings")) {
				this.M_rawSettings = Util.GetByPath(r, "Settings");
			}
			else {
				this.M_rawSettings = null;
				this.IsIncomplete = true;
			}
			this.N_rawSettings = false;
			if (Util.ExistsPath(r, "SettingsHash")) {
				this.M_rawSettingsHash = Util.GetByPath(r, "SettingsHash") == null ? null : "" + Util.GetByPath(r, "SettingsHash");
			}
			else {
				this.M_rawSettingsHash = null;
				this.IsIncomplete = true;
			}
			this.N_rawSettingsHash = false;
			if (Util.ExistsPath(r, "ServiceClass")) {
				this.M_serviceClass = Util.GetByPath(r, "ServiceClass") == null ? null : "" + Util.GetByPath(r, "ServiceClass");
			}
			else {
				this.M_serviceClass = null;
				this.IsIncomplete = true;
			}
			this.N_serviceClass = false;
		}
		
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			System.Collections.Generic.List<string> missing = new System.Collections.Generic.List<string> {  };
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_clazz) {
				Util.SetByPath(ret, "Class", this.M_clazz);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("clazz");
				}
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
				Util.SetByPath(ret, "Icon", withClean ? (this.M_icon == null ? null : this.M_icon.ApiSerialize(withClean)) : (this.M_icon == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_icon.ApiSerializeID()));
			}
			if (withClean || this.N_ifaces) {
				Util.SetByPath(ret, "Interfaces", new System.Collections.Generic.List<object> {  });
				for (int __it2=0; __it2 < (this.M_ifaces as System.Collections.IList).Count; __it2++) {
					var r2 = this.M_ifaces[__it2];
					object v = null;
					v = withClean ? (r2 == null ? null : r2.ApiSerialize(withClean)) : (r2 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r2.ApiSerializeID());
					((ret as System.Collections.Generic.Dictionary<string, object>)["Interfaces"] as System.Collections.IList).Add(v);
				}
			}
			if (withClean || this.N_annotation) {
				Util.SetByPath(ret, "Remark", this.M_annotation);
			}
			if (withClean || this.N_rawSettings) {
				Util.SetByPath(ret, "Settings", this.M_rawSettings);
			}
			if (withClean || this.N_rawSettingsHash) {
				Util.SetByPath(ret, "SettingsHash", this.M_rawSettingsHash);
			}
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Appliance creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
