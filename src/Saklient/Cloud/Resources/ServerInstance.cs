using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using IsoImage = Saklient.Cloud.Resources.IsoImage;
using EServerInstanceStatus = Saklient.Cloud.Enums.EServerInstanceStatus;

namespace Saklient.Cloud.Resources
{

	/// <summary>サーバインスタンスの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class ServerInstance : Resource
	{
		
		/// <summary>起動状態 <see cref="Saklient.Cloud.Enums.EServerInstanceStatus" />
		/// </summary>
		internal string M_status;
		
		/// <summary>前回の起動状態 <see cref="Saklient.Cloud.Enums.EServerInstanceStatus" />
		/// </summary>
		internal string M_beforeStatus;
		
		/// <summary>現在の起動状態に変化した日時
		/// </summary>
		internal System.DateTime? M_statusChangedAt;
		
		/// <summary>挿入されているISOイメージ
		/// </summary>
		internal IsoImage M_isoImage;
		
		public ServerInstance(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		/// <summary>サーバが起動しているときtrueを返します。
		/// </summary>
		public bool IsUp()
		{
			return this.Get_status() != null && EServerInstanceStatus.Compare(this.Get_status(), EServerInstanceStatus.UP) == 0;
		}
		
		/// <summary>サーバが停止しているときtrueを返します。
		/// </summary>
		public bool IsDown()
		{
			return this.Get_status() == null || EServerInstanceStatus.Compare(this.Get_status(), EServerInstanceStatus.DOWN) == 0;
		}
		
		private bool N_status = false;
		
		private string Get_status()
		{
			return this.M_status;
		}
		
		/// <summary>起動状態 <see cref="Saklient.Cloud.Enums.EServerInstanceStatus" />
		/// </summary>
		public string Status
		{
			get { return this.Get_status(); }
		}
		
		private bool N_beforeStatus = false;
		
		private string Get_beforeStatus()
		{
			return this.M_beforeStatus;
		}
		
		/// <summary>前回の起動状態 <see cref="Saklient.Cloud.Enums.EServerInstanceStatus" />
		/// </summary>
		public string BeforeStatus
		{
			get { return this.Get_beforeStatus(); }
		}
		
		private bool N_statusChangedAt = false;
		
		private System.DateTime? Get_statusChangedAt()
		{
			return this.M_statusChangedAt;
		}
		
		/// <summary>現在の起動状態に変化した日時
		/// </summary>
		public System.DateTime? StatusChangedAt
		{
			get { return this.Get_statusChangedAt(); }
		}
		
		private bool N_isoImage = false;
		
		private IsoImage Get_isoImage()
		{
			return this.M_isoImage;
		}
		
		/// <summary>挿入されているISOイメージ
		/// </summary>
		public IsoImage IsoImage
		{
			get { return this.Get_isoImage(); }
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
			if (Util.ExistsPath(r, "Status")) {
				this.M_status = Util.GetByPath(r, "Status") == null ? ((string)(null)) : "" + Util.GetByPath(r, "Status");
			}
			else {
				this.M_status = null;
				this.IsIncomplete = true;
			}
			this.N_status = false;
			if (Util.ExistsPath(r, "BeforeStatus")) {
				this.M_beforeStatus = Util.GetByPath(r, "BeforeStatus") == null ? ((string)(null)) : "" + Util.GetByPath(r, "BeforeStatus");
			}
			else {
				this.M_beforeStatus = null;
				this.IsIncomplete = true;
			}
			this.N_beforeStatus = false;
			if (Util.ExistsPath(r, "StatusChangedAt")) {
				this.M_statusChangedAt = Util.GetByPath(r, "StatusChangedAt") == null ? ((System.DateTime?)(null)) : Util.Str2date("" + Util.GetByPath(r, "StatusChangedAt"));
			}
			else {
				this.M_statusChangedAt = null;
				this.IsIncomplete = true;
			}
			this.N_statusChangedAt = false;
			if (Util.ExistsPath(r, "CDROM")) {
				this.M_isoImage = Util.GetByPath(r, "CDROM") == null ? null : new IsoImage(this._Client, Util.GetByPath(r, "CDROM"));
			}
			else {
				this.M_isoImage = null;
				this.IsIncomplete = true;
			}
			this.N_isoImage = false;
		}
		
		internal override object ApiSerializeImpl(bool withClean=false)
		{
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_status) {
				Util.SetByPath(ret, "Status", this.M_status);
			}
			if (withClean || this.N_beforeStatus) {
				Util.SetByPath(ret, "BeforeStatus", this.M_beforeStatus);
			}
			if (withClean || this.N_statusChangedAt) {
				Util.SetByPath(ret, "StatusChangedAt", this.M_statusChangedAt == null ? ((string)(null)) : Util.Date2str(this.M_statusChangedAt));
			}
			if (withClean || this.N_isoImage) {
				Util.SetByPath(ret, "CDROM", withClean ? (this.M_isoImage == null ? ((IsoImage)(null)) : this.M_isoImage.ApiSerialize(withClean)) : (this.M_isoImage == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_isoImage.ApiSerializeID()));
			}
			return ret;
		}
		
	}
	
}
