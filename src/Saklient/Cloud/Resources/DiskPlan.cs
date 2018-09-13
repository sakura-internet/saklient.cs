using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using EStorageClass = Saklient.Cloud.Enums.EStorageClass;

namespace Saklient.Cloud.Resources
{

	/// <summary>ディスクプラン情報の1レコードに対応するクラス。
	/// </summary>
	public class DiskPlan : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		/// <summary>ストレージクラス <see cref="Saklient.Cloud.Enums.EStorageClass" />
		/// </summary>
		internal string M_storageClass;
		
		internal override string _ApiPath()
		{
			return "/product/disk";
		}
		
		internal override string _RootKey()
		{
			return "DiskPlan";
		}
		
		internal override string _RootKeyM()
		{
			return "DiskPlans";
		}
		
		public override string _ClassName()
		{
			return "DiskPlan";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		public DiskPlan(Client client, object obj, bool wrapped=false) : base(client)
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
		
		/// <summary>名前
		/// </summary>
		public string Name
		{
			get { return this.Get_name(); }
		}
		
		private bool N_storageClass = false;
		
		private string Get_storageClass()
		{
			return this.M_storageClass;
		}
		
		/// <summary>ストレージクラス <see cref="Saklient.Cloud.Enums.EStorageClass" />
		/// </summary>
		public string StorageClass
		{
			get { return this.Get_storageClass(); }
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
			if (Util.ExistsPath(r, "StorageClass")) {
				this.M_storageClass = Util.GetByPath(r, "StorageClass") == null ? ((string)(null)) : "" + Util.GetByPath(r, "StorageClass");
			}
			else {
				this.M_storageClass = null;
				this.IsIncomplete = true;
			}
			this.N_storageClass = false;
		}
		
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
