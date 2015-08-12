using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Swytch = Saklient.Cloud.Resources.Swytch;
using IfaceActivity = Saklient.Cloud.Resources.IfaceActivity;

namespace Saklient.Cloud.Resources
{

	/// <summary>インタフェースの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Iface : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>MACアドレス
		/// </summary>
		internal string M_macAddress;
		
		/// <summary>IPv4アドレス（共有セグメントによる自動割当）
		/// </summary>
		internal string M_ipAddress;
		
		/// <summary>ユーザ設定IPv4アドレス
		/// </summary>
		internal string M_userIpAddress;
		
		/// <summary>このインタフェースが取り付けられているサーバのID
		/// </summary>
		internal string M_serverId;
		
		internal override string _ApiPath()
		{
			return "/interface";
		}
		
		internal override string _RootKey()
		{
			return "Interface";
		}
		
		internal override string _RootKeyM()
		{
			return "Interfaces";
		}
		
		public override string _ClassName()
		{
			return "Iface";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Iface Save()
		{
			return ((Iface)(this._Save()));
		}
		
		/// <summary>最新のリソース情報を再取得します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Iface Reload()
		{
			return ((Iface)(this._Reload()));
		}
		
		internal IfaceActivity _Activity;
		
		public IfaceActivity Get_activity()
		{
			return this._Activity;
		}
		
		/// <summary>アクティビティ
		/// </summary>
		public IfaceActivity Activity
		{
			get { return this.Get_activity(); }
		}
		
		public Iface(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this._Activity = new IfaceActivity(client);
			this.ApiDeserialize(obj, wrapped);
		}
		
		internal override void _OnAfterApiDeserialize(object r, object root)
		{
			if (r != null) {
				this._Activity.SetSourceId(this._Id());
			}
		}
		
		/// <summary>スイッチに接続します。
		/// 
		/// <param name="swytch">接続先のスイッチ。</param>
		/// <returns>this</returns>
		/// </summary>
		public Iface ConnectToSwytch(Swytch swytch)
		{
			this._Client.Request("PUT", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/to/switch/" + Util.UrlEncode(swytch._Id()));
			return this.Reload();
		}
		
		/// <summary>共有セグメントに接続します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Iface ConnectToSharedSegment()
		{
			this._Client.Request("PUT", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/to/switch/shared");
			return this.Reload();
		}
		
		/// <summary>スイッチから切断します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Iface DisconnectFromSwytch()
		{
			this._Client.Request("DELETE", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/to/switch");
			return this.Reload();
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
		
		private bool N_macAddress = false;
		
		private string Get_macAddress()
		{
			return this.M_macAddress;
		}
		
		/// <summary>MACアドレス
		/// </summary>
		public string MacAddress
		{
			get { return this.Get_macAddress(); }
		}
		
		private bool N_ipAddress = false;
		
		private string Get_ipAddress()
		{
			return this.M_ipAddress;
		}
		
		/// <summary>IPv4アドレス（共有セグメントによる自動割当）
		/// </summary>
		public string IpAddress
		{
			get { return this.Get_ipAddress(); }
		}
		
		private bool N_userIpAddress = false;
		
		private string Get_userIpAddress()
		{
			return this.M_userIpAddress;
		}
		
		private string Set_userIpAddress(string v)
		{
			this.M_userIpAddress = v;
			this.N_userIpAddress = true;
			return this.M_userIpAddress;
		}
		
		/// <summary>ユーザ設定IPv4アドレス
		/// </summary>
		public string UserIpAddress
		{
			get { return this.Get_userIpAddress(); }
			set { this.Set_userIpAddress(value); }
		}
		
		private bool N_serverId = false;
		
		private string Get_serverId()
		{
			return this.M_serverId;
		}
		
		private string Set_serverId(string v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Iface#Set_serverId");
			}
			this.M_serverId = v;
			this.N_serverId = true;
			return this.M_serverId;
		}
		
		/// <summary>このインタフェースが取り付けられているサーバのID
		/// </summary>
		public string ServerId
		{
			get { return this.Get_serverId(); }
			set { this.Set_serverId(value); }
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
				this.M_id = Util.GetByPath(r, "ID") == null ? ((string)(null)) : "" + Util.GetByPath(r, "ID");
			}
			else {
				this.M_id = null;
				this.IsIncomplete = true;
			}
			this.N_id = false;
			if (Util.ExistsPath(r, "MACAddress")) {
				this.M_macAddress = Util.GetByPath(r, "MACAddress") == null ? ((string)(null)) : "" + Util.GetByPath(r, "MACAddress");
			}
			else {
				this.M_macAddress = null;
				this.IsIncomplete = true;
			}
			this.N_macAddress = false;
			if (Util.ExistsPath(r, "IPAddress")) {
				this.M_ipAddress = Util.GetByPath(r, "IPAddress") == null ? ((string)(null)) : "" + Util.GetByPath(r, "IPAddress");
			}
			else {
				this.M_ipAddress = null;
				this.IsIncomplete = true;
			}
			this.N_ipAddress = false;
			if (Util.ExistsPath(r, "UserIPAddress")) {
				this.M_userIpAddress = Util.GetByPath(r, "UserIPAddress") == null ? ((string)(null)) : "" + Util.GetByPath(r, "UserIPAddress");
			}
			else {
				this.M_userIpAddress = null;
				this.IsIncomplete = true;
			}
			this.N_userIpAddress = false;
			if (Util.ExistsPath(r, "Server.ID")) {
				this.M_serverId = Util.GetByPath(r, "Server.ID") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Server.ID");
			}
			else {
				this.M_serverId = null;
				this.IsIncomplete = true;
			}
			this.N_serverId = false;
		}
		
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			System.Collections.Generic.List<string> missing = new System.Collections.Generic.List<string> {  };
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_macAddress) {
				Util.SetByPath(ret, "MACAddress", this.M_macAddress);
			}
			if (withClean || this.N_ipAddress) {
				Util.SetByPath(ret, "IPAddress", this.M_ipAddress);
			}
			if (withClean || this.N_userIpAddress) {
				Util.SetByPath(ret, "UserIPAddress", this.M_userIpAddress);
			}
			if (withClean || this.N_serverId) {
				Util.SetByPath(ret, "Server.ID", this.M_serverId);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("serverId");
				}
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Iface creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
