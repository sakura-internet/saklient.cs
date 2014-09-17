using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using FtpInfo = Saklient.Cloud.Resources.FtpInfo;
using DiskPlan = Saklient.Cloud.Resources.DiskPlan;
using Server = Saklient.Cloud.Resources.Server;
using EScope = Saklient.Cloud.Enums.EScope;
using EAvailability = Saklient.Cloud.Enums.EAvailability;
using SaklientException = Saklient.Errors.SaklientException;

namespace Saklient.Cloud.Resources
{

	/**
	 * アーカイブの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Archive
	 * @class Archive
	 * @constructor
	 * @extends Resource
	 */
	class Archive : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Archive#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * スコープ {@link EScope}
		 * 
		 * @member saklient.cloud.resources.Archive#M_scope
		 * @type string
		 * @internal
		 */
		internal string M_scope;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.Archive#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * 説明
		 * 
		 * @member saklient.cloud.resources.Archive#M_description
		 * @type string
		 * @internal
		 */
		internal string M_description;
		
		/**
		 * タグ
		 * 
		 * @member saklient.cloud.resources.Archive#M_tags
		 * @type string[]
		 * @internal
		 */
		internal string[] M_tags;
		
		/**
		 * アイコン
		 * 
		 * @member saklient.cloud.resources.Archive#M_icon
		 * @type Icon
		 * @internal
		 */
		internal Icon M_icon;
		
		/**
		 * 表示順序
		 * 
		 * @member saklient.cloud.resources.Archive#M_displayOrder
		 * @type int?
		 * @internal
		 */
		internal int? M_displayOrder;
		
		/**
		 * サイズ[MiB]
		 * 
		 * @member saklient.cloud.resources.Archive#M_sizeMib
		 * @type int?
		 * @internal
		 */
		internal int? M_sizeMib;
		
		/**
		 * サービスクラス
		 * 
		 * @member saklient.cloud.resources.Archive#M_serviceClass
		 * @type string
		 * @internal
		 */
		internal string M_serviceClass;
		
		/**
		 * プラン
		 * 
		 * @member saklient.cloud.resources.Archive#M_plan
		 * @type DiskPlan
		 * @internal
		 */
		internal DiskPlan M_plan;
		
		/**
		 * 有効状態 {@link EAvailability}
		 * 
		 * @member saklient.cloud.resources.Archive#M_availability
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
			return "/archive";
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
			return "Archive";
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
			return "Archives";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Archive";
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
		 * @return {Archive} this
		 */
		public Archive Save()
		{
			return ((Archive)(dynamic)(this._save()));
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
		 * @chainable
		 * @public
		 * @return {Archive} this
		 */
		public Archive Reload()
		{
			return ((Archive)(dynamic)(this._reload()));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {dynamic} obj
		 * @param {bool} wrapped=false
		 */
		public Archive(Client client, dynamic obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "dynamic");
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
		 * @return {int?}
		 */
		internal int? Get_sizeGib()
		{
			int? sizeMib = this.Get_sizeMib();
			return sizeMib == null ? null : sizeMib >> 10;
		}
		
		/**
		 * @method Set_sizeGib
		 * @internal
		 * @ignore
		 * @param {int?} sizeGib
		 * @return {int?}
		 */
		internal int? Set_sizeGib(int? sizeGib)
		{
			Util.ValidateType(sizeGib, "int");
			this.Set_sizeMib(sizeGib == null ? null : sizeGib * 1024);
			return sizeGib;
		}
		
		/**
		 * サイズ[GiB]
		 * 
		 * @property SizeGib
		 * @type int?
		 * @public
		 */
		public int? SizeGib
		{
			get { return this.Get_sizeGib(); }
			set { this.Set_sizeGib(value); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.Archive#_source
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
		 * アーカイブのコピー元
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
		 * @member saklient.cloud.resources.Archive#_ftpInfo
		 * @type FtpInfo
		 * @internal
		 * @ignore
		 */
		internal FtpInfo _ftpInfo;
		
		/**
		 * @method Get_ftpInfo
		 * @ignore
		 * @return {FtpInfo}
		 */
		public FtpInfo Get_ftpInfo()
		{
			return this._ftpInfo;
		}
		
		/**
		 * FTP情報
		 * 
		 * @property FtpInfo
		 * @type FtpInfo
		 * @readOnly
		 * @public
		 */
		public FtpInfo FtpInfo
		{
			get { return this.Get_ftpInfo(); }
		}
		
		/**
		 * @private
		 * @method _onAfterApiDeserialize
		 * @internal
		 * @ignore
		 * @param {dynamic} r
		 * @param {dynamic} root
		 * @return {void}
		 */
		internal override void _onAfterApiDeserialize(dynamic r, dynamic root)
		{
			Util.ValidateType(r, "dynamic");
			Util.ValidateType(root, "dynamic");
			if (root != null) {
				if ((root as System.Collections.Generic.Dictionary<string, object>).ContainsKey("FTPServer")) {
					dynamic ftp = (root as System.Collections.Generic.Dictionary<string, object>)["FTPServer"];
					if (ftp != null) {
						this._ftpInfo = new FtpInfo(ftp);
					};
				};
			};
			if (r != null) {
				if ((r as System.Collections.Generic.Dictionary<string, object>).ContainsKey("SourceArchive")) {
					dynamic s = (r as System.Collections.Generic.Dictionary<string, object>)["SourceArchive"];
					if (s != null) {
						dynamic id = (s as System.Collections.Generic.Dictionary<string, object>)["ID"];
						if (id != null) {
							this._source = new Archive(this._client, s);
						};
					};
				};
				if ((r as System.Collections.Generic.Dictionary<string, object>).ContainsKey("SourceDisk")) {
					dynamic s = (r as System.Collections.Generic.Dictionary<string, object>)["SourceDisk"];
					if (s != null) {
						dynamic id = (s as System.Collections.Generic.Dictionary<string, object>)["ID"];
						if (id != null) {
							dynamic obj = Util.CreateClassInstance("saklient.cloud.resources.Disk", new object[] { this._client, s });
							this._source = ((Resource)(dynamic)(obj));
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
		 * @param {dynamic} r
		 * @param {bool} withClean
		 * @return {void}
		 */
		internal override void _onAfterApiSerialize(dynamic r, bool withClean)
		{
			Util.ValidateType(r, "dynamic");
			Util.ValidateType(withClean, "bool");
			if (r == null) {
				return;
			};
			if (this._source != null) {
				if (this._source._className() == "Archive") {
					dynamic s = withClean ? this._source.ApiSerialize(true) : new System.Collections.Generic.Dictionary<string, object> { { "ID", this._source._id() } };
					(r as System.Collections.Generic.Dictionary<string, object>)["SourceArchive"] = s;
				}
				else {
					if (this._source._className() == "Disk") {
						dynamic s = withClean ? this._source.ApiSerialize(true) : new System.Collections.Generic.Dictionary<string, object> { { "ID", this._source._id() } };
						(r as System.Collections.Generic.Dictionary<string, object>)["SourceDisk"] = s;
					}
					else {
						this._source = null;
						Util.ValidateType(this._source, "Disk or Archive", true);
					};
				};
			};
		}
		
		/**
		 * FTPSを開始し、イメージファイルをアップロード・ダウンロードできる状態にします。
		 * 
		 * アカウント情報は、ftpInfo プロパティから取得することができます。
		 * 
		 * @method OpenFtp
		 * @chainable
		 * @public
		 * @param {bool} reset=false 既にFTPSが開始されているとき、trueを指定してこのメソッドを呼ぶことでパスワードを再設定します。
		 * @return {Archive} this
		 */
		public Archive OpenFtp(bool reset=false)
		{
			Util.ValidateType(reset, "bool");
			string path = this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/ftp";
			dynamic q = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(q, "ChangePassword", reset);
			dynamic result = this._client.Request("PUT", path, q);
			this._onAfterApiDeserialize(null, result);
			return this;
		}
		
		/**
		 * FTPSを終了し、アーカイブを利用可能な状態にします。
		 * 
		 * @method CloseFtp
		 * @chainable
		 * @public
		 * @return {Archive} this
		 */
		public Archive CloseFtp()
		{
			string path = this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/ftp";
			dynamic result = this._client.Request("DELETE", path);
			this._ftpInfo = null;
			return this;
		}
		
		/**
		 * コピー中のアーカイブが利用可能になるまで待機します。
		 * 
		 * @ignore
		 * @method AfterCopy
		 * @param {int} timeoutSec
		 * @param {System.Action<Archive, bool>} callback
		 * @return {void}
		 */
		public void AfterCopy(int timeoutSec, System.Action<Archive, bool> callback)
		{
			Util.ValidateType(timeoutSec, "int");
			Util.ValidateType(callback, "function");
			dynamic ret = this.SleepWhileCopying(timeoutSec);
			callback(this, ret);
		}
		
		/**
		 * コピー中のアーカイブが利用可能になるまで待機します。
		 * 
		 * @method SleepWhileCopying
		 * @public
		 * @param {int} timeoutSec=3600
		 * @return {bool} 成功時はtrue、タイムアウトやエラーによる失敗時はfalseを返します。
		 */
		public bool SleepWhileCopying(int timeoutSec=3600)
		{
			Util.ValidateType(timeoutSec, "int");
			int step = 3;
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
		 * @member saklient.cloud.resources.Archive#N_id
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
		 * @member saklient.cloud.resources.Archive#N_scope
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_scope = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_scope
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_scope()
		{
			return this.M_scope;
		}
		
		/**
		 * スコープ {@link EScope}
		 * 
		 * @property Scope
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Scope
		{
			get { return this.Get_scope(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Archive#N_name
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
		 * @member saklient.cloud.resources.Archive#N_description
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
		 * @member saklient.cloud.resources.Archive#N_tags
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
		 * @member saklient.cloud.resources.Archive#N_icon
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
		 * @member saklient.cloud.resources.Archive#N_displayOrder
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_displayOrder = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_displayOrder
		 * @private
		 * @ignore
		 * @return {int?}
		 */
		private int? Get_displayOrder()
		{
			return this.M_displayOrder;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_displayOrder
		 * @private
		 * @ignore
		 * @param {int?} v
		 * @return {int?}
		 */
		private int? Set_displayOrder(int? v)
		{
			Util.ValidateType(v, "int");
			this.M_displayOrder = v;
			this.N_displayOrder = true;
			return this.M_displayOrder;
		}
		
		/**
		 * 表示順序
		 * 
		 * @property DisplayOrder
		 * @type int?
		 * @public
		 */
		public int? DisplayOrder
		{
			get { return this.Get_displayOrder(); }
			set { this.Set_displayOrder(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Archive#N_sizeMib
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
		 * @return {int?}
		 */
		private int? Get_sizeMib()
		{
			return this.M_sizeMib;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_sizeMib
		 * @private
		 * @ignore
		 * @param {int?} v
		 * @return {int?}
		 */
		private int? Set_sizeMib(int? v)
		{
			Util.ValidateType(v, "int");
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Archive#Set_sizeMib");
			};
			this.M_sizeMib = v;
			this.N_sizeMib = true;
			return this.M_sizeMib;
		}
		
		/**
		 * サイズ[MiB]
		 * 
		 * @property SizeMib
		 * @type int?
		 * @public
		 */
		public int? SizeMib
		{
			get { return this.Get_sizeMib(); }
			set { this.Set_sizeMib(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Archive#N_serviceClass
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
		 * @member saklient.cloud.resources.Archive#N_plan
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
		 * プラン
		 * 
		 * @property Plan
		 * @type DiskPlan
		 * @readOnly
		 * @public
		 */
		public DiskPlan Plan
		{
			get { return this.Get_plan(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Archive#N_availability
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
			if (Util.ExistsPath(r, "Scope")) {
				this.M_scope = Util.GetByPath(r, "Scope") == null ? null : "" + Util.GetByPath(r, "Scope");
			}
			else {
				this.M_scope = null;
				this.IsIncomplete = true;
			};
			this.N_scope = false;
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
			if (Util.ExistsPath(r, "DisplayOrder")) {
				this.M_displayOrder = Util.GetByPath(r, "DisplayOrder") == null ? null : System.Convert.ToInt32("" + Util.GetByPath(r, "DisplayOrder"));
			}
			else {
				this.M_displayOrder = null;
				this.IsIncomplete = true;
			};
			this.N_displayOrder = false;
			if (Util.ExistsPath(r, "SizeMB")) {
				this.M_sizeMib = Util.GetByPath(r, "SizeMB") == null ? null : System.Convert.ToInt32("" + Util.GetByPath(r, "SizeMB"));
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
			if (withClean || this.N_scope) {
				Util.SetByPath(ret, "Scope", this.M_scope);
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
			if (withClean || this.N_displayOrder) {
				Util.SetByPath(ret, "DisplayOrder", this.M_displayOrder);
			};
			if (withClean || this.N_sizeMib) {
				Util.SetByPath(ret, "SizeMB", this.M_sizeMib);
			};
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			};
			if (withClean || this.N_plan) {
				Util.SetByPath(ret, "Plan", withClean ? (this.M_plan == null ? null : this.M_plan.ApiSerialize(withClean)) : (this.M_plan == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_plan.ApiSerializeID()));
			};
			if (withClean || this.N_availability) {
				Util.SetByPath(ret, "Availability", this.M_availability);
			};
			if (missing.Length > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Archive creation: " + string.Join(", ", missing));
			};
			return ret;
		}
		
	}
	
}
