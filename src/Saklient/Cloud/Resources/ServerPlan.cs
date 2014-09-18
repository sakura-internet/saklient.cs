using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;

namespace Saklient.Cloud.Resources
{

	/**
	 * サーバプラン情報の1レコードに対応するクラス。
	 * 
	 * @module saklient.cloud.resources.ServerPlan
	 * @class ServerPlan
	 * @constructor
	 * @extends Resource
	 */
	public class ServerPlan : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.ServerPlan#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * 名前
		 * 
		 * @member saklient.cloud.resources.ServerPlan#M_name
		 * @type string
		 * @internal
		 */
		internal string M_name;
		
		/**
		 * 仮想コア数
		 * 
		 * @member saklient.cloud.resources.ServerPlan#M_cpu
		 * @type long?
		 * @internal
		 */
		internal long? M_cpu;
		
		/**
		 * メモリ容量[MiB]
		 * 
		 * @member saklient.cloud.resources.ServerPlan#M_memoryMib
		 * @type long?
		 * @internal
		 */
		internal long? M_memoryMib;
		
		/**
		 * サービスクラス
		 * 
		 * @member saklient.cloud.resources.ServerPlan#M_serviceClass
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
			return "/product/server";
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
			return "ServerPlan";
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
			return "ServerPlans";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "ServerPlan";
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
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 */
		public ServerPlan(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "object");
			Util.ValidateType(wrapped, "bool");
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * @method Get_memoryGib
		 * @internal
		 * @ignore
		 * @return {long?}
		 */
		internal long? Get_memoryGib()
		{
			long? memoryMib = this.Get_memoryMib();
			return memoryMib == null ? null : memoryMib >> 10;
		}
		
		/**
		 * @property MemoryGib
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? MemoryGib
		{
			get { return this.Get_memoryGib(); }
		}
		
		/**
		 * @member saklient.cloud.resources.ServerPlan#N_id
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
		 * @member saklient.cloud.resources.ServerPlan#N_name
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
		 * @member saklient.cloud.resources.ServerPlan#N_cpu
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_cpu = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_cpu
		 * @private
		 * @ignore
		 * @return {long?}
		 */
		private long? Get_cpu()
		{
			return this.M_cpu;
		}
		
		/**
		 * 仮想コア数
		 * 
		 * @property Cpu
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? Cpu
		{
			get { return this.Get_cpu(); }
		}
		
		/**
		 * @member saklient.cloud.resources.ServerPlan#N_memoryMib
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_memoryMib = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_memoryMib
		 * @private
		 * @ignore
		 * @return {long?}
		 */
		private long? Get_memoryMib()
		{
			return this.M_memoryMib;
		}
		
		/**
		 * メモリ容量[MiB]
		 * 
		 * @property MemoryMib
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? MemoryMib
		{
			get { return this.Get_memoryMib(); }
		}
		
		/**
		 * @member saklient.cloud.resources.ServerPlan#N_serviceClass
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
			if (Util.ExistsPath(r, "Name")) {
				this.M_name = Util.GetByPath(r, "Name") == null ? null : "" + Util.GetByPath(r, "Name");
			}
			else {
				this.M_name = null;
				this.IsIncomplete = true;
			};
			this.N_name = false;
			if (Util.ExistsPath(r, "CPU")) {
				this.M_cpu = Util.GetByPath(r, "CPU") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "CPU"));
			}
			else {
				this.M_cpu = null;
				this.IsIncomplete = true;
			};
			this.N_cpu = false;
			if (Util.ExistsPath(r, "MemoryMB")) {
				this.M_memoryMib = Util.GetByPath(r, "MemoryMB") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "MemoryMB"));
			}
			else {
				this.M_memoryMib = null;
				this.IsIncomplete = true;
			};
			this.N_memoryMib = false;
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
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			};
			if (withClean || this.N_name) {
				Util.SetByPath(ret, "Name", this.M_name);
			};
			if (withClean || this.N_cpu) {
				Util.SetByPath(ret, "CPU", this.M_cpu);
			};
			if (withClean || this.N_memoryMib) {
				Util.SetByPath(ret, "MemoryMB", this.M_memoryMib);
			};
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			};
			return ret;
		}
		
	}
	
}
