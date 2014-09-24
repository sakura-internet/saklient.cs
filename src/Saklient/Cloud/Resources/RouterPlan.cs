using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;

namespace Saklient.Cloud.Resources
{

	/// <summary>ルータ帯域プラン情報の1レコードに対応するクラス。
	/// </summary>
	public class RouterPlan : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		/// <summary>帯域幅
		/// </summary>
		internal long? M_bandWidthMbps;
		
		/// <summary>サービスクラス
		/// </summary>
		internal string M_serviceClass;
		
		internal override string _ApiPath()
		{
			return "/product/internet";
		}
		
		internal override string _RootKey()
		{
			return "InternetPlan";
		}
		
		internal override string _RootKeyM()
		{
			return "InternetPlans";
		}
		
		public override string _ClassName()
		{
			return "RouterPlan";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		public RouterPlan(Client client, object obj, bool wrapped=false) : base(client)
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
		
		private bool N_bandWidthMbps = false;
		
		private long? Get_bandWidthMbps()
		{
			return this.M_bandWidthMbps;
		}
		
		/// <summary>帯域幅
		/// </summary>
		public long? BandWidthMbps
		{
			get { return this.Get_bandWidthMbps(); }
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
		/// 
		/// <param name="r" />
		/// </summary>
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
			if (Util.ExistsPath(r, "BandWidthMbps")) {
				this.M_bandWidthMbps = Util.GetByPath(r, "BandWidthMbps") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "BandWidthMbps"));
			}
			else {
				this.M_bandWidthMbps = null;
				this.IsIncomplete = true;
			}
			this.N_bandWidthMbps = false;
			if (Util.ExistsPath(r, "ServiceClass")) {
				this.M_serviceClass = Util.GetByPath(r, "ServiceClass") == null ? null : "" + Util.GetByPath(r, "ServiceClass");
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
			if (withClean || this.N_bandWidthMbps) {
				Util.SetByPath(ret, "BandWidthMbps", this.M_bandWidthMbps);
			}
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			}
			return ret;
		}
		
	}
	
}
