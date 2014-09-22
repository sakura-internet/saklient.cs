using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using EStorageClass = Saklient.Cloud.Enums.EStorageClass;

namespace Saklient.Cloud.Resources
{

	/**
	 * ディスクプラン情報の1レコードに対応するクラス。
	 * 
	 * @module saklient.cloud.resources.DiskPlan
	 * @class DiskPlan
	 * @constructor
	 * @extends Resource
	 */
	public class DiskPlan : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.DiskPlan#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.DiskPlan#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * ストレージクラス {@link EStorageClass}
		 * 
		 * @member saklient.cloud.resources.DiskPlan#M_storageClass
		 * @type string
		 * @internal
		 */
		internal string M_storageClass;
		
		/**
		 * @private
		 * @method _ApiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _ApiPath()
		{
			return "/product/disk";
		}
		
		/**
		 * @private
		 * @method _RootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _RootKey()
		{
			return "DiskPlan";
		}
		
		/**
		 * @private
		 * @method _RootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _RootKeyM()
		{
			return "DiskPlans";
		}
		
		/**
		 * @private
		 * @method _ClassName
		 * @ignore
		 * @return {string}
		 */
		public override string _ClassName()
		{
			return "DiskPlan";
		}
		
		/**
		 * @private
		 * @method _Id
		 * @ignore
		 * @return {string}
		 */
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 */
		public DiskPlan(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * @member saklient.cloud.resources.DiskPlan#N_id
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
		 * @member saklient.cloud.resources.DiskPlan#N_name
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
		 * @member saklient.cloud.resources.DiskPlan#N_storageClass
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_storageClass = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_storageClass
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_storageClass()
		{
			return this.M_storageClass;
		}
		
		/**
		 * ストレージクラス {@link EStorageClass}
		 * 
		 * @property StorageClass
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string StorageClass
		{
			get { return this.Get_storageClass(); }
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
			if (Util.ExistsPath(r, "Name")) {
				this.M_name = Util.GetByPath(r, "Name") == null ? null : "" + Util.GetByPath(r, "Name");
			}
			else {
				this.M_name = null;
				this.IsIncomplete = true;
			}
			this.N_name = false;
			if (Util.ExistsPath(r, "StorageClass")) {
				this.M_storageClass = Util.GetByPath(r, "StorageClass") == null ? null : "" + Util.GetByPath(r, "StorageClass");
			}
			else {
				this.M_storageClass = null;
				this.IsIncomplete = true;
			}
			this.N_storageClass = false;
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
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_name) {
				Util.SetByPath(ret, "Name", this.M_name);
			}
			if (withClean || this.N_storageClass) {
				Util.SetByPath(ret, "StorageClass", this.M_storageClass);
			}
			return ret;
		}
		
	}
	
}
