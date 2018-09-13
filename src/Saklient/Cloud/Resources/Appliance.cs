using Util = Saklient.Util;
using HttpException = Saklient.Errors.HttpException;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using Iface = Saklient.Cloud.Resources.Iface;
using Swytch = Saklient.Cloud.Resources.Swytch;
using EApplianceClass = Saklient.Cloud.Enums.EApplianceClass;
using EAvailability = Saklient.Cloud.Enums.EAvailability;
using EServerInstanceStatus = Saklient.Cloud.Enums.EServerInstanceStatus;
using Model_Swytch = Saklient.Cloud.Models.Model_Swytch;

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
		
		/// <summary>タグ文字列の配列
		/// </summary>
		internal System.Collections.Generic.List<string> M_tags;
		
		/// <summary>アイコン
		/// </summary>
		internal Icon M_icon;
		
		/// <summary>プラン
		/// </summary>
		internal long? M_planId;
		
		/// <summary>インタフェース <see cref="Saklient.Cloud.Resources.Iface" /> の配列
		/// </summary>
		internal System.Collections.Generic.List<Iface> M_ifaces;
		
		/// <summary>注釈
		/// </summary>
		internal object M_rawAnnotation;
		
		/// <summary>設定の生データ
		/// </summary>
		internal object M_rawSettings;
		
		internal string M_rawSettingsHash;
		
		/// <summary>起動状態 <see cref="Saklient.Cloud.Enums.EServerInstanceStatus" />
		/// </summary>
		internal string M_status;
		
		/// <summary>サービスクラス
		/// </summary>
		internal string M_serviceClass;
		
		/// <summary>有効状態 <see cref="Saklient.Cloud.Enums.EAvailability" />
		/// </summary>
		internal string M_availability;
		
		/// <summary>接続先スイッチID
		/// </summary>
		internal string M_swytchId;
		
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
        /// </summary>
        /// <returns>this</returns>
        public Appliance Save()
		{
			return ((Appliance)(this._Save()));
		}

        /// <summary>最新のリソース情報を再取得します。
        /// </summary>
        /// <returns>this</returns>
        public Appliance Reload()
		{
			return ((Appliance)(this._Reload()));
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
		
		/// <summary>このルータが接続されているスイッチを取得します。
		/// </summary>
		public Swytch GetSwytch()
		{
			Model_Swytch model = new Model_Swytch(this._Client);
			string id = this.Get_swytchId();
			return model.GetById(id);
		}

        /// <summary>アプライアンスの設定を反映します。
        /// </summary>
        /// <returns>this</returns>
        public Appliance Apply()
		{
			this._Client.Request("PUT", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/config");
			return this;
		}

        /// <summary>アプライアンスを起動します。
        /// </summary>
        /// <returns>this</returns>
        public Appliance Boot()
		{
			this._Client.Request("PUT", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/power");
			return this;
		}

        /// <summary>アプライアンスをシャットダウンします。
        /// </summary>
        /// <returns>this</returns>
        public Appliance Shutdown()
		{
			this._Client.Request("DELETE", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/power");
			return this;
		}

        /// <summary>アプライアンスを強制停止します。
        /// </summary>
        /// <returns>this</returns>
        public Appliance Stop()
		{
			this._Client.Request("DELETE", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/power", new System.Collections.Generic.Dictionary<string, object> { { "Force", true } });
			return this;
		}

        /// <summary>アプライアンスを強制再起動します。
        /// </summary>
        /// <returns>this</returns>
        public Appliance Reboot()
		{
			this._Client.Request("PUT", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/reset");
			return this;
		}

        /// <summary>作成中のアプライアンスが利用可能になるまで待機します。
        /// </summary>
        /// <param name="timeoutSec" />
        /// <returns>成功時はtrue、タイムアウトやエラーによる失敗時はfalseを返します。</returns>
        public bool SleepWhileCreating(long timeoutSec=600)
		{
			long step = 10;
			while (0 < timeoutSec) {
				try {
					this.Reload();
				}
				catch (HttpException ex) {
					
				}
				string a = this.Get_availability();
				if (a == EAvailability.AVAILABLE) {
					return true;
				}
				if (a != EAvailability.MIGRATING) {
					timeoutSec = 0;
				}
				timeoutSec -= step;
				if (0 < timeoutSec) {
					Util.Sleep(step);
				}
			}
			return false;
		}

        /// <summary>アプライアンスが起動するまで待機します。
        /// </summary>
        /// <param name="timeoutSec" />
        public bool SleepUntilUp(long timeoutSec=600)
		{
			return this.SleepUntil(EServerInstanceStatus.UP, timeoutSec);
		}

        /// <summary>アプライアンスが停止するまで待機します。
        /// </summary>
        /// <param name="timeoutSec" />
        /// <returns>成功時はtrue、タイムアウトやエラーによる失敗時はfalseを返します。</returns>
        public bool SleepUntilDown(long timeoutSec=600)
		{
			return this.SleepUntil(EServerInstanceStatus.DOWN, timeoutSec);
		}

        /// <summary>アプライアンスが指定のステータスに遷移するまで待機します。
        /// </summary>
        /// <param name="status" />
        /// <param name="timeoutSec" />
        private bool SleepUntil(string status, long timeoutSec=600)
		{
			long step = 10;
			while (0 < timeoutSec) {
				try {
					this.Reload();
				}
				catch (HttpException ex) {
					
				}
				string s = this.Get_status();
				if (s == null) {
					s = EServerInstanceStatus.DOWN;
				}
				if (s == status) {
					return true;
				}
				timeoutSec -= step;
				if (0 < timeoutSec) {
					Util.Sleep(step);
				}
			}
			return false;
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
		
		private bool N_planId = false;
		
		private long? Get_planId()
		{
			return this.M_planId;
		}
		
		private long? Set_planId(long? v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Appliance#Set_planId");
			}
			this.M_planId = v;
			this.N_planId = true;
			return this.M_planId;
		}
		
		/// <summary>プラン
		/// </summary>
		public long? PlanId
		{
			get { return this.Get_planId(); }
			set { this.Set_planId(value); }
		}
		
		private bool N_ifaces = false;
		
		private System.Collections.Generic.List<Iface> Get_ifaces()
		{
			return this.M_ifaces;
		}
		
		/// <summary>インタフェース <see cref="Saklient.Cloud.Resources.Iface" /> の配列
		/// </summary>
		public System.Collections.Generic.List<Iface> Ifaces
		{
			get { return this.Get_ifaces(); }
		}
		
		private bool N_rawAnnotation = false;
		
		private object Get_rawAnnotation()
		{
			return this.M_rawAnnotation;
		}
		
		private object Set_rawAnnotation(object v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Appliance#Set_rawAnnotation");
			}
			this.M_rawAnnotation = v;
			this.N_rawAnnotation = true;
			return this.M_rawAnnotation;
		}
		
		/// <summary>注釈
		/// </summary>
		public object RawAnnotation
		{
			get { return this.Get_rawAnnotation(); }
			set { this.Set_rawAnnotation(value); }
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
		
		private bool N_status = false;
		
		private string Get_status()
		{
			return this.M_status;
		}
		
		/// <summary>起動状態 <see cref="Saklient.Cloud.Enums.EServerInstanceStatus" />
		/// </summary>
		public string Status
		{
			get { return this.Get_status(); }
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
		
		private bool N_availability = false;
		
		private string Get_availability()
		{
			return this.M_availability;
		}
		
		/// <summary>有効状態 <see cref="Saklient.Cloud.Enums.EAvailability" />
		/// </summary>
		public string Availability
		{
			get { return this.Get_availability(); }
		}
		
		private bool N_swytchId = false;
		
		private string Get_swytchId()
		{
			return this.M_swytchId;
		}
		
		/// <summary>接続先スイッチID
		/// </summary>
		public string SwytchId
		{
			get { return this.Get_swytchId(); }
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
			if (Util.ExistsPath(r, "Class")) {
				this.M_clazz = Util.GetByPath(r, "Class") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Class");
			}
			else {
				this.M_clazz = null;
				this.IsIncomplete = true;
			}
			this.N_clazz = false;
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
			if (Util.ExistsPath(r, "Plan.ID")) {
				this.M_planId = Util.GetByPath(r, "Plan.ID") == null ? System.Convert.ToInt64(null) : (long)System.Convert.ToInt64(""+"" + Util.GetByPath(r, "Plan.ID"));
			}
			else {
				this.M_planId = null;
				this.IsIncomplete = true;
			}
			this.N_planId = false;
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
				this.M_rawAnnotation = Util.GetByPath(r, "Remark");
			}
			else {
				this.M_rawAnnotation = null;
				this.IsIncomplete = true;
			}
			this.N_rawAnnotation = false;
			if (Util.ExistsPath(r, "Settings")) {
				this.M_rawSettings = Util.GetByPath(r, "Settings");
			}
			else {
				this.M_rawSettings = null;
				this.IsIncomplete = true;
			}
			this.N_rawSettings = false;
			if (Util.ExistsPath(r, "SettingsHash")) {
				this.M_rawSettingsHash = Util.GetByPath(r, "SettingsHash") == null ? ((string)(null)) : "" + Util.GetByPath(r, "SettingsHash");
			}
			else {
				this.M_rawSettingsHash = null;
				this.IsIncomplete = true;
			}
			this.N_rawSettingsHash = false;
			if (Util.ExistsPath(r, "Instance.Status")) {
				this.M_status = Util.GetByPath(r, "Instance.Status") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Instance.Status");
			}
			else {
				this.M_status = null;
				this.IsIncomplete = true;
			}
			this.N_status = false;
			if (Util.ExistsPath(r, "ServiceClass")) {
				this.M_serviceClass = Util.GetByPath(r, "ServiceClass") == null ? ((string)(null)) : "" + Util.GetByPath(r, "ServiceClass");
			}
			else {
				this.M_serviceClass = null;
				this.IsIncomplete = true;
			}
			this.N_serviceClass = false;
			if (Util.ExistsPath(r, "Availability")) {
				this.M_availability = Util.GetByPath(r, "Availability") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Availability");
			}
			else {
				this.M_availability = null;
				this.IsIncomplete = true;
			}
			this.N_availability = false;
			if (Util.ExistsPath(r, "Switch.ID")) {
				this.M_swytchId = Util.GetByPath(r, "Switch.ID") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Switch.ID");
			}
			else {
				this.M_swytchId = null;
				this.IsIncomplete = true;
			}
			this.N_swytchId = false;
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
				Util.SetByPath(ret, "Icon", withClean ? (this.M_icon == null ? ((Icon)(null)) : this.M_icon.ApiSerialize(withClean)) : (this.M_icon == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_icon.ApiSerializeID()));
			}
			if (withClean || this.N_planId) {
				Util.SetByPath(ret, "Plan.ID", this.M_planId);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("planId");
				}
			}
			if (withClean || this.N_ifaces) {
				Util.SetByPath(ret, "Interfaces", new System.Collections.Generic.List<object> {  });
				for (int __it2=0; __it2 < (this.M_ifaces as System.Collections.IList).Count; __it2++) {
					var r2 = this.M_ifaces[__it2];
					object v = null;
					v = withClean ? (r2 == null ? ((Iface)(null)) : r2.ApiSerialize(withClean)) : (r2 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r2.ApiSerializeID());
					((ret as System.Collections.Generic.Dictionary<string, object>)["Interfaces"] as System.Collections.IList).Add(v);
				}
			}
			if (withClean || this.N_rawAnnotation) {
				Util.SetByPath(ret, "Remark", this.M_rawAnnotation);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("rawAnnotation");
				}
			}
			if (withClean || this.N_rawSettings) {
				Util.SetByPath(ret, "Settings", this.M_rawSettings);
			}
			if (withClean || this.N_rawSettingsHash) {
				Util.SetByPath(ret, "SettingsHash", this.M_rawSettingsHash);
			}
			if (withClean || this.N_status) {
				Util.SetByPath(ret, "Instance.Status", this.M_status);
			}
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			}
			if (withClean || this.N_availability) {
				Util.SetByPath(ret, "Availability", this.M_availability);
			}
			if (withClean || this.N_swytchId) {
				Util.SetByPath(ret, "Switch.ID", this.M_swytchId);
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Appliance creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
