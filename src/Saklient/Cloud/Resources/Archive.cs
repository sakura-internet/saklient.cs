using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using Icon = Saklient.Cloud.Resources.Icon;
using FtpInfo = Saklient.Cloud.Resources.FtpInfo;
using DiskPlan = Saklient.Cloud.Resources.DiskPlan;
using Server = Saklient.Cloud.Resources.Server;
using EScope = Saklient.Cloud.Enums.EScope;
using EAvailability = Saklient.Cloud.Enums.EAvailability;
using SaklientException = Saklient.Errors.SaklientException;

namespace Saklient.Cloud.Resources
{

	/// <summary>アーカイブの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class Archive : Resource
	{
		
		/// <summary>ID
		/// </summary>
		internal string M_id;
		
		/// <summary>スコープ <see cref="Saklient.Cloud.Enums.EScope" />
		/// </summary>
		internal string M_scope;
		
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
		
		/// <summary>表示順序
		/// </summary>
		internal long? M_displayOrder;
		
		/// <summary>サイズ[MiB]
		/// </summary>
		internal long? M_sizeMib;
		
		/// <summary>サービスクラス
		/// </summary>
		internal string M_serviceClass;
		
		/// <summary>プラン
		/// </summary>
		internal DiskPlan M_plan;
		
		/// <summary>有効状態 <see cref="Saklient.Cloud.Enums.EAvailability" />
		/// </summary>
		internal string M_availability;
		
		internal override string _ApiPath()
		{
			return "/archive";
		}
		
		internal override string _RootKey()
		{
			return "Archive";
		}
		
		internal override string _RootKeyM()
		{
			return "Archives";
		}
		
		public override string _ClassName()
		{
			return "Archive";
		}
		
		public override string _Id()
		{
			return this.Get_id();
		}
		
		/// <summary>このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Archive Save()
		{
			return ((Archive)(this._Save()));
		}
		
		/// <summary>最新のリソース情報を再取得します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Archive Reload()
		{
			return ((Archive)(this._Reload()));
		}
		
		public Archive(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		internal bool Get_isAvailable()
		{
			return this.Get_availability() == EAvailability.AVAILABLE;
		}
		
		/// <summary>ディスクが利用可能なときtrueを返します。
		/// </summary>
		public bool IsAvailable
		{
			get { return this.Get_isAvailable(); }
		}
		
		internal long? Get_sizeGib()
		{
			long? sizeMib = this.Get_sizeMib();
			return sizeMib == null ? null : sizeMib >> 10;
		}
		
		internal long? Set_sizeGib(long? sizeGib)
		{
			this.Set_sizeMib(sizeGib == null ? null : sizeGib * 1024);
			return sizeGib;
		}
		
		/// <summary>サイズ[GiB]
		/// </summary>
		public long? SizeGib
		{
			get { return this.Get_sizeGib(); }
			set { this.Set_sizeGib(value); }
		}
		
		private Resource _Source;
		
		public Resource Get_source()
		{
			return this._Source;
		}
		
		public Resource Set_source(Resource source)
		{
			this._Source = source;
			return source;
		}
		
		/// <summary>アーカイブのコピー元
		/// </summary>
		public Resource Source
		{
			get { return this.Get_source(); }
			set { this.Set_source(value); }
		}
		
		internal FtpInfo _FtpInfo;
		
		public FtpInfo Get_ftpInfo()
		{
			return this._FtpInfo;
		}
		
		/// <summary>FTP情報
		/// </summary>
		public FtpInfo FtpInfo
		{
			get { return this.Get_ftpInfo(); }
		}
		
		internal override void _OnAfterApiDeserialize(object r, object root)
		{
			if (root != null) {
				if ((root as System.Collections.Generic.Dictionary<string, object>).ContainsKey("FTPServer")) {
					object ftp = (root as System.Collections.Generic.Dictionary<string, object>)["FTPServer"];
					if (ftp != null) {
						this._FtpInfo = new FtpInfo(ftp);
					}
				}
			}
			if (r != null) {
				if ((r as System.Collections.Generic.Dictionary<string, object>).ContainsKey("SourceArchive")) {
					object s = (r as System.Collections.Generic.Dictionary<string, object>)["SourceArchive"];
					if (s != null) {
						object id = (s as System.Collections.Generic.Dictionary<string, object>)["ID"];
						if (id != null) {
							this._Source = new Archive(this._Client, s);
						}
					}
				}
				if ((r as System.Collections.Generic.Dictionary<string, object>).ContainsKey("SourceDisk")) {
					object s = (r as System.Collections.Generic.Dictionary<string, object>)["SourceDisk"];
					if (s != null) {
						object id = (s as System.Collections.Generic.Dictionary<string, object>)["ID"];
						if (id != null) {
							this._Source = Resource.CreateWith("Disk", this._Client, s);
						}
					}
				}
			}
		}
		
		internal override void _OnAfterApiSerialize(object r, bool withClean)
		{
			if (r == null) {
				return;
			}
			if (this._Source != null) {
				if (this._Source._ClassName() == "Archive") {
					object s = withClean ? this._Source.ApiSerialize(true) : new System.Collections.Generic.Dictionary<string, object> { { "ID", this._Source._Id() } };
					(r as System.Collections.Generic.Dictionary<string, object>)["SourceArchive"] = s;
				}
				else {
					if (this._Source._ClassName() == "Disk") {
						object s = withClean ? this._Source.ApiSerialize(true) : new System.Collections.Generic.Dictionary<string, object> { { "ID", this._Source._Id() } };
						(r as System.Collections.Generic.Dictionary<string, object>)["SourceDisk"] = s;
					}
					else {
						this._Source = null;
						Util.ValidateType(this._Source, "Disk or Archive", true);
					}
				}
			}
		}
		
		/// <summary>FTPSを開始し、イメージファイルをアップロード・ダウンロードできる状態にします。
		/// 
		/// アカウント情報は、ftpInfo プロパティから取得することができます。
		/// 
		/// <param name="reset">既にFTPSが開始されているとき、trueを指定してこのメソッドを呼ぶことでパスワードを再設定します。</param>
		/// <returns>this</returns>
		/// </summary>
		public Archive OpenFtp(bool reset=false)
		{
			string path = this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/ftp";
			object q = new System.Collections.Generic.Dictionary<string, object> {};
			Util.SetByPath(q, "ChangePassword", reset);
			object result = this._Client.Request("PUT", path, q);
			this._OnAfterApiDeserialize(null, result);
			return this;
		}
		
		/// <summary>FTPSを終了し、アーカイブを利用可能な状態にします。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Archive CloseFtp()
		{
			string path = this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/ftp";
			this._Client.Request("DELETE", path);
			this._FtpInfo = null;
			return this;
		}
		
		/// <summary>コピー中のアーカイブが利用可能になるまで待機します。
		/// 
		/// 
		/// <param name="timeoutSec" />
		/// <param name="callback" />
		/// </summary>
		public void AfterCopy(long timeoutSec, System.Action<Archive, bool> callback)
		{
			bool ret = this.SleepWhileCopying(timeoutSec);
			callback(this, ret);
		}
		
		/// <summary>コピー中のアーカイブが利用可能になるまで待機します。
		/// 
		/// <param name="timeoutSec" />
		/// <returns>成功時はtrue、タイムアウトやエラーによる失敗時はfalseを返します。</returns>
		/// </summary>
		public bool SleepWhileCopying(long timeoutSec=3600)
		{
			long step = 3;
			while (0 < timeoutSec) {
				this.Reload();
				string a = this.Get_availability();
				if (a == EAvailability.AVAILABLE) {
					return true;
				}
				if (a != EAvailability.MIGRATING) {
					timeoutSec = 0;
				}
				timeoutSec -= step;
				if (0 < timeoutSec) {
					Util.Sleep(step);
				}
			}
			return false;
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
		
		private bool N_scope = false;
		
		private string Get_scope()
		{
			return this.M_scope;
		}
		
		/// <summary>スコープ <see cref="Saklient.Cloud.Enums.EScope" />
		/// </summary>
		public string Scope
		{
			get { return this.Get_scope(); }
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
		
		private bool N_displayOrder = false;
		
		private long? Get_displayOrder()
		{
			return this.M_displayOrder;
		}
		
		private long? Set_displayOrder(long? v)
		{
			this.M_displayOrder = v;
			this.N_displayOrder = true;
			return this.M_displayOrder;
		}
		
		/// <summary>表示順序
		/// </summary>
		public long? DisplayOrder
		{
			get { return this.Get_displayOrder(); }
			set { this.Set_displayOrder(value); }
		}
		
		private bool N_sizeMib = false;
		
		private long? Get_sizeMib()
		{
			return this.M_sizeMib;
		}
		
		private long? Set_sizeMib(long? v)
		{
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Archive#Set_sizeMib");
			}
			this.M_sizeMib = v;
			this.N_sizeMib = true;
			return this.M_sizeMib;
		}
		
		/// <summary>サイズ[MiB]
		/// </summary>
		public long? SizeMib
		{
			get { return this.Get_sizeMib(); }
			set { this.Set_sizeMib(value); }
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
		
		private bool N_plan = false;
		
		private DiskPlan Get_plan()
		{
			return this.M_plan;
		}
		
		/// <summary>プラン
		/// </summary>
		public DiskPlan Plan
		{
			get { return this.Get_plan(); }
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
				this.M_id = Util.GetByPath(r, "ID") == null ? null : "" + Util.GetByPath(r, "ID");
			}
			else {
				this.M_id = null;
				this.IsIncomplete = true;
			}
			this.N_id = false;
			if (Util.ExistsPath(r, "Scope")) {
				this.M_scope = Util.GetByPath(r, "Scope") == null ? null : "" + Util.GetByPath(r, "Scope");
			}
			else {
				this.M_scope = null;
				this.IsIncomplete = true;
			}
			this.N_scope = false;
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
			if (Util.ExistsPath(r, "Tags")) {
				if (Util.GetByPath(r, "Tags") == null) {
					this.M_tags = new System.Collections.Generic.List<string> {  };
				}
				else {
					this.M_tags = new System.Collections.Generic.List<string> {  };
					for (int __it1=0; __it1 < (((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags"))) as System.Collections.IList).Count; __it1++) {
						var t = ((System.Collections.Generic.List<object>)(Util.GetByPath(r, "Tags")))[__it1];
						string v1 = null;
						v1 = t == null ? null : "" + t;
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
			if (Util.ExistsPath(r, "DisplayOrder")) {
				this.M_displayOrder = Util.GetByPath(r, "DisplayOrder") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "DisplayOrder"));
			}
			else {
				this.M_displayOrder = null;
				this.IsIncomplete = true;
			}
			this.N_displayOrder = false;
			if (Util.ExistsPath(r, "SizeMB")) {
				this.M_sizeMib = Util.GetByPath(r, "SizeMB") == null ? null : (long?)System.Convert.ToInt64("" + Util.GetByPath(r, "SizeMB"));
			}
			else {
				this.M_sizeMib = null;
				this.IsIncomplete = true;
			}
			this.N_sizeMib = false;
			if (Util.ExistsPath(r, "ServiceClass")) {
				this.M_serviceClass = Util.GetByPath(r, "ServiceClass") == null ? null : "" + Util.GetByPath(r, "ServiceClass");
			}
			else {
				this.M_serviceClass = null;
				this.IsIncomplete = true;
			}
			this.N_serviceClass = false;
			if (Util.ExistsPath(r, "Plan")) {
				this.M_plan = Util.GetByPath(r, "Plan") == null ? null : new DiskPlan(this._Client, Util.GetByPath(r, "Plan"));
			}
			else {
				this.M_plan = null;
				this.IsIncomplete = true;
			}
			this.N_plan = false;
			if (Util.ExistsPath(r, "Availability")) {
				this.M_availability = Util.GetByPath(r, "Availability") == null ? null : "" + Util.GetByPath(r, "Availability");
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
			if (withClean || this.N_scope) {
				Util.SetByPath(ret, "Scope", this.M_scope);
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
				Util.SetByPath(ret, "Icon", withClean ? (this.M_icon == null ? null : this.M_icon.ApiSerialize(withClean)) : (this.M_icon == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_icon.ApiSerializeID()));
			}
			if (withClean || this.N_displayOrder) {
				Util.SetByPath(ret, "DisplayOrder", this.M_displayOrder);
			}
			if (withClean || this.N_sizeMib) {
				Util.SetByPath(ret, "SizeMB", this.M_sizeMib);
			}
			if (withClean || this.N_serviceClass) {
				Util.SetByPath(ret, "ServiceClass", this.M_serviceClass);
			}
			if (withClean || this.N_plan) {
				Util.SetByPath(ret, "Plan", withClean ? (this.M_plan == null ? null : this.M_plan.ApiSerialize(withClean)) : (this.M_plan == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_plan.ApiSerializeID()));
			}
			if (withClean || this.N_availability) {
				Util.SetByPath(ret, "Availability", this.M_availability);
			}
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Archive creation: " + string.Join(", ", (missing).ToArray()));
			}
			return ret;
		}
		
	}
	
}
