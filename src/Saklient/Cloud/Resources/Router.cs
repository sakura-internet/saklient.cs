using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using Swytch = Saklient.Cloud.Resources.Swytch;
using Ipv4Net = Saklient.Cloud.Resources.Ipv4Net;
using Ipv6Net = Saklient.Cloud.Resources.Ipv6Net;
using Model_Swytch = Saklient.Cloud.Models.Model_Swytch;

namespace Saklient.Cloud.Resources
{

	/// <summary>ルータの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Router : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>名前
		/// </summary>
		internal string M_name;
		
		/// <summary>説明
		/// </summary>
		internal string M_description;
		
		/// <summary>ネットワークのマスク長
		/// </summary>
		internal long? M_networkMaskLen;
		
		/// <summary>帯域幅
		/// </summary>
		internal long? M_bandWidthMbps;
		
		/// <summary>スイッチ
		/// </summary>
		internal string M_swytchId;
		
		internal override string _ApiPath()
		{
			return "/internet";
		}
		
		internal override string _RootKey()
		{
			return "Internet";
		}
		
		internal override string _RootKeyM()
		{
			return "Internet";
		}
		
		public override string _ClassName()
		{
			return "Router";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Router Save()
		{
			return ((Router)(this._Save()));
		}
		
		/// <summary>最新のリソース情報を再取得します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Router Reload()
		{
			return ((Router)(this._Reload()));
		}
		
		public Router(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		/// <summary>作成中のルータが利用可能になるまで待機します。
		/// 
		/// 
		/// <param name="timeoutSec" />
		/// <param name="callback" />
		/// </summary>
		public void AfterCreate(long timeoutSec, System.Action<Router, bool> callback)
		{
			bool ret = this.SleepWhileCreating(timeoutSec);
			callback(this, ret);
		}
		
		/// <summary>作成中のルータが利用可能になるまで待機します。
		/// 
		/// <param name="timeoutSec" />
		/// <returns>成功時はtrue、タイムアウトやエラーによる失敗時はfalseを返します。</returns>
		/// </summary>
		public bool SleepWhileCreating(long timeoutSec=120)
		{
			long step = 3;
			while (0 < timeoutSec) {
				if (this.Exists()) {
					this.Reload();
					return true;
				}
				timeoutSec -= step;
				if (0 < timeoutSec) {
					Util.Sleep(step);
				}
			}
			return false;
		}
		
		/// <summary>このルータが接続されているスイッチを取得します。
		/// </summary>
		public Swytch GetSwytch()
		{
			Model_Swytch model = new Model_Swytch(this._Client);
			string id = this.Get_swytchId();
			return model.GetById(id);
		}
		
		/// <summary>このルータ＋スイッチでIPv6アドレスを有効にします。
		/// 
		/// <returns>有効化されたIPv6ネットワーク</returns>
		/// </summary>
		public Ipv6Net AddIpv6Net()
		{
			object result = this._Client.Request("POST", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/ipv6net");
			this.Reload();
			return new Ipv6Net(this._Client, (result as System.Collections.Generic.Dictionary<string, object>)["IPv6Net"]);
		}
		
		/// <summary>このルータ＋スイッチでIPv6アドレスを無効にします。
		/// 
		/// <param name="ipv6Net" />
		/// <returns>this</returns>
		/// </summary>
		public Router RemoveIpv6Net(Ipv6Net ipv6Net)
		{
			this._Client.Request("DELETE", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/ipv6net/" + ipv6Net._Id());
			this.Reload();
			return this;
		}
		
		/// <summary>このルータ＋スイッチにスタティックルートを追加します。
		/// 
		/// <param name="maskLen" />
		/// <param name="nextHop" />
		/// <returns>追加されたスタティックルート</returns>
		/// </summary>
		public Ipv4Net AddStaticRoute(long maskLen, string nextHop)
		{
			object q = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(q, "NetworkMaskLen", maskLen);
			Util.SetByPath(q, "NextHop", nextHop);
			object result = this._Client.Request("POST", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/subnet", q);
			this.Reload();
			return new Ipv4Net(this._Client, (result as System.Collections.Generic.Dictionary<string, object>)["Subnet"]);
		}
		
		/// <summary>このルータ＋スイッチからスタティックルートを削除します。
		/// 
		/// <param name="ipv4Net" />
		/// <returns>this</returns>
		/// </summary>
		public Router RemoveStaticRoute(Ipv4Net ipv4Net)
		{
			this._Client.Request("DELETE", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/subnet/" + ipv4Net._Id());
			this.Reload();
			return this;
		}
		
		/// <summary>このルータ＋スイッチの帯域プランを変更します。
		/// 
		/// 成功時はリソースIDが変わることにご注意ください。
		/// 
		/// <param name="bandWidthMbps" />
		/// <returns>this</returns>
		/// </summary>
		public Router ChangePlan(long bandWidthMbps)
		{
			string path = this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/bandwidth";
			object q = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(q, "Internet.BandWidthMbps", bandWidthMbps);
			object result = this._Client.Request("PUT", path, q);
			this.ApiDeserialize(result, true);
			return this;
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
		
		private string Set_name(string v)
		{
			this.M_name = v;
			this.N_name = true;
			return this.M_name;
		}
		
		/// <summary>名前
		/// </summary>
		public string Name
		{
			get { return this.Get_name(); }
			set { this.Set_name(value); }
		}
		
		private bool N_description = false;
		
		private string Get_description()
		{
			return this.M_description;
		}
		
		private string Set_description(string v)
		{
			this.M_description = v;
			this.N_description = true;
			return this.M_description;
		}
		
		/// <summary>説明
		/// </summary>
		public string Description
		{
			get { return this.Get_description(); }
			set { this.Set_description(value); }
		}
		
		private bool N_networkMaskLen = false;
		
		private long? Get_networkMaskLen()
		{
			return this.M_networkMaskLen;
		}
		
		private long? Set_networkMaskLen(long? v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Router#Set_networkMaskLen");
			}
			this.M_networkMaskLen = v;
			this.N_networkMaskLen = true;
			return this.M_networkMaskLen;
		}
		
		/// <summary>ネットワークのマスク長
		/// </summary>
		public long? NetworkMaskLen
		{
			get { return this.Get_networkMaskLen(); }
			set { this.Set_networkMaskLen(value); }
		}
		
		private bool N_bandWidthMbps = false;
		
		private long? Get_bandWidthMbps()
		{
			return this.M_bandWidthMbps;
		}
		
		private long? Set_bandWidthMbps(long? v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Router#Set_bandWidthMbps");
			}
			this.M_bandWidthMbps = v;
			this.N_bandWidthMbps = true;
			return this.M_bandWidthMbps;
		}
		
		/// <summary>帯域幅
		/// </summary>
		public long? BandWidthMbps
		{
			get { return this.Get_bandWidthMbps(); }
			set { this.Set_bandWidthMbps(value); }
		}
		
		private bool N_swytchId = false;
		
		private string Get_swytchId()
		{
			return this.M_swytchId;
		}
		
		/// <summary>スイッチ
		/// </summary>
		public string SwytchId
		{
			get { return this.Get_swytchId(); }
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
			if (Util.ExistsPath(r, "Description")) {
				this.M_description = Util.GetByPath(r, "Description") == null ? null : "" + Util.GetByPath(r, "Description");
			}
			else {
				this.M_description = null;
				this.IsIncomplete = true;
			}
			this.N_description = false;
			if (Util.ExistsPath(r, "NetworkMaskLen")) {
				this.M_networkMaskLen = Util.GetByPath(r, "NetworkMaskLen") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "NetworkMaskLen"));
			}
			else {
				this.M_networkMaskLen = null;
				this.IsIncomplete = true;
			}
			this.N_networkMaskLen = false;
			if (Util.ExistsPath(r, "BandWidthMbps")) {
				this.M_bandWidthMbps = Util.GetByPath(r, "BandWidthMbps") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "BandWidthMbps"));
			}
			else {
				this.M_bandWidthMbps = null;
				this.IsIncomplete = true;
			}
			this.N_bandWidthMbps = false;
			if (Util.ExistsPath(r, "Switch.ID")) {
				this.M_swytchId = Util.GetByPath(r, "Switch.ID") == null ? null : "" + Util.GetByPath(r, "Switch.ID");
			}
			else {
				this.M_swytchId = null;
				this.IsIncomplete = true;
			}
			this.N_swytchId = false;
		}
		
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			System.Collections.Generic.List<string> missing = new System.Collections.Generic.List<string> {  };
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			}
			if (withClean || this.N_name) {
				Util.SetByPath(ret, "Name", this.M_name);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("name");
				}
			}
			if (withClean || this.N_description) {
				Util.SetByPath(ret, "Description", this.M_description);
			}
			if (withClean || this.N_networkMaskLen) {
				Util.SetByPath(ret, "NetworkMaskLen", this.M_networkMaskLen);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("networkMaskLen");
				}
			}
			if (withClean || this.N_bandWidthMbps) {
				Util.SetByPath(ret, "BandWidthMbps", this.M_bandWidthMbps);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("bandWidthMbps");
				}
			}
			if (withClean || this.N_swytchId) {
				Util.SetByPath(ret, "Switch.ID", this.M_swytchId);
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Router creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
