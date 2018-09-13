using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;

namespace Saklient.Cloud.Resources
{

	/// <summary>サーバプラン情報の1レコードに対応するクラス。
	/// </summary>
	public class ServerPlan : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		/// <summary>仮想コア数
		/// </summary>
		internal long? M_cpu;
		
		/// <summary>メモリ容量[MiB]
		/// </summary>
		internal long? M_memoryMib;
		
		/// <summary>サービスクラス
		/// </summary>
		internal string M_serviceClass;
		
		internal override string _ApiPath()
		{
			return "/product/server";
		}
		
		internal override string _RootKey()
		{
			return "ServerPlan";
		}
		
		internal override string _RootKeyM()
		{
			return "ServerPlans";
		}
		
		public override string _ClassName()
		{
			return "ServerPlan";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		public ServerPlan(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		internal long? Get_memoryGib()
		{
			long? memoryMib = this.Get_memoryMib();
			return memoryMib == null ? null : memoryMib >> 10;
		}
		
		public long? MemoryGib
		{
			get { return this.Get_memoryGib(); }
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
		
		private bool N_cpu = false;
		
		private long? Get_cpu()
		{
			return this.M_cpu;
		}
		
		/// <summary>仮想コア数
		/// </summary>
		public long? Cpu
		{
			get { return this.Get_cpu(); }
		}
		
		private bool N_memoryMib = false;
		
		private long? Get_memoryMib()
		{
			return this.M_memoryMib;
		}
		
		/// <summary>メモリ容量[MiB]
		/// </summary>
		public long? MemoryMib
		{
			get { return this.Get_memoryMib(); }
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
			if (Util.ExistsPath(r, "CPU")) {
				this.M_cpu = Util.GetByPath(r, "CPU") == null ? System.Convert.ToInt64(null) : (long)System.Convert.ToInt64(""+"" + Util.GetByPath(r, "CPU"));
			}
			else {
				this.M_cpu = null;
				this.IsIncomplete = true;
			}
			this.N_cpu = false;
			if (Util.ExistsPath(r, "MemoryMB")) {
				this.M_memoryMib = Util.GetByPath(r, "MemoryMB") == null ? System.Convert.ToInt64(null) : (long)System.Convert.ToInt64(""+"" + Util.GetByPath(r, "MemoryMB"));
			}
			else {
				this.M_memoryMib = null;
				this.IsIncomplete = true;
			}
			this.N_memoryMib = false;
			if (Util.ExistsPath(r, "ServiceClass")) {
				this.M_serviceClass = Util.GetByPath(r, "ServiceClass") == null ? ((string)(null)) : "" + Util.GetByPath(r, "ServiceClass");
			}
			else {
				this.M_serviceClass = null;
				this.IsIncomplete = true;
			}
			this.N_serviceClass = false;
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
			if (withClean || this.N_cpu) {
				Util.SetByPath(ret, "CPU", this.M_cpu);
			}
			if (withClean || this.N_memoryMib) {
				Util.SetByPath(ret, "MemoryMB", this.M_memoryMib);
			}
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			}
			return ret;
		}
		
	}
	
}
