using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using IsoImage = Saklient.Cloud.Resources.IsoImage;
using EServerInstanceStatus = Saklient.Cloud.Enums.EServerInstanceStatus;

namespace Saklient.Cloud.Resources
{

	/**
	 * サーバインスタンスの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.ServerInstance
	 * @class ServerInstance
	 * @constructor
	 * @extends Resource
	 */
	public class ServerInstance : Resource
	{
		
		/**
		 * 起動状態 {@link EServerInstanceStatus}
		 * 
		 * @member saklient.cloud.resources.ServerInstance#M_status
		 * @type string
		 * @internal
		 */
		internal string M_status;
		
		/**
		 * 前回の起動状態 {@link EServerInstanceStatus}
		 * 
		 * @member saklient.cloud.resources.ServerInstance#M_beforeStatus
		 * @type string
		 * @internal
		 */
		internal string M_beforeStatus;
		
		/**
		 * 現在の起動状態に変化した日時
		 * 
		 * @member saklient.cloud.resources.ServerInstance#M_statusChangedAt
		 * @type System.DateTime?
		 * @internal
		 */
		internal System.DateTime? M_statusChangedAt;
		
		/**
		 * 挿入されているISOイメージ
		 * 
		 * @member saklient.cloud.resources.ServerInstance#M_isoImage
		 * @type IsoImage
		 * @internal
		 */
		internal IsoImage M_isoImage;
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 */
		public ServerInstance(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * サーバが起動しているときtrueを返します。
		 * 
		 * @method IsUp
		 * @public
		 * @return {bool}
		 */
		public bool IsUp()
		{
			return this.Get_status() != null && EServerInstanceStatus.Compare(this.Get_status(), EServerInstanceStatus.Up) == 0;
		}
		
		/**
		 * サーバが停止しているときtrueを返します。
		 * 
		 * @method IsDown
		 * @public
		 * @return {bool}
		 */
		public bool IsDown()
		{
			return this.Get_status() == null || EServerInstanceStatus.Compare(this.Get_status(), EServerInstanceStatus.Down) == 0;
		}
		
		/**
		 * @member saklient.cloud.resources.ServerInstance#N_status
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_status = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_status
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_status()
		{
			return this.M_status;
		}
		
		/**
		 * 起動状態 {@link EServerInstanceStatus}
		 * 
		 * @property Status
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Status
		{
			get { return this.Get_status(); }
		}
		
		/**
		 * @member saklient.cloud.resources.ServerInstance#N_beforeStatus
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_beforeStatus = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_beforeStatus
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_beforeStatus()
		{
			return this.M_beforeStatus;
		}
		
		/**
		 * 前回の起動状態 {@link EServerInstanceStatus}
		 * 
		 * @property BeforeStatus
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string BeforeStatus
		{
			get { return this.Get_beforeStatus(); }
		}
		
		/**
		 * @member saklient.cloud.resources.ServerInstance#N_statusChangedAt
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_statusChangedAt = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_statusChangedAt
		 * @private
		 * @ignore
		 * @return {System.DateTime?}
		 */
		private System.DateTime? Get_statusChangedAt()
		{
			return this.M_statusChangedAt;
		}
		
		/**
		 * 現在の起動状態に変化した日時
		 * 
		 * @property StatusChangedAt
		 * @type System.DateTime?
		 * @readOnly
		 * @public
		 */
		public System.DateTime? StatusChangedAt
		{
			get { return this.Get_statusChangedAt(); }
		}
		
		/**
		 * @member saklient.cloud.resources.ServerInstance#N_isoImage
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_isoImage = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_isoImage
		 * @private
		 * @ignore
		 * @return {IsoImage}
		 */
		private IsoImage Get_isoImage()
		{
			return this.M_isoImage;
		}
		
		/**
		 * 挿入されているISOイメージ
		 * 
		 * @property IsoImage
		 * @type IsoImage
		 * @readOnly
		 * @public
		 */
		public IsoImage IsoImage
		{
			get { return this.Get_isoImage(); }
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
			this.IsNew = r == null;
			if (this.IsNew) {
				r = new System.Collections.Generic.Dictionary<string, object> {  };
			}
			this.IsIncomplete = false;
			if (Util.ExistsPath(r, "Status")) {
				this.M_status = Util.GetByPath(r, "Status") == null ? null : "" + Util.GetByPath(r, "Status");
			}
			else {
				this.M_status = null;
				this.IsIncomplete = true;
			}
			this.N_status = false;
			if (Util.ExistsPath(r, "BeforeStatus")) {
				this.M_beforeStatus = Util.GetByPath(r, "BeforeStatus") == null ? null : "" + Util.GetByPath(r, "BeforeStatus");
			}
			else {
				this.M_beforeStatus = null;
				this.IsIncomplete = true;
			}
			this.N_beforeStatus = false;
			if (Util.ExistsPath(r, "StatusChangedAt")) {
				this.M_statusChangedAt = Util.GetByPath(r, "StatusChangedAt") == null ? null : Util.Str2date("" + Util.GetByPath(r, "StatusChangedAt"));
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
		
		/**
		 * @ignore
		 * @method ApiSerializeImpl
		 * @internal
		 * @param {bool} withClean=false
		 * @return {object}
		 */
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
				Util.SetByPath(ret, "StatusChangedAt", this.M_statusChangedAt == null ? null : Util.Date2str(this.M_statusChangedAt));
			}
			if (withClean || this.N_isoImage) {
				Util.SetByPath(ret, "CDROM", withClean ? (this.M_isoImage == null ? null : this.M_isoImage.ApiSerialize(withClean)) : (this.M_isoImage == null ? new System.Collections.Generic.Dictionary<string, object> { { "ID", "0" } } : this.M_isoImage.ApiSerializeID()));
			}
			return ret;
		}
		
	}
	
}
