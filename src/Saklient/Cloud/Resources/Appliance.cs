using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using Iface = Saklient.Cloud.Resources.Iface;
using EApplianceClass = Saklient.Cloud.Enums.EApplianceClass;

namespace Saklient.Cloud.Resources
{

	/**
	 * アプライアンスの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Appliance
	 * @class Appliance
	 * @constructor
	 * @extends Resource
	 */
	class Appliance : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Appliance#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * クラス {@link EApplianceClass}
		 * 
		 * @member saklient.cloud.resources.Appliance#M_clazz
		 * @type string
		 * @internal
		 */
		internal string M_clazz;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.Appliance#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * 説明
		 * 
		 * @member saklient.cloud.resources.Appliance#M_description
		 * @type string
		 * @internal
		 */
		internal string M_description;
		
		/**
		 * タグ
		 * 
		 * @member saklient.cloud.resources.Appliance#M_tags
		 * @type string[]
		 * @internal
		 */
		internal string[] M_tags;
		
		/**
		 * アイコン
		 * 
		 * @member saklient.cloud.resources.Appliance#M_icon
		 * @type Icon
		 * @internal
		 */
		internal Icon M_icon;
		
		/**
		 * プラン
		 * 
		 * @member saklient.cloud.resources.Appliance#M_ifaces
		 * @type Iface[]
		 * @internal
		 */
		internal Iface[] M_ifaces;
		
		/**
		 * サービスクラス
		 * 
		 * @member saklient.cloud.resources.Appliance#M_serviceClass
		 * @type string
		 * @internal
		 */
		internal string M_serviceClass;
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/appliance";
		}
		
		/**
		 * @private
		 * @method _rootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _rootKey()
		{
			return "Appliance";
		}
		
		/**
		 * @private
		 * @method _rootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _rootKeyM()
		{
			return "Appliances";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Appliance";
		}
		
		/**
		 * @private
		 * @method _id
		 * @ignore
		 * @return {string}
		 */
		public override string _id()
		{
			return this.Get_id();
		}
		
		/**
		 * このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		 * 
		 * @method Save
		 * @chainable
		 * @public
		 * @return {Appliance} this
		 */
		public Appliance Save()
		{
			return ((Appliance)(dynamic)(this._save()));
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
		 * @chainable
		 * @public
		 * @return {Appliance} this
		 */
		public Appliance Reload()
		{
			return ((Appliance)(dynamic)(this._reload()));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {dynamic} obj
		 * @param {bool} wrapped=false
		 */
		public Appliance(Client client, dynamic obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "dynamic");
			Util.ValidateType(wrapped, "bool");
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * アプライアンスを起動します。
		 * 
		 * @method Boot
		 * @chainable
		 * @public
		 * @return {Appliance} this
		 */
		public Appliance Boot()
		{
			this._client.Request("PUT", this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/power");
			return this;
		}
		
		/**
		 * アプライアンスをシャットダウンします。
		 * 
		 * @method Shutdown
		 * @chainable
		 * @public
		 * @return {Appliance} this
		 */
		public Appliance Shutdown()
		{
			this._client.Request("DELETE", this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/power");
			return this;
		}
		
		/**
		 * アプライアンスを強制停止します。
		 * 
		 * @method Stop
		 * @chainable
		 * @public
		 * @return {Appliance} this
		 */
		public Appliance Stop()
		{
			this._client.Request("DELETE", this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/power", new System.Collections.Generic.Dictionary<string, object> { { "Force", true } });
			return this;
		}
		
		/**
		 * アプライアンスを強制再起動します。
		 * 
		 * @method Reboot
		 * @chainable
		 * @public
		 * @return {Appliance} this
		 */
		public Appliance Reboot()
		{
			this._client.Request("PUT", this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/reset");
			return this;
		}
		
		/**
		 * @member saklient.cloud.resources.Appliance#N_id
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_id = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_id
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_id()
		{
			return this.M_id;
		}
		
		/**
		 * ID
		 * 
		 * @property Id
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Id
		{
			get { return this.Get_id(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Appliance#N_clazz
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_clazz = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_clazz
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_clazz()
		{
			return this.M_clazz;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_clazz
		 * @private
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		private string Set_clazz(string v)
		{
			Util.ValidateType(v, "string");
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Appliance#Set_clazz");
			};
			this.M_clazz = v;
			this.N_clazz = true;
			return this.M_clazz;
		}
		
		/**
		 * クラス {@link EApplianceClass}
		 * 
		 * @property Clazz
		 * @type string
		 * @public
		 */
		public string Clazz
		{
			get { return this.Get_clazz(); }
			set { this.Set_clazz(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Appliance#N_name
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_name = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_name
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_name()
		{
			return this.M_name;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_name
		 * @private
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		private string Set_name(string v)
		{
			Util.ValidateType(v, "string");
			this.M_name = v;
			this.N_name = true;
			return this.M_name;
		}
		
		/**
		 * 名前
		 * 
		 * @property Name
		 * @type string
		 * @public
		 */
		public string Name
		{
			get { return this.Get_name(); }
			set { this.Set_name(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Appliance#N_description
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_description = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_description
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_description()
		{
			return this.M_description;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_description
		 * @private
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		private string Set_description(string v)
		{
			Util.ValidateType(v, "string");
			this.M_description = v;
			this.N_description = true;
			return this.M_description;
		}
		
		/**
		 * 説明
		 * 
		 * @property Description
		 * @type string
		 * @public
		 */
		public string Description
		{
			get { return this.Get_description(); }
			set { this.Set_description(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Appliance#N_tags
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_tags = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_tags
		 * @private
		 * @ignore
		 * @return {string[]}
		 */
		private string[] Get_tags()
		{
			return this.M_tags;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_tags
		 * @private
		 * @ignore
		 * @param {string[]} v
		 * @return {string[]}
		 */
		private string[] Set_tags(string[] v)
		{
			Util.ValidateType(v, "System.Collections.ArrayList");
			this.M_tags = v;
			this.N_tags = true;
			return this.M_tags;
		}
		
		/**
		 * タグ
		 * 
		 * @property Tags
		 * @type string[]
		 * @public
		 */
		public string[] Tags
		{
			get { return this.Get_tags(); }
			set { this.Set_tags(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Appliance#N_icon
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_icon = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_icon
		 * @private
		 * @ignore
		 * @return {Icon}
		 */
		private Icon Get_icon()
		{
			return this.M_icon;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_icon
		 * @private
		 * @ignore
		 * @param {Icon} v
		 * @return {Icon}
		 */
		private Icon Set_icon(Icon v)
		{
			Util.ValidateType(v, "Saklient.Cloud.Resources.Icon");
			this.M_icon = v;
			this.N_icon = true;
			return this.M_icon;
		}
		
		/**
		 * アイコン
		 * 
		 * @property Icon
		 * @type Icon
		 * @public
		 */
		public Icon Icon
		{
			get { return this.Get_icon(); }
			set { this.Set_icon(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Appliance#N_ifaces
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_ifaces = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_ifaces
		 * @private
		 * @ignore
		 * @return {Iface[]}
		 */
		private Iface[] Get_ifaces()
		{
			return this.M_ifaces;
		}
		
		/**
		 * プラン
		 * 
		 * @property Ifaces
		 * @type Iface[]
		 * @readOnly
		 * @public
		 */
		public Iface[] Ifaces
		{
			get { return this.Get_ifaces(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Appliance#N_serviceClass
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_serviceClass = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_serviceClass
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_serviceClass()
		{
			return this.M_serviceClass;
		}
		
		/**
		 * サービスクラス
		 * 
		 * @property ServiceClass
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string ServiceClass
		{
			get { return this.Get_serviceClass(); }
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method ApiDeserializeImpl
		 * @internal
		 * @param {dynamic} r
		 */
		internal override void ApiDeserializeImpl(dynamic r)
		{
			Util.ValidateType(r, "dynamic");
			this.IsNew = r == null;
			if (this.IsNew) {
				r = new System.Collections.Generic.Dictionary<string, object> {  };
			};
			this.IsIncomplete = false;
			if (Util.ExistsPath(r, "ID")) {
				this.M_id = Util.GetByPath(r, "ID") == null ? null : "" + Util.GetByPath(r, "ID");
			}
			else {
				this.M_id = null;
				this.IsIncomplete = true;
			};
			this.N_id = false;
			if (Util.ExistsPath(r, "Class")) {
				this.M_clazz = Util.GetByPath(r, "Class") == null ? null : "" + Util.GetByPath(r, "Class");
			}
			else {
				this.M_clazz = null;
				this.IsIncomplete = true;
			};
			this.N_clazz = false;
			if (Util.ExistsPath(r, "Name")) {
				this.M_name = Util.GetByPath(r, "Name") == null ? null : "" + Util.GetByPath(r, "Name");
			}
			else {
				this.M_name = null;
				this.IsIncomplete = true;
			};
			this.N_name = false;
			if (Util.ExistsPath(r, "Description")) {
				this.M_description = Util.GetByPath(r, "Description") == null ? null : "" + Util.GetByPath(r, "Description");
			}
			else {
				this.M_description = null;
				this.IsIncomplete = true;
			};
			this.N_description = false;
			if (Util.ExistsPath(r, "Tags")) {
				if (Util.GetByPath(r, "Tags") == null) {
					this.M_tags = new string[] {  };
				}
				else {
					this.M_tags = new string[] {  };
					for (int __it1=0; __it1 < (((dynamic[])(dynamic)(Util.GetByPath(r, "Tags"))) as System.Collections.IList).Count; __it1++) {
						var t = ((dynamic[])(dynamic)(Util.GetByPath(r, "Tags")))[__it1];
						string v1 = null;
						v1 = t == null ? null : "" + t;
						(this.M_tags as System.Collections.IList).Add(v1);
					};
				};
			}
			else {
				this.M_tags = null;
				this.IsIncomplete = true;
			};
			this.N_tags = false;
			if (Util.ExistsPath(r, "Icon")) {
				this.M_icon = Util.GetByPath(r, "Icon") == null ? null : new Icon(this._client, Util.GetByPath(r, "Icon"));
			}
			else {
				this.M_icon = null;
				this.IsIncomplete = true;
			};
			this.N_icon = false;
			if (Util.ExistsPath(r, "Interfaces")) {
				if (Util.GetByPath(r, "Interfaces") == null) {
					this.M_ifaces = new Iface[] {  };
				}
				else {
					this.M_ifaces = new Iface[] {  };
					for (int __it2=0; __it2 < (((dynamic[])(dynamic)(Util.GetByPath(r, "Interfaces"))) as System.Collections.IList).Count; __it2++) {
						var t = ((dynamic[])(dynamic)(Util.GetByPath(r, "Interfaces")))[__it2];
						Iface v2 = null;
						v2 = t == null ? null : new Iface(this._client, t);
						(this.M_ifaces as System.Collections.IList).Add(v2);
					};
				};
			}
			else {
				this.M_ifaces = null;
				this.IsIncomplete = true;
			};
			this.N_ifaces = false;
			if (Util.ExistsPath(r, "ServiceClass")) {
				this.M_serviceClass = Util.GetByPath(r, "ServiceClass") == null ? null : "" + Util.GetByPath(r, "ServiceClass");
			}
			else {
				this.M_serviceClass = null;
				this.IsIncomplete = true;
			};
			this.N_serviceClass = false;
		}
		
		/**
		 * @ignore
		 * @method ApiSerializeImpl
		 * @internal
		 * @param {bool} withClean=false
		 * @return {dynamic}
		 */
		internal override dynamic ApiSerializeImpl(bool withClean=false)
		{
			Util.ValidateType(withClean, "bool");
			string[] missing = {  };
			dynamic ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			};
			if (withClean || this.N_clazz) {
				Util.SetByPath(ret, "Class", this.M_clazz);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("clazz");
				};
			};
			if (withClean || this.N_name) {
				Util.SetByPath(ret, "Name", this.M_name);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("name");
				};
			};
			if (withClean || this.N_description) {
				Util.SetByPath(ret, "Description", this.M_description);
			};
			if (withClean || this.N_tags) {
				Util.SetByPath(ret, "Tags", new object[] {  });
				for (int __it1=0; __it1 < (this.M_tags as System.Collections.IList).Count; __it1++) {
					var r1 = this.M_tags[__it1];
					dynamic v = null;
					v = r1;
					((ret as System.Collections.Generic.Dictionary<string, object>)["Tags"] as System.Collections.IList).Add(v);
				};
			};
			if (withClean || this.N_icon) {
				Util.SetByPath(ret, "Icon", withClean ? (this.M_icon == null ? null : this.M_icon.ApiSerialize(withClean)) : (this.M_icon == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_icon.ApiSerializeID()));
			};
			if (withClean || this.N_ifaces) {
				Util.SetByPath(ret, "Interfaces", new object[] {  });
				for (int __it2=0; __it2 < (this.M_ifaces as System.Collections.IList).Count; __it2++) {
					var r2 = this.M_ifaces[__it2];
					dynamic v = null;
					v = withClean ? (r2 == null ? null : r2.ApiSerialize(withClean)) : (r2 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r2.ApiSerializeID());
					((ret as System.Collections.Generic.Dictionary<string, object>)["Interfaces"] as System.Collections.IList).Add(v);
				};
			};
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			};
			if (missing.Length > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Appliance creation: " + string.Join(", ", missing));
			};
			return ret;
		}
		
	}
	
}
