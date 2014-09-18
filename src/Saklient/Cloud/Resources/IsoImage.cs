using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using FtpInfo = Saklient.Cloud.Resources.FtpInfo;
using EScope = Saklient.Cloud.Enums.EScope;
using SaklientException = Saklient.Errors.SaklientException;

namespace Saklient.Cloud.Resources
{

	/**
	 * ISOイメージの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.IsoImage
	 * @class IsoImage
	 * @constructor
	 * @extends Resource
	 */
	public class IsoImage : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.IsoImage#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * スコープ {@link EScope}
		 * 
		 * @member saklient.cloud.resources.IsoImage#M_scope
		 * @type string
		 * @internal
		 */
		internal string M_scope;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.IsoImage#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * 説明
		 * 
		 * @member saklient.cloud.resources.IsoImage#M_description
		 * @type string
		 * @internal
		 */
		internal string M_description;
		
		/**
		 * タグ
		 * 
		 * @member saklient.cloud.resources.IsoImage#M_tags
		 * @type System.Collections.Generic.List<string>
		 * @internal
		 */
		internal System.Collections.Generic.List<string> M_tags;
		
		/**
		 * アイコン
		 * 
		 * @member saklient.cloud.resources.IsoImage#M_icon
		 * @type Icon
		 * @internal
		 */
		internal Icon M_icon;
		
		/**
		 * 表示順序
		 * 
		 * @member saklient.cloud.resources.IsoImage#M_displayOrder
		 * @type long?
		 * @internal
		 */
		internal long? M_displayOrder;
		
		/**
		 * サイズ[MiB]
		 * 
		 * @member saklient.cloud.resources.IsoImage#M_sizeMib
		 * @type long?
		 * @internal
		 */
		internal long? M_sizeMib;
		
		/**
		 * サービスクラス
		 * 
		 * @member saklient.cloud.resources.IsoImage#M_serviceClass
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
			return "/cdrom";
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
			return "CDROM";
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
			return "CDROMs";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "IsoImage";
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
		 * @return {IsoImage} this
		 */
		public IsoImage Save()
		{
			return ((IsoImage)(this._save()));
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
		 * @chainable
		 * @public
		 * @return {IsoImage} this
		 */
		public IsoImage Reload()
		{
			return ((IsoImage)(this._reload()));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 */
		public IsoImage(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "object");
			Util.ValidateType(wrapped, "bool");
			this.ApiDeserialize(obj, wrapped);
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
			if (root == null) {
				return;
			};
			if ((root as System.Collections.Generic.Dictionary<string, object>).ContainsKey("FTPServer")) {
				object ftp = (root as System.Collections.Generic.Dictionary<string, object>)["FTPServer"];
				if (ftp != null) {
					this._ftpInfo = new FtpInfo(ftp);
				};
			};
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
		 * @member saklient.cloud.resources.IsoImage#_ftpInfo
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
		 * FTPSを開始し、イメージファイルをアップロード・ダウンロードできる状態にします。
		 * 
		 * アカウント情報は、ftpInfo プロパティから取得することができます。
		 * 
		 * @method OpenFtp
		 * @chainable
		 * @public
		 * @param {bool} reset=false 既にFTPSが開始されているとき、trueを指定してこのメソッドを呼ぶことでパスワードを再設定します。
		 * @return {IsoImage} this
		 */
		public IsoImage OpenFtp(bool reset=false)
		{
			Util.ValidateType(reset, "bool");
			string path = this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/ftp";
			object q = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(q, "ChangePassword", reset);
			object result = this._client.Request("PUT", path, q);
			this._onAfterApiDeserialize(null, result);
			return this;
		}
		
		/**
		 * FTPSを終了し、ISOイメージを利用可能な状態にします。
		 * 
		 * @method CloseFtp
		 * @chainable
		 * @public
		 * @return {IsoImage} this
		 */
		public IsoImage CloseFtp()
		{
			string path = this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/ftp";
			this._client.Request("DELETE", path);
			this._ftpInfo = null;
			return this;
		}
		
		/**
		 * @member saklient.cloud.resources.IsoImage#N_id
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
		 * @member saklient.cloud.resources.IsoImage#N_scope
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
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_scope
		 * @private
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		private string Set_scope(string v)
		{
			Util.ValidateType(v, "string");
			this.M_scope = v;
			this.N_scope = true;
			return this.M_scope;
		}
		
		/**
		 * スコープ {@link EScope}
		 * 
		 * @property Scope
		 * @type string
		 * @public
		 */
		public string Scope
		{
			get { return this.Get_scope(); }
			set { this.Set_scope(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.IsoImage#N_name
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
		 * @member saklient.cloud.resources.IsoImage#N_description
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
		 * @member saklient.cloud.resources.IsoImage#N_tags
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
		 * @member saklient.cloud.resources.IsoImage#N_icon
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
		 * @member saklient.cloud.resources.IsoImage#N_displayOrder
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
		 * @return {long?}
		 */
		private long? Get_displayOrder()
		{
			return this.M_displayOrder;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_displayOrder
		 * @private
		 * @ignore
		 * @param {long?} v
		 * @return {long?}
		 */
		private long? Set_displayOrder(long? v)
		{
			Util.ValidateType(v, "long");
			this.M_displayOrder = v;
			this.N_displayOrder = true;
			return this.M_displayOrder;
		}
		
		/**
		 * 表示順序
		 * 
		 * @property DisplayOrder
		 * @type long?
		 * @public
		 */
		public long? DisplayOrder
		{
			get { return this.Get_displayOrder(); }
			set { this.Set_displayOrder(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.IsoImage#N_sizeMib
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
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.IsoImage#Set_sizeMib");
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
		 * @member saklient.cloud.resources.IsoImage#N_serviceClass
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
			if (Util.ExistsPath(r, "DisplayOrder")) {
				this.M_displayOrder = Util.GetByPath(r, "DisplayOrder") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "DisplayOrder"));
			}
			else {
				this.M_displayOrder = null;
				this.IsIncomplete = true;
			};
			this.N_displayOrder = false;
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
			if (withClean || this.N_displayOrder) {
				Util.SetByPath(ret, "DisplayOrder", this.M_displayOrder);
			};
			if (withClean || this.N_sizeMib) {
				Util.SetByPath(ret, "SizeMB", this.M_sizeMib);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("sizeMib");
				};
			};
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			};
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the IsoImage creation: " + string.Join(", ", (missing).ToArray()));
			};
			return ret;
		}
		
	}
	
}
