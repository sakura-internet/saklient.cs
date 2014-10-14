using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using Disk = Saklient.Cloud.Resources.Disk;
using Iface = Saklient.Cloud.Resources.Iface;
using ServerPlan = Saklient.Cloud.Resources.ServerPlan;
using ServerInstance = Saklient.Cloud.Resources.ServerInstance;
using IsoImage = Saklient.Cloud.Resources.IsoImage;
using EServerInstanceStatus = Saklient.Cloud.Enums.EServerInstanceStatus;
using EAvailability = Saklient.Cloud.Enums.EAvailability;
using Model_Disk = Saklient.Cloud.Models.Model_Disk;
using Model_Iface = Saklient.Cloud.Models.Model_Iface;

namespace Saklient.Cloud.Resources
{

	/// <summary>サーバの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Server : Resource
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
		
		/// <summary>タグ
		/// </summary>
		internal System.Collections.Generic.List<string> M_tags;
		
		/// <summary>アイコン
		/// </summary>
		internal Icon M_icon;
		
		/// <summary>プラン
		/// </summary>
		internal ServerPlan M_plan;
		
		/// <summary>インタフェース
		/// </summary>
		internal System.Collections.Generic.List<Iface> M_ifaces;
		
		/// <summary>インスタンス情報
		/// </summary>
		internal ServerInstance M_instance;
		
		/// <summary>有効状態 <see cref="Saklient.Cloud.Enums.EAvailability" />
		/// </summary>
		internal string M_availability;
		
		internal override string _ApiPath()
		{
			return "/server";
		}
		
		internal override string _RootKey()
		{
			return "Server";
		}
		
		internal override string _RootKeyM()
		{
			return "Servers";
		}
		
		public override string _ClassName()
		{
			return "Server";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Server Save()
		{
			return ((Server)(this._Save()));
		}
		
		/// <summary>最新のリソース情報を再取得します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Server Reload()
		{
			return ((Server)(this._Reload()));
		}
		
		public Server(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		/// <summary>サーバが起動しているときtrueを返します。
		/// </summary>
		public bool IsUp()
		{
			return this.Get_instance().IsUp();
		}
		
		/// <summary>サーバが停止しているときtrueを返します。
		/// </summary>
		public bool IsDown()
		{
			return this.Get_instance().IsDown();
		}
		
		/// <summary>サーバを起動します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Server Boot()
		{
			this._Client.Request("PUT", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/power");
			return this.Reload();
		}
		
		/// <summary>サーバをシャットダウンします。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Server Shutdown()
		{
			this._Client.Request("DELETE", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/power");
			return this.Reload();
		}
		
		/// <summary>サーバを強制停止します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Server Stop()
		{
			this._Client.Request("DELETE", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/power", new System.Collections.Generic.Dictionary<string, object> { { "Force", true } });
			return this.Reload();
		}
		
		/// <summary>サーバを強制再起動します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Server Reboot()
		{
			this._Client.Request("PUT", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/reset");
			return this.Reload();
		}
		
		/// <summary>サーバが起動するまで待機します。
		/// 
		/// <param name="timeoutSec" />
		/// </summary>
		public bool SleepUntilUp(long timeoutSec=180)
		{
			return this.SleepUntil(EServerInstanceStatus.UP, timeoutSec);
		}
		
		/// <summary>サーバが停止するまで待機します。
		/// 
		/// <param name="timeoutSec" />
		/// <returns>成功時はtrue、タイムアウトやエラーによる失敗時はfalseを返します。</returns>
		/// </summary>
		public bool SleepUntilDown(long timeoutSec=180)
		{
			return this.SleepUntil(EServerInstanceStatus.DOWN, timeoutSec);
		}
		
		/// <summary>サーバが指定のステータスに遷移するまで待機します。
		/// 
		/// 
		/// <param name="status" />
		/// <param name="timeoutSec" />
		/// </summary>
		private bool SleepUntil(string status, long timeoutSec=180)
		{
			long step = 10;
			while (0 < timeoutSec) {
				this.Reload();
				string s = null;
				ServerInstance inst = this.Instance;
				if (inst != null) {
					s = inst.Status;
				}
				if (s == null) {
					s = EServerInstanceStatus.DOWN;
				}
				if (s == status) {
					return true;
				}
				timeoutSec -= step;
				if (0 < timeoutSec) {
					Util.Sleep(step);
				}
			}
			return false;
		}
		
		/// <summary>サーバプランを変更します。
		/// 
		/// 成功時はリソースIDが変わることにご注意ください。
		/// 
		/// <param name="planTo" />
		/// <returns>this</returns>
		/// </summary>
		public Server ChangePlan(ServerPlan planTo)
		{
			string path = this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/to/plan/" + Util.UrlEncode(planTo._Id());
			object result = this._Client.Request("PUT", path);
			this.ApiDeserialize(result, true);
			return this;
		}
		
		/// <summary>サーバに接続されているディスクのリストを取得します。
		/// </summary>
		public System.Collections.Generic.List<Disk> FindDisks()
		{
			Model_Disk model = new Model_Disk(this._Client);
			return model.WithServerId(this._Id()).Find();
		}
		
		/// <summary>サーバにインタフェースを1つ増設し、それを取得します。
		/// 
		/// <returns>増設されたインタフェース</returns>
		/// </summary>
		public Iface AddIface()
		{
			Model_Iface model = new Model_Iface(this._Client);
			Iface res = model.Create();
			res.ServerId = this._Id();
			return res.Save();
		}
		
		/// <summary>サーバにISOイメージを挿入します。
		/// 
		/// <param name="iso" />
		/// <returns>this</returns>
		/// </summary>
		public Server InsertIsoImage(IsoImage iso)
		{
			string path = this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/cdrom";
			object q = new System.Collections.Generic.Dictionary<string, object> { { "CDROM", new System.Collections.Generic.Dictionary<string, object> { { "ID", iso._Id() } } } };
			this._Client.Request("PUT", path, q);
			this.Reload();
			return this;
		}
		
		/// <summary>サーバに挿入されているISOイメージを排出します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Server EjectIsoImage()
		{
			string path = this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/cdrom";
			this._Client.Request("DELETE", path);
			this.Reload();
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
		
		private bool N_tags = false;
		
		private System.Collections.Generic.List<string> Get_tags()
		{
			this.N_tags = true;
			return this.M_tags;
		}
		
		private System.Collections.Generic.List<string> Set_tags(System.Collections.Generic.List<string> v)
		{
			this.M_tags = v;
			this.N_tags = true;
			return this.M_tags;
		}
		
		/// <summary>タグ
		/// </summary>
		public System.Collections.Generic.List<string> Tags
		{
			get { return this.Get_tags(); }
			set { this.Set_tags(value); }
		}
		
		private bool N_icon = false;
		
		private Icon Get_icon()
		{
			return this.M_icon;
		}
		
		private Icon Set_icon(Icon v)
		{
			this.M_icon = v;
			this.N_icon = true;
			return this.M_icon;
		}
		
		/// <summary>アイコン
		/// </summary>
		public Icon Icon
		{
			get { return this.Get_icon(); }
			set { this.Set_icon(value); }
		}
		
		private bool N_plan = false;
		
		private ServerPlan Get_plan()
		{
			return this.M_plan;
		}
		
		private ServerPlan Set_plan(ServerPlan v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Server#Set_plan");
			}
			this.M_plan = v;
			this.N_plan = true;
			return this.M_plan;
		}
		
		/// <summary>プラン
		/// </summary>
		public ServerPlan Plan
		{
			get { return this.Get_plan(); }
			set { this.Set_plan(value); }
		}
		
		private bool N_ifaces = false;
		
		private System.Collections.Generic.List<Iface> Get_ifaces()
		{
			return this.M_ifaces;
		}
		
		/// <summary>インタフェース
		/// </summary>
		public System.Collections.Generic.List<Iface> Ifaces
		{
			get { return this.Get_ifaces(); }
		}
		
		private bool N_instance = false;
		
		private ServerInstance Get_instance()
		{
			return this.M_instance;
		}
		
		/// <summary>インスタンス情報
		/// </summary>
		public ServerInstance Instance
		{
			get { return this.Get_instance(); }
		}
		
		private bool N_availability = false;
		
		private string Get_availability()
		{
			return this.M_availability;
		}
		
		/// <summary>有効状態 <see cref="Saklient.Cloud.Enums.EAvailability" />
		/// </summary>
		public string Availability
		{
			get { return this.Get_availability(); }
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
			if (Util.ExistsPath(r, "Name")) {
				this.M_name = Util.GetByPath(r, "Name") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Name");
			}
			else {
				this.M_name = null;
				this.IsIncomplete = true;
			}
			this.N_name = false;
			if (Util.ExistsPath(r, "Description")) {
				this.M_description = Util.GetByPath(r, "Description") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Description");
			}
			else {
				this.M_description = null;
				this.IsIncomplete = true;
			}
			this.N_description = false;
			if (Util.ExistsPath(r, "Tags")) {
				if (Util.GetByPath(r, "Tags") == null) {
					this.M_tags = new System.Collections.Generic.List<string> {  };
				}
				else {
					this.M_tags = new System.Collections.Generic.List<string> {  };
					for (int __it1=0; __it1 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags"))) as System.Collections.IList).Count; __it1++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags")))[__it1];
						string v1 = null;
						v1 = t == null ? ((string)(null)) : "" + t;
						(this.M_tags as System.Collections.IList).Add(v1);
					}
				}
			}
			else {
				this.M_tags = null;
				this.IsIncomplete = true;
			}
			this.N_tags = false;
			if (Util.ExistsPath(r, "Icon")) {
				this.M_icon = Util.GetByPath(r, "Icon") == null ? null : new Icon(this._Client, Util.GetByPath(r, "Icon"));
			}
			else {
				this.M_icon = null;
				this.IsIncomplete = true;
			}
			this.N_icon = false;
			if (Util.ExistsPath(r, "ServerPlan")) {
				this.M_plan = Util.GetByPath(r, "ServerPlan") == null ? null : new ServerPlan(this._Client, Util.GetByPath(r, "ServerPlan"));
			}
			else {
				this.M_plan = null;
				this.IsIncomplete = true;
			}
			this.N_plan = false;
			if (Util.ExistsPath(r, "Interfaces")) {
				if (Util.GetByPath(r, "Interfaces") == null) {
					this.M_ifaces = new System.Collections.Generic.List<Iface> {  };
				}
				else {
					this.M_ifaces = new System.Collections.Generic.List<Iface> {  };
					for (int __it2=0; __it2 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Interfaces"))) as System.Collections.IList).Count; __it2++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Interfaces")))[__it2];
						Iface v2 = null;
						v2 = t == null ? null : new Iface(this._Client, t);
						(this.M_ifaces as System.Collections.IList).Add(v2);
					}
				}
			}
			else {
				this.M_ifaces = null;
				this.IsIncomplete = true;
			}
			this.N_ifaces = false;
			if (Util.ExistsPath(r, "Instance")) {
				this.M_instance = Util.GetByPath(r, "Instance") == null ? null : new ServerInstance(this._Client, Util.GetByPath(r, "Instance"));
			}
			else {
				this.M_instance = null;
				this.IsIncomplete = true;
			}
			this.N_instance = false;
			if (Util.ExistsPath(r, "Availability")) {
				this.M_availability = Util.GetByPath(r, "Availability") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Availability");
			}
			else {
				this.M_availability = null;
				this.IsIncomplete = true;
			}
			this.N_availability = false;
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
			if (withClean || this.N_tags) {
				Util.SetByPath(ret, "Tags", new System.Collections.Generic.List<object> {  });
				for (int __it1=0; __it1 < (this.M_tags as System.Collections.IList).Count; __it1++) {
					var r1 = this.M_tags[__it1];
					object v = null;
					v = r1;
					((ret as System.Collections.Generic.Dictionary<string, object>)["Tags"] as System.Collections.IList).Add(v);
				}
			}
			if (withClean || this.N_icon) {
				Util.SetByPath(ret, "Icon", withClean ? (this.M_icon == null ? ((Icon)(null)) : this.M_icon.ApiSerialize(withClean)) : (this.M_icon == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_icon.ApiSerializeID()));
			}
			if (withClean || this.N_plan) {
				Util.SetByPath(ret, "ServerPlan", withClean ? (this.M_plan == null ? ((ServerPlan)(null)) : this.M_plan.ApiSerialize(withClean)) : (this.M_plan == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_plan.ApiSerializeID()));
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("plan");
				}
			}
			if (withClean || this.N_ifaces) {
				Util.SetByPath(ret, "Interfaces", new System.Collections.Generic.List<object> {  });
				for (int __it2=0; __it2 < (this.M_ifaces as System.Collections.IList).Count; __it2++) {
					var r2 = this.M_ifaces[__it2];
					object v = null;
					v = withClean ? (r2 == null ? ((Iface)(null)) : r2.ApiSerialize(withClean)) : (r2 == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : r2.ApiSerializeID());
					((ret as System.Collections.Generic.Dictionary<string, object>)["Interfaces"] as System.Collections.IList).Add(v);
				}
			}
			if (withClean || this.N_instance) {
				Util.SetByPath(ret, "Instance", withClean ? (this.M_instance == null ? ((ServerInstance)(null)) : this.M_instance.ApiSerialize(withClean)) : (this.M_instance == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_instance.ApiSerializeID()));
			}
			if (withClean || this.N_availability) {
				Util.SetByPath(ret, "Availability", this.M_availability);
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Server creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
