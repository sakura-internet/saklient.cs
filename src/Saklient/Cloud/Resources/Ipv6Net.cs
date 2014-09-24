using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Swytch = Saklient.Cloud.Resources.Swytch;

namespace Saklient.Cloud.Resources
{

	/// <summary>IPv6ネットワークの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Ipv6Net : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>ネットワークプレフィックス
		/// </summary>
		internal string M_prefix;
		
		/// <summary>ネットワークプレフィックス長
		/// </summary>
		internal long? M_prefixLen;
		
		/// <summary>このネットワーク範囲における最後のIPv6アドレス
		/// </summary>
		internal string M_prefixTail;
		
		internal override string _ApiPath()
		{
			return "/ipv6net";
		}
		
		internal override string _RootKey()
		{
			return "IPv6Net";
		}
		
		internal override string _RootKeyM()
		{
			return "IPv6Nets";
		}
		
		public override string _ClassName()
		{
			return "Ipv6Net";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/// <summary>最新のリソース情報を再取得します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Swytch Reload()
		{
			return ((Swytch)(this._Reload()));
		}
		
		public Ipv6Net(Client client, object obj, bool wrapped=false) : base(client)
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
		
		private bool N_prefix = false;
		
		private string Get_prefix()
		{
			return this.M_prefix;
		}
		
		/// <summary>ネットワークプレフィックス
		/// </summary>
		public string Prefix
		{
			get { return this.Get_prefix(); }
		}
		
		private bool N_prefixLen = false;
		
		private long? Get_prefixLen()
		{
			return this.M_prefixLen;
		}
		
		/// <summary>ネットワークプレフィックス長
		/// </summary>
		public long? PrefixLen
		{
			get { return this.Get_prefixLen(); }
		}
		
		private bool N_prefixTail = false;
		
		private string Get_prefixTail()
		{
			return this.M_prefixTail;
		}
		
		/// <summary>このネットワーク範囲における最後のIPv6アドレス
		/// </summary>
		public string PrefixTail
		{
			get { return this.Get_prefixTail(); }
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
			if (Util.ExistsPath(r, "IPv6Prefix")) {
				this.M_prefix = Util.GetByPath(r, "IPv6Prefix") == null ? null : "" + Util.GetByPath(r, "IPv6Prefix");
			}
			else {
				this.M_prefix = null;
				this.IsIncomplete = true;
			}
			this.N_prefix = false;
			if (Util.ExistsPath(r, "IPv6PrefixLen")) {
				this.M_prefixLen = Util.GetByPath(r, "IPv6PrefixLen") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "IPv6PrefixLen"));
			}
			else {
				this.M_prefixLen = null;
				this.IsIncomplete = true;
			}
			this.N_prefixLen = false;
			if (Util.ExistsPath(r, "IPv6PrefixTail")) {
				this.M_prefixTail = Util.GetByPath(r, "IPv6PrefixTail") == null ? null : "" + Util.GetByPath(r, "IPv6PrefixTail");
			}
			else {
				this.M_prefixTail = null;
				this.IsIncomplete = true;
			}
			this.N_prefixTail = false;
		}
		
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_prefix) {
				Util.SetByPath(ret, "IPv6Prefix", this.M_prefix);
			}
			if (withClean || this.N_prefixLen) {
				Util.SetByPath(ret, "IPv6PrefixLen", this.M_prefixLen);
			}
			if (withClean || this.N_prefixTail) {
				Util.SetByPath(ret, "IPv6PrefixTail", this.M_prefixTail);
			}
			return ret;
		}
		
	}
	
}
