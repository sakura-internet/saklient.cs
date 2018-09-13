using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;

namespace Saklient.Cloud.Resources
{

	/// <summary>ライセンス種別情報。
	/// </summary>
	public class CommonServiceProvider : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>クラス <see cref="ECommonServiceClass" />
		/// </summary>
		internal string M_clazz;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		internal override string _ApiPath()
		{
			return "/commonserviceprovider";
		}
		
		internal override string _RootKey()
		{
			return "CommonServiceProvider";
		}
		
		internal override string _RootKeyM()
		{
			return "CommonServiceProviders";
		}
		
		public override string _ClassName()
		{
			return "CommonServiceProvider";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		public CommonServiceProvider(Client client, object obj, bool wrapped=false) : base(client)
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
		
		private bool N_clazz = false;
		
		private string Get_clazz()
		{
			return this.M_clazz;
		}
		
		/// <summary>クラス <see cref="ECommonServiceClass" />
		/// </summary>
		public string Clazz
		{
			get { return this.Get_clazz(); }
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
		}
		
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_clazz) {
				Util.SetByPath(ret, "Class", this.M_clazz);
			}
			if (withClean || this.N_name) {
				Util.SetByPath(ret, "Name", this.M_name);
			}
			return ret;
		}
		
	}
	
}
