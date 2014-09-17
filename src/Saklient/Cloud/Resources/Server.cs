using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using Disk = Saklient.Cloud.Resources.Disk;
using Iface = Saklient.Cloud.Resources.Iface;
using ServerPlan = Saklient.Cloud.Resources.ServerPlan;
using ServerInstance = Saklient.Cloud.Resources.ServerInstance;
using IsoImage = Saklient.Cloud.Resources.IsoImage;
using EServerInstanceStatus = Saklient.Cloud.Enums.EServerInstanceStatus;
using EAvailability = Saklient.Cloud.Enums.EAvailability;

namespace Saklient.Cloud.Resources
{

	/**
	 * サーバの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Server
	 * @class Server
	 * @constructor
	 * @extends Resource
	 */
	class Server : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Server#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.Server#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * 説明
		 * 
		 * @member saklient.cloud.resources.Server#M_description
		 * @type string
		 * @internal
		 */
		internal string M_description;
		
		/**
		 * タグ
		 * 
		 * @member saklient.cloud.resources.Server#M_tags
		 * @type string[]
		 * @internal
		 */
		internal string[] M_tags;
		
		/**
		 * アイコン
		 * 
		 * @member saklient.cloud.resources.Server#M_icon
		 * @type Icon
		 * @internal
		 */
		internal Icon M_icon;
		
		/**
		 * プラン
		 * 
		 * @member saklient.cloud.resources.Server#M_plan
		 * @type ServerPlan
		 * @internal
		 */
		internal ServerPlan M_plan;
		
		/**
		 * インタフェース
		 * 
		 * @member saklient.cloud.resources.Server#M_ifaces
		 * @type Iface[]
		 * @internal
		 */
		internal Iface[] M_ifaces;
		
		/**
		 * インスタンス情報
		 * 
		 * @member saklient.cloud.resources.Server#M_instance
		 * @type ServerInstance
		 * @internal
		 */
		internal ServerInstance M_instance;
		
		/**
		 * 有効状態 {@link EAvailability}
		 * 
		 * @member saklient.cloud.resources.Server#M_availability
		 * @type string
		 * @internal
		 */
		internal string M_availability;
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/server";
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
			return "Server";
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
			return "Servers";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Server";
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
		 * @return {Server} this
		 */
		public Server Save()
		{
			return ((Server)(dynamic)(this._save()));
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
		 * @chainable
		 * @public
		 * @return {Server} this
		 */
		public Server Reload()
		{
			return ((Server)(dynamic)(this._reload()));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {dynamic} obj
		 * @param {bool} wrapped=false
		 */
		public Server(Client client, dynamic obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "dynamic");
			Util.ValidateType(wrapped, "bool");
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * サーバが起動しているときtrueを返します。
		 * 
		 * @method IsUp
		 * @public
		 * @return {bool}
		 */
		public bool IsUp()
		{
			return this.Get_instance().IsUp();
		}
		
		/**
		 * サーバが停止しているときtrueを返します。
		 * 
		 * @method IsDown
		 * @public
		 * @return {bool}
		 */
		public bool IsDown()
		{
			return this.Get_instance().IsDown();
		}
		
		/**
		 * サーバを起動します。
		 * 
		 * @method Boot
		 * @chainable
		 * @public
		 * @return {Server} this
		 */
		public Server Boot()
		{
			this._client.Request("PUT", this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/power");
			return this.Reload();
		}
		
		/**
		 * サーバをシャットダウンします。
		 * 
		 * @method Shutdown
		 * @chainable
		 * @public
		 * @return {Server} this
		 */
		public Server Shutdown()
		{
			this._client.Request("DELETE", this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/power");
			return this.Reload();
		}
		
		/**
		 * サーバを強制停止します。
		 * 
		 * @method Stop
		 * @chainable
		 * @public
		 * @return {Server} this
		 */
		public Server Stop()
		{
			this._client.Request("DELETE", this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/power", new System.Collections.Generic.Dictionary<string, object> { { "Force", true } });
			return this.Reload();
		}
		
		/**
		 * サーバを強制再起動します。
		 * 
		 * @method Reboot
		 * @chainable
		 * @public
		 * @return {Server} this
		 */
		public Server Reboot()
		{
			this._client.Request("PUT", this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/reset");
			return this.Reload();
		}
		
		/**
		 * サーバが停止するまで待機します。
		 * 
		 * @method AfterDown
		 * @public
		 * @param {int} timeoutSec
		 * @param {System.Action<Server, bool>} callback
		 * @return {void} 成功時はtrue、タイムアウトやエラーによる失敗時はfalseを返します。
		 */
		public void AfterDown(int timeoutSec, System.Action<Server, bool> callback)
		{
			Util.ValidateType(timeoutSec, "int");
			Util.ValidateType(callback, "function");
			this.AfterStatus(EServerInstanceStatus.Down, timeoutSec, callback);
		}
		
		/**
		 * サーバが指定のステータスに遷移するまで待機します。
		 * 
		 * @ignore
		 * @method AfterStatus
		 * @private
		 * @param {string} status
		 * @param {int} timeoutSec
		 * @param {System.Action<Server, bool>} callback
		 * @return {void}
		 */
		private void AfterStatus(string status, int timeoutSec, System.Action<Server, bool> callback)
		{
			Util.ValidateType(status, "string");
			Util.ValidateType(timeoutSec, "int");
			Util.ValidateType(callback, "function");
			dynamic ret = this.SleepUntil(status, timeoutSec);
			callback(this, ret);
		}
		
		/**
		 * サーバが停止するまで待機します。
		 * 
		 * @method SleepUntilDown
		 * @public
		 * @param {int} timeoutSec=180
		 * @return {bool} 成功時はtrue、タイムアウトやエラーによる失敗時はfalseを返します。
		 */
		public bool SleepUntilDown(int timeoutSec=180)
		{
			Util.ValidateType(timeoutSec, "int");
			return this.SleepUntil(EServerInstanceStatus.Down, timeoutSec);
		}
		
		/**
		 * サーバが指定のステータスに遷移するまで待機します。
		 * 
		 * @ignore
		 * @method SleepUntil
		 * @private
		 * @param {string} status
		 * @param {int} timeoutSec=180
		 * @return {bool}
		 */
		private bool SleepUntil(string status, int timeoutSec=180)
		{
			Util.ValidateType(status, "string");
			Util.ValidateType(timeoutSec, "int");
			dynamic step = 3;
			while (0 < timeoutSec) {
				this.Reload();
				string s = this.Get_instance().Status;
				if (s == null) {
					s = EServerInstanceStatus.Down;
				};
				if (s == status) {
					return true;
				};
				timeoutSec -= step;
				if (0 < timeoutSec) {
					Util.Sleep(step);
				};
			};
			return false;
		}
		
		/**
		 * サーバプランを変更します。
		 * 
		 * 成功時はリソースIDが変わることにご注意ください。
		 * 
		 * @method ChangePlan
		 * @chainable
		 * @public
		 * @param {ServerPlan} planTo
		 * @return {Server} this
		 */
		public Server ChangePlan(ServerPlan planTo)
		{
			Util.ValidateType(planTo, "Saklient.Cloud.Resources.ServerPlan");
			string path = this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/to/plan/" + Util.UrlEncode(planTo._id());
			dynamic result = this._client.Request("PUT", path);
			this.ApiDeserialize(result, true);
			return this;
		}
		
		/**
		 * サーバに接続されているディスクのリストを取得します。
		 * 
		 * @method FindDisks
		 * @public
		 * @return {Disk[]}
		 */
		public Disk[] FindDisks()
		{
			dynamic model = Util.CreateClassInstance("saklient.cloud.models.Model_Disk", new object[] { this._client });
			return model.WithServerId(this._id()).Find();
		}
		
		/**
		 * サーバにインタフェースを1つ増設し、それを取得します。
		 * 
		 * @method AddIface
		 * @public
		 * @return {Iface} 増設されたインタフェース
		 */
		public Iface AddIface()
		{
			dynamic model = Util.CreateClassInstance("saklient.cloud.models.Model_Iface", new object[] { this._client });
			Iface res = model.Create();
			res.SetProperty("serverId", this._id());
			return res.Save();
		}
		
		/**
		 * サーバにISOイメージを挿入します。
		 * 
		 * @method InsertIsoImage
		 * @chainable
		 * @public
		 * @param {IsoImage} iso
		 * @return {Server} this
		 */
		public Server InsertIsoImage(IsoImage iso)
		{
			Util.ValidateType(iso, "Saklient.Cloud.Resources.IsoImage");
			string path = this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/cdrom";
			dynamic q = new System.Collections.Generic.Dictionary<string, object> { { "CDROM", new System.Collections.Generic.Dictionary<string, object> { { "ID", iso._id() } } } };
			dynamic result = this._client.Request("PUT", path, q);
			this.Reload();
			return this;
		}
		
		/**
		 * サーバに挿入されているISOイメージを排出します。
		 * 
		 * @method EjectIsoImage
		 * @chainable
		 * @public
		 * @return {Server} this
		 */
		public Server EjectIsoImage()
		{
			string path = this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/cdrom";
			dynamic result = this._client.Request("DELETE", path);
			this.Reload();
			return this;
		}
		
		/**
		 * @member saklient.cloud.resources.Server#N_id
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
		 * @member saklient.cloud.resources.Server#N_name
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
		 * @member saklient.cloud.resources.Server#N_description
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
		 * @member saklient.cloud.resources.Server#N_tags
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
		 * @member saklient.cloud.resources.Server#N_icon
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
		 * @member saklient.cloud.resources.Server#N_plan
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_plan = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_plan
		 * @private
		 * @ignore
		 * @return {ServerPlan}
		 */
		private ServerPlan Get_plan()
		{
			return this.M_plan;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_plan
		 * @private
		 * @ignore
		 * @param {ServerPlan} v
		 * @return {ServerPlan}
		 */
		private ServerPlan Set_plan(ServerPlan v)
		{
			Util.ValidateType(v, "Saklient.Cloud.Resources.ServerPlan");
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Server#Set_plan");
			};
			this.M_plan = v;
			this.N_plan = true;
			return this.M_plan;
		}
		
		/**
		 * プラン
		 * 
		 * @property Plan
		 * @type ServerPlan
		 * @public
		 */
		public ServerPlan Plan
		{
			get { return this.Get_plan(); }
			set { this.Set_plan(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Server#N_ifaces
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
		 * インタフェース
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
		 * @member saklient.cloud.resources.Server#N_instance
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_instance = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_instance
		 * @private
		 * @ignore
		 * @return {ServerInstance}
		 */
		private ServerInstance Get_instance()
		{
			return this.M_instance;
		}
		
		/**
		 * インスタンス情報
		 * 
		 * @property Instance
		 * @type ServerInstance
		 * @readOnly
		 * @public
		 */
		public ServerInstance Instance
		{
			get { return this.Get_instance(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Server#N_availability
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_availability = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_availability
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_availability()
		{
			return this.M_availability;
		}
		
		/**
		 * 有効状態 {@link EAvailability}
		 * 
		 * @property Availability
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Availability
		{
			get { return this.Get_availability(); }
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
			if (Util.ExistsPath(r, "ServerPlan")) {
				this.M_plan = Util.GetByPath(r, "ServerPlan") == null ? null : new ServerPlan(this._client, Util.GetByPath(r, "ServerPlan"));
			}
			else {
				this.M_plan = null;
				this.IsIncomplete = true;
			};
			this.N_plan = false;
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
			if (Util.ExistsPath(r, "Instance")) {
				this.M_instance = Util.GetByPath(r, "Instance") == null ? null : new ServerInstance(this._client, Util.GetByPath(r, "Instance"));
			}
			else {
				this.M_instance = null;
				this.IsIncomplete = true;
			};
			this.N_instance = false;
			if (Util.ExistsPath(r, "Availability")) {
				this.M_availability = Util.GetByPath(r, "Availability") == null ? null : "" + Util.GetByPath(r, "Availability");
			}
			else {
				this.M_availability = null;
				this.IsIncomplete = true;
			};
			this.N_availability = false;
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
			if (withClean || this.N_plan) {
				Util.SetByPath(ret, "ServerPlan", withClean ? (this.M_plan == null ? null : this.M_plan.ApiSerialize(withClean)) : (this.M_plan == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_plan.ApiSerializeID()));
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("plan");
				};
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
			if (withClean || this.N_instance) {
				Util.SetByPath(ret, "Instance", withClean ? (this.M_instance == null ? null : this.M_instance.ApiSerialize(withClean)) : (this.M_instance == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_instance.ApiSerializeID()));
			};
			if (withClean || this.N_availability) {
				Util.SetByPath(ret, "Availability", this.M_availability);
			};
			if (missing.Length > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Server creation: " + string.Join(", ", missing));
			};
			return ret;
		}
		
	}
	
}
