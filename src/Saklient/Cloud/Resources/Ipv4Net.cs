using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Swytch = Saklient.Cloud.Resources.Swytch;
using Ipv4Range = Saklient.Cloud.Resources.Ipv4Range;

namespace Saklient.Cloud.Resources
{

	/// <summary>IPv4ネットワークの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Ipv4Net : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>ネットワークアドレス
		/// </summary>
		internal string M_address;
		
		/// <summary>マスク長
		/// </summary>
		internal long? M_maskLen;
		
		/// <summary>デフォルトルート
		/// </summary>
		internal string M_defaultRoute;
		
		/// <summary>ネクストホップ
		/// </summary>
		internal string M_nextHop;
		
		internal Ipv4Range _Range;
		
		public Ipv4Range Get_range()
		{
			return this._Range;
		}
		
		/// <summary>利用可能なIPアドレス範囲
		/// </summary>
		public Ipv4Range Range
		{
			get { return this.Get_range(); }
		}
		
		internal override string _ApiPath()
		{
			return "/subnet";
		}
		
		internal override string _RootKey()
		{
			return "Subnet";
		}
		
		internal override string _RootKeyM()
		{
			return "Subnets";
		}
		
		public override string _ClassName()
		{
			return "Ipv4Net";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}

        /// <summary>最新のリソース情報を再取得します。
        /// </summary>
        /// <returns>this</returns>
        public Swytch Reload()
		{
			return ((Swytch)(this._Reload()));
		}
		
		public Ipv4Net(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		internal override void _OnAfterApiDeserialize(object r, object root)
		{
			this._Range = null;
			object addresses = (r as System.Collections.Generic.Dictionary<string, object>)["IPAddresses"];
			if (addresses != null) {
				this._Range = new Ipv4Range(addresses);
			}
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
		
		private bool N_address = false;
		
		private string Get_address()
		{
			return this.M_address;
		}
		
		/// <summary>ネットワークアドレス
		/// </summary>
		public string Address
		{
			get { return this.Get_address(); }
		}
		
		private bool N_maskLen = false;
		
		private long? Get_maskLen()
		{
			return this.M_maskLen;
		}
		
		/// <summary>マスク長
		/// </summary>
		public long? MaskLen
		{
			get { return this.Get_maskLen(); }
		}
		
		private bool N_defaultRoute = false;
		
		private string Get_defaultRoute()
		{
			return this.M_defaultRoute;
		}
		
		/// <summary>デフォルトルート
		/// </summary>
		public string DefaultRoute
		{
			get { return this.Get_defaultRoute(); }
		}
		
		private bool N_nextHop = false;
		
		private string Get_nextHop()
		{
			return this.M_nextHop;
		}
		
		/// <summary>ネクストホップ
		/// </summary>
		public string NextHop
		{
			get { return this.Get_nextHop(); }
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
			if (Util.ExistsPath(r, "NetworkAddress")) {
				this.M_address = Util.GetByPath(r, "NetworkAddress") == null ? ((string)(null)) : "" + Util.GetByPath(r, "NetworkAddress");
			}
			else {
				this.M_address = null;
				this.IsIncomplete = true;
			}
			this.N_address = false;
			if (Util.ExistsPath(r, "NetworkMaskLen")) {
				this.M_maskLen = Util.GetByPath(r, "NetworkMaskLen") == null ? System.Convert.ToInt64(null) : (long)System.Convert.ToInt64(""+"" + Util.GetByPath(r, "NetworkMaskLen"));
			}
			else {
				this.M_maskLen = null;
				this.IsIncomplete = true;
			}
			this.N_maskLen = false;
			if (Util.ExistsPath(r, "DefaultRoute")) {
				this.M_defaultRoute = Util.GetByPath(r, "DefaultRoute") == null ? ((string)(null)) : "" + Util.GetByPath(r, "DefaultRoute");
			}
			else {
				this.M_defaultRoute = null;
				this.IsIncomplete = true;
			}
			this.N_defaultRoute = false;
			if (Util.ExistsPath(r, "NextHop")) {
				this.M_nextHop = Util.GetByPath(r, "NextHop") == null ? ((string)(null)) : "" + Util.GetByPath(r, "NextHop");
			}
			else {
				this.M_nextHop = null;
				this.IsIncomplete = true;
			}
			this.N_nextHop = false;
		}
		
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_address) {
				Util.SetByPath(ret, "NetworkAddress", this.M_address);
			}
			if (withClean || this.N_maskLen) {
				Util.SetByPath(ret, "NetworkMaskLen", this.M_maskLen);
			}
			if (withClean || this.N_defaultRoute) {
				Util.SetByPath(ret, "DefaultRoute", this.M_defaultRoute);
			}
			if (withClean || this.N_nextHop) {
				Util.SetByPath(ret, "NextHop", this.M_nextHop);
			}
			return ret;
		}
		
	}
	
}
