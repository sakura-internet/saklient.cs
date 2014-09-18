using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using DiskPlan = Saklient.Cloud.Resources.DiskPlan;
using Server = Saklient.Cloud.Resources.Server;
using DiskConfig = Saklient.Cloud.Resources.DiskConfig;
using EAvailability = Saklient.Cloud.Enums.EAvailability;
using EDiskConnection = Saklient.Cloud.Enums.EDiskConnection;
using EStorageClass = Saklient.Cloud.Enums.EStorageClass;

namespace Saklient.Cloud.Resources
{

	/**
	 * ディスクの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Disk
	 * @class Disk
	 * @constructor
	 * @extends Resource
	 */
	public class Disk : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Disk#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.Disk#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * 説明
		 * 
		 * @member saklient.cloud.resources.Disk#M_description
		 * @type string
		 * @internal
		 */
		internal string M_description;
		
		/**
		 * タグ
		 * 
		 * @member saklient.cloud.resources.Disk#M_tags
		 * @type System.Collections.Generic.List<string>
		 * @internal
		 */
		internal System.Collections.Generic.List<string> M_tags;
		
		/**
		 * アイコン
		 * 
		 * @member saklient.cloud.resources.Disk#M_icon
		 * @type Icon
		 * @internal
		 */
		internal Icon M_icon;
		
		/**
		 * サイズ[MiB]
		 * 
		 * @member saklient.cloud.resources.Disk#M_sizeMib
		 * @type long?
		 * @internal
		 */
		internal long? M_sizeMib;
		
		/**
		 * サービスクラス
		 * 
		 * @member saklient.cloud.resources.Disk#M_serviceClass
		 * @type string
		 * @internal
		 */
		internal string M_serviceClass;
		
		/**
		 * プラン
		 * 
		 * @member saklient.cloud.resources.Disk#M_plan
		 * @type DiskPlan
		 * @internal
		 */
		internal DiskPlan M_plan;
		
		/**
		 * 接続先のサーバ
		 * 
		 * @member saklient.cloud.resources.Disk#M_server
		 * @type Server
		 * @internal
		 */
		internal Server M_server;
		
		/**
		 * 有効状態 {@link EAvailability}
		 * 
		 * @member saklient.cloud.resources.Disk#M_availability
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
			return "/disk";
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
			return "Disk";
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
			return "Disks";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Disk";
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
		 * @return {Disk} this
		 */
		public Disk Save()
		{
			return ((Disk)(this._save()));
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
		 * @chainable
		 * @public
		 * @return {Disk} this
		 */
		public Disk Reload()
		{
			return ((Disk)(this._reload()));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 */
		public Disk(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "object");
			Util.ValidateType(wrapped, "bool");
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * @method Get_isAvailable
		 * @internal
		 * @ignore
		 * @return {bool}
		 */
		internal bool Get_isAvailable()
		{
			return this.Get_availability() == EAvailability.Available;
		}
		
		/**
		 * ディスクが利用可能なときtrueを返します。
		 * 
		 * @property IsAvailable
		 * @type bool
		 * @readOnly
		 * @public
		 */
		public bool IsAvailable
		{
			get { return this.Get_isAvailable(); }
		}
		
		/**
		 * @method Get_sizeGib
		 * @internal
		 * @ignore
		 * @return {long?}
		 */
		internal long? Get_sizeGib()
		{
			long? sizeMib = this.Get_sizeMib();
			return sizeMib == null ? null : sizeMib >> 10;
		}
		
		/**
		 * @method Set_sizeGib
		 * @internal
		 * @ignore
		 * @param {long?} sizeGib
		 * @return {long?}
		 */
		internal long? Set_sizeGib(long? sizeGib)
		{
			Util.ValidateType(sizeGib, "long");
			this.Set_sizeMib(sizeGib == null ? null : sizeGib * 1024);
			return sizeGib;
		}
		
		/**
		 * サイズ[GiB]
		 * 
		 * @property SizeGib
		 * @type long?
		 * @public
		 */
		public long? SizeGib
		{
			get { return this.Get_sizeGib(); }
			set { this.Set_sizeGib(value); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.Disk#_source
		 * @type Resource
		 * @ignore
		 */
		private Resource _source;
		
		/**
		 * @method Get_source
		 * @ignore
		 * @return {Resource}
		 */
		public Resource Get_source()
		{
			return this._source;
		}
		
		/**
		 * @method Set_source
		 * @ignore
		 * @param {Resource} source
		 * @return {Resource}
		 */
		public Resource Set_source(Resource source)
		{
			Util.ValidateType(source, "Saklient.Cloud.Resources.Resource");
			this._source = source;
			return source;
		}
		
		/**
		 * ディスクのコピー元
		 * 
		 * @property Source
		 * @type Resource
		 * @public
		 */
		public Resource Source
		{
			get { return this.Get_source(); }
			set { this.Set_source(value); }
		}
		
		/**
		 * @private
		 * @method _onAfterApiDeserialize
		 * @internal
		 * @ignore
		 * @param {object} r
		 * @param {object} root
		 * @return {void}
		 */
		internal override void _onAfterApiDeserialize(object r, object root)
		{
			Util.ValidateType(r, "object");
			Util.ValidateType(root, "object");
			if (r != null) {
				if ((r as System.Collections.Generic.Dictionary<string, object>).ContainsKey("SourceDisk")) {
					object s = (r as System.Collections.Generic.Dictionary<string, object>)["SourceDisk"];
					if (s != null) {
						object id = (s as System.Collections.Generic.Dictionary<string, object>)["ID"];
						if (id != null) {
							this._source = new Disk(this._client, s);
						};
					};
				};
				if ((r as System.Collections.Generic.Dictionary<string, object>).ContainsKey("SourceArchive")) {
					object s = (r as System.Collections.Generic.Dictionary<string, object>)["SourceArchive"];
					if (s != null) {
						object id = (s as System.Collections.Generic.Dictionary<string, object>)["ID"];
						if (id != null) {
							object obj = Util.CreateClassInstance("saklient.cloud.resources.Archive", new System.Collections.Generic.List<object> { this._client, s, false });
							this._source = ((Resource)(obj));
						};
					};
				};
			};
		}
		
		/**
		 * @private
		 * @method _onAfterApiSerialize
		 * @internal
		 * @ignore
		 * @param {object} r
		 * @param {bool} withClean
		 * @return {void}
		 */
		internal override void _onAfterApiSerialize(object r, bool withClean)
		{
			Util.ValidateType(r, "object");
			Util.ValidateType(withClean, "bool");
			if (r == null) {
				return;
			};
			if (this._source != null) {
				if (this._source._className() == "Disk") {
					object s = withClean ? this._source.ApiSerialize(true) : new System.Collections.Generic.Dictionary<string, object> { { "ID", this._source._id() } };
					(r as System.Collections.Generic.Dictionary<string, object>)["SourceDisk"] = s;
				}
				else {
					if (this._source._className() == "Archive") {
						object s = withClean ? this._source.ApiSerialize(true) : new System.Collections.Generic.Dictionary<string, object> { { "ID", this._source._id() } };
						(r as System.Collections.Generic.Dictionary<string, object>)["SourceArchive"] = s;
					}
					else {
						this._source = null;
						Util.ValidateType(this._source, "Disk or Archive", true);
					};
				};
			};
		}
		
		/**
		 * ディスクをサーバに取り付けます。
		 * 
		 * @method ConnectTo
		 * @chainable
		 * @public
		 * @param {Server} server
		 * @return {Disk} this
		 */
		public Disk ConnectTo(Server server)
		{
			Util.ValidateType(server, "Saklient.Cloud.Resources.Server");
			this._client.Request("PUT", "/disk/" + this._id() + "/to/server/" + server._id());
			return this;
		}
		
		/**
		 * ディスクをサーバから取り外します。
		 * 
		 * @method Disconnect
		 * @chainable
		 * @public
		 * @return {Disk} this
		 */
		public Disk Disconnect()
		{
			this._client.Request("DELETE", "/disk/" + this._id() + "/to/server");
			return this;
		}
		
		/**
		 * ディスク修正を行うためのオブジェクトを用意します。
		 * 
		 * 返り値のオブジェクトにパラメータを設定し、write() を呼ぶことで修正を行います。
		 * 
		 * @method CreateConfig
		 * @public
		 * @return {DiskConfig}
		 */
		public DiskConfig CreateConfig()
		{
			return new DiskConfig(this._client, this._id());
		}
		
		/**
		 * コピー中のディスクが利用可能になるまで待機します。
		 * 
		 * @ignore
		 * @method AfterCopy
		 * @param {long} timeoutSec
		 * @param {System.Action<Disk, bool>} callback
		 * @return {void}
		 */
		public void AfterCopy(long timeoutSec, System.Action<Disk, bool> callback)
		{
			Util.ValidateType(timeoutSec, "long");
			Util.ValidateType(callback, "function");
			bool ret = this.SleepWhileCopying(timeoutSec);
			callback(this, ret);
		}
		
		/**
		 * コピー中のディスクが利用可能になるまで待機します。
		 * 
		 * @method SleepWhileCopying
		 * @public
		 * @param {long} timeoutSec=3600
		 * @return {bool} 成功時はtrue、タイムアウトやエラーによる失敗時はfalseを返します。
		 */
		public bool SleepWhileCopying(long timeoutSec=3600)
		{
			Util.ValidateType(timeoutSec, "long");
			long step = 3;
			while (0 < timeoutSec) {
				this.Reload();
				string a = this.Get_availability();
				if (a == EAvailability.Available) {
					return true;
				};
				if (a != EAvailability.Migrating) {
					timeoutSec = 0;
				};
				timeoutSec -= step;
				if (0 < timeoutSec) {
					Util.Sleep(step);
				};
			};
			return false;
		}
		
		/**
		 * @member saklient.cloud.resources.Disk#N_id
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
		 * @member saklient.cloud.resources.Disk#N_name
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
		 * @member saklient.cloud.resources.Disk#N_description
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
		 * @member saklient.cloud.resources.Disk#N_tags
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
		 * @return {System.Collections.Generic.List<string>}
		 */
		private System.Collections.Generic.List<string> Get_tags()
		{
			return this.M_tags;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_tags
		 * @private
		 * @ignore
		 * @param {System.Collections.Generic.List<string>} v
		 * @return {System.Collections.Generic.List<string>}
		 */
		private System.Collections.Generic.List<string> Set_tags(System.Collections.Generic.List<string> v)
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
		 * @type System.Collections.Generic.List<string>
		 * @public
		 */
		public System.Collections.Generic.List<string> Tags
		{
			get { return this.Get_tags(); }
			set { this.Set_tags(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Disk#N_icon
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
		 * @member saklient.cloud.resources.Disk#N_sizeMib
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_sizeMib = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_sizeMib
		 * @private
		 * @ignore
		 * @return {long?}
		 */
		private long? Get_sizeMib()
		{
			return this.M_sizeMib;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_sizeMib
		 * @private
		 * @ignore
		 * @param {long?} v
		 * @return {long?}
		 */
		private long? Set_sizeMib(long? v)
		{
			Util.ValidateType(v, "long");
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Disk#Set_sizeMib");
			};
			this.M_sizeMib = v;
			this.N_sizeMib = true;
			return this.M_sizeMib;
		}
		
		/**
		 * サイズ[MiB]
		 * 
		 * @property SizeMib
		 * @type long?
		 * @public
		 */
		public long? SizeMib
		{
			get { return this.Get_sizeMib(); }
			set { this.Set_sizeMib(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Disk#N_serviceClass
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
		 * @member saklient.cloud.resources.Disk#N_plan
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
		 * @return {DiskPlan}
		 */
		private DiskPlan Get_plan()
		{
			return this.M_plan;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_plan
		 * @private
		 * @ignore
		 * @param {DiskPlan} v
		 * @return {DiskPlan}
		 */
		private DiskPlan Set_plan(DiskPlan v)
		{
			Util.ValidateType(v, "Saklient.Cloud.Resources.DiskPlan");
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Disk#Set_plan");
			};
			this.M_plan = v;
			this.N_plan = true;
			return this.M_plan;
		}
		
		/**
		 * プラン
		 * 
		 * @property Plan
		 * @type DiskPlan
		 * @public
		 */
		public DiskPlan Plan
		{
			get { return this.Get_plan(); }
			set { this.Set_plan(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Disk#N_server
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_server = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_server
		 * @private
		 * @ignore
		 * @return {Server}
		 */
		private Server Get_server()
		{
			return this.M_server;
		}
		
		/**
		 * 接続先のサーバ
		 * 
		 * @property Server
		 * @type Server
		 * @readOnly
		 * @public
		 */
		public Server Server
		{
			get { return this.Get_server(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Disk#N_availability
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
		 * @param {object} r
		 */
		internal override void ApiDeserializeImpl(object r)
		{
			Util.ValidateType(r, "object");
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
					this.M_tags = new System.Collections.Generic.List<string> {  };
				}
				else {
					this.M_tags = new System.Collections.Generic.List<string> {  };
					for (int __it1=0; __it1 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags"))) as System.Collections.IList).Count; __it1++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags")))[__it1];
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
			if (Util.ExistsPath(r, "SizeMB")) {
				this.M_sizeMib = Util.GetByPath(r, "SizeMB") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "SizeMB"));
			}
			else {
				this.M_sizeMib = null;
				this.IsIncomplete = true;
			};
			this.N_sizeMib = false;
			if (Util.ExistsPath(r, "ServiceClass")) {
				this.M_serviceClass = Util.GetByPath(r, "ServiceClass") == null ? null : "" + Util.GetByPath(r, "ServiceClass");
			}
			else {
				this.M_serviceClass = null;
				this.IsIncomplete = true;
			};
			this.N_serviceClass = false;
			if (Util.ExistsPath(r, "Plan")) {
				this.M_plan = Util.GetByPath(r, "Plan") == null ? null : new DiskPlan(this._client, Util.GetByPath(r, "Plan"));
			}
			else {
				this.M_plan = null;
				this.IsIncomplete = true;
			};
			this.N_plan = false;
			if (Util.ExistsPath(r, "Server")) {
				this.M_server = Util.GetByPath(r, "Server") == null ? null : new Server(this._client, Util.GetByPath(r, "Server"));
			}
			else {
				this.M_server = null;
				this.IsIncomplete = true;
			};
			this.N_server = false;
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
		 * @return {object}
		 */
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			Util.ValidateType(withClean, "bool");
			System.Collections.Generic.List<string> missing = new System.Collections.Generic.List<string> {  };
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
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
				Util.SetByPath(ret, "Tags", new System.Collections.Generic.List<object> {  });
				for (int __it1=0; __it1 < (this.M_tags as System.Collections.IList).Count; __it1++) {
					var r1 = this.M_tags[__it1];
					object v = null;
					v = r1;
					((ret as System.Collections.Generic.Dictionary<string, object>)["Tags"] as System.Collections.IList).Add(v);
				};
			};
			if (withClean || this.N_icon) {
				Util.SetByPath(ret, "Icon", withClean ? (this.M_icon == null ? null : this.M_icon.ApiSerialize(withClean)) : (this.M_icon == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_icon.ApiSerializeID()));
			};
			if (withClean || this.N_sizeMib) {
				Util.SetByPath(ret, "SizeMB", this.M_sizeMib);
			};
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			};
			if (withClean || this.N_plan) {
				Util.SetByPath(ret, "Plan", withClean ? (this.M_plan == null ? null : this.M_plan.ApiSerialize(withClean)) : (this.M_plan == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_plan.ApiSerializeID()));
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("plan");
				};
			};
			if (withClean || this.N_server) {
				Util.SetByPath(ret, "Server", withClean ? (this.M_server == null ? null : this.M_server.ApiSerialize(withClean)) : (this.M_server == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_server.ApiSerializeID()));
			};
			if (withClean || this.N_availability) {
				Util.SetByPath(ret, "Availability", this.M_availability);
			};
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Disk creation: " + string.Join(", ", (missing).ToArray()));
			};
			return ret;
		}
		
	}
	
}
