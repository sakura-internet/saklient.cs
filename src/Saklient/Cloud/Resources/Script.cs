using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using EScope = Saklient.Cloud.Enums.EScope;
using EScriptClass = Saklient.Cloud.Enums.EScriptClass;

namespace Saklient.Cloud.Resources
{

	/**
	 * スクリプトの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Script
	 * @class Script
	 * @constructor
	 * @extends Resource
	 */
	public class Script : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Script#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * スコープ {@link EScope}
		 * 
		 * @member saklient.cloud.resources.Script#M_scope
		 * @type string
		 * @internal
		 */
		internal string M_scope;
		
		/**
		 * クラス {@link EScriptClass}
		 * 
		 * @member saklient.cloud.resources.Script#M_clazz
		 * @type string
		 * @internal
		 */
		internal string M_clazz;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.Script#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * 説明
		 * 
		 * @member saklient.cloud.resources.Script#M_description
		 * @type string
		 * @internal
		 */
		internal string M_description;
		
		/**
		 * タグ
		 * 
		 * @member saklient.cloud.resources.Script#M_tags
		 * @type System.Collections.Generic.List<string>
		 * @internal
		 */
		internal System.Collections.Generic.List<string> M_tags;
		
		/**
		 * アイコン
		 * 
		 * @member saklient.cloud.resources.Script#M_icon
		 * @type Icon
		 * @internal
		 */
		internal Icon M_icon;
		
		/**
		 * 内容
		 * 
		 * @member saklient.cloud.resources.Script#M_content
		 * @type string
		 * @internal
		 */
		internal string M_content;
		
		/**
		 * 注釈
		 * 
		 * @member saklient.cloud.resources.Script#M_annotation
		 * @type object
		 * @internal
		 */
		internal object M_annotation;
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/note";
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
			return "Note";
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
			return "Notes";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Script";
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
		 * @return {Script} this
		 */
		public Script Save()
		{
			return ((Script)(this._save()));
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
		 * @chainable
		 * @public
		 * @return {Script} this
		 */
		public Script Reload()
		{
			return ((Script)(this._reload()));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 */
		public Script(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "object");
			Util.ValidateType(wrapped, "bool");
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * @member saklient.cloud.resources.Script#N_id
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
		 * @member saklient.cloud.resources.Script#N_scope
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
		 * @member saklient.cloud.resources.Script#N_clazz
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
			this.M_clazz = v;
			this.N_clazz = true;
			return this.M_clazz;
		}
		
		/**
		 * クラス {@link EScriptClass}
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
		 * @member saklient.cloud.resources.Script#N_name
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
		 * 名前
		 * 
		 * @property Name
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Name
		{
			get { return this.Get_name(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Script#N_description
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
		 * @member saklient.cloud.resources.Script#N_tags
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
		 * @member saklient.cloud.resources.Script#N_icon
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
		 * @member saklient.cloud.resources.Script#N_content
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_content = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_content
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_content()
		{
			return this.M_content;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_content
		 * @private
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		private string Set_content(string v)
		{
			Util.ValidateType(v, "string");
			this.M_content = v;
			this.N_content = true;
			return this.M_content;
		}
		
		/**
		 * 内容
		 * 
		 * @property Content
		 * @type string
		 * @public
		 */
		public string Content
		{
			get { return this.Get_content(); }
			set { this.Set_content(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Script#N_annotation
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_annotation = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_annotation
		 * @private
		 * @ignore
		 * @return {object}
		 */
		private object Get_annotation()
		{
			return this.M_annotation;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_annotation
		 * @private
		 * @ignore
		 * @param {object} v
		 * @return {object}
		 */
		private object Set_annotation(object v)
		{
			Util.ValidateType(v, "object");
			this.M_annotation = v;
			this.N_annotation = true;
			return this.M_annotation;
		}
		
		/**
		 * 注釈
		 * 
		 * @property Annotation
		 * @type object
		 * @public
		 */
		public object Annotation
		{
			get { return this.Get_annotation(); }
			set { this.Set_annotation(value); }
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
			if (Util.ExistsPath(r, "Content")) {
				this.M_content = Util.GetByPath(r, "Content") == null ? null : "" + Util.GetByPath(r, "Content");
			}
			else {
				this.M_content = null;
				this.IsIncomplete = true;
			};
			this.N_content = false;
			if (Util.ExistsPath(r, "Remark")) {
				this.M_annotation = Util.GetByPath(r, "Remark");
			}
			else {
				this.M_annotation = null;
				this.IsIncomplete = true;
			};
			this.N_annotation = false;
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
			if (withClean || this.N_clazz) {
				Util.SetByPath(ret, "Class", this.M_clazz);
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
			if (withClean || this.N_content) {
				Util.SetByPath(ret, "Content", this.M_content);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("content");
				};
			};
			if (withClean || this.N_annotation) {
				Util.SetByPath(ret, "Remark", this.M_annotation);
			};
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Script creation: " + string.Join(", ", (missing).ToArray()));
			};
			return ret;
		}
		
	}
	
}
