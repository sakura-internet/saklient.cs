using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;

namespace Saklient.Cloud.Resources
{

	/**
	 * インタフェースの実体1つに対応し、属性の取得や操作を行うためのクラス。
	 * 
	 * @module saklient.cloud.resources.Iface
	 * @class Iface
	 * @constructor
	 * @extends Resource
	 */
	public class Iface : Resource
	{
		
		/**
		 * ID
		 * 
		 * @member saklient.cloud.resources.Iface#M_id
		 * @type string
		 * @internal
		 */
		internal string M_id;
		
		/**
		 * MACアドレス
		 * 
		 * @member saklient.cloud.resources.Iface#M_macAddress
		 * @type string
		 * @internal
		 */
		internal string M_macAddress;
		
		/**
		 * IPv4アドレス（共有セグメントによる自動割当）
		 * 
		 * @member saklient.cloud.resources.Iface#M_ipAddress
		 * @type string
		 * @internal
		 */
		internal string M_ipAddress;
		
		/**
		 * ユーザ設定IPv4アドレス
		 * 
		 * @member saklient.cloud.resources.Iface#M_userIpAddress
		 * @type string
		 * @internal
		 */
		internal string M_userIpAddress;
		
		/**
		 * このインタフェースが取り付けられているサーバのID
		 * 
		 * @member saklient.cloud.resources.Iface#M_serverId
		 * @type string
		 * @internal
		 */
		internal string M_serverId;
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/interface";
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
			return "Interface";
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
			return "Interfaces";
		}
		
		/**
		 * @private
		 * @method _className
		 * @ignore
		 * @return {string}
		 */
		public override string _className()
		{
			return "Iface";
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
		 * このローカルオブジェクトに現在設定されているリソース情報をAPIに送信し、新規作成または上書き保存します。
		 * 
		 * @method Save
		 * @chainable
		 * @public
		 * @return {Iface} this
		 */
		public Iface Save()
		{
			return ((Iface)(this._save()));
		}
		
		/**
		 * 最新のリソース情報を再取得します。
		 * 
		 * @method Reload
		 * @chainable
		 * @public
		 * @return {Iface} this
		 */
		public Iface Reload()
		{
			return ((Iface)(this._reload()));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {object} obj
		 * @param {bool} wrapped=false
		 */
		public Iface(Client client, object obj, bool wrapped=false) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			Util.ValidateType(obj, "object");
			Util.ValidateType(wrapped, "bool");
			this.ApiDeserialize(obj, wrapped);
		}
		
		/**
		 * 共有セグメントに接続します。
		 * 
		 * @method ConnectToSharedSegment
		 * @chainable
		 * @public
		 * @return {Iface} this
		 */
		public Iface ConnectToSharedSegment()
		{
			this._client.Request("PUT", this._apiPath() + "/" + Util.UrlEncode(this._id()) + "/to/switch/shared");
			return this.Reload();
		}
		
		/**
		 * @member saklient.cloud.resources.Iface#N_id
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
		 * @member saklient.cloud.resources.Iface#N_macAddress
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_macAddress = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_macAddress
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_macAddress()
		{
			return this.M_macAddress;
		}
		
		/**
		 * MACアドレス
		 * 
		 * @property MacAddress
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string MacAddress
		{
			get { return this.Get_macAddress(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Iface#N_ipAddress
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_ipAddress = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_ipAddress
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_ipAddress()
		{
			return this.M_ipAddress;
		}
		
		/**
		 * IPv4アドレス（共有セグメントによる自動割当）
		 * 
		 * @property IpAddress
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string IpAddress
		{
			get { return this.Get_ipAddress(); }
		}
		
		/**
		 * @member saklient.cloud.resources.Iface#N_userIpAddress
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_userIpAddress = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_userIpAddress
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_userIpAddress()
		{
			return this.M_userIpAddress;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_userIpAddress
		 * @private
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		private string Set_userIpAddress(string v)
		{
			Util.ValidateType(v, "string");
			this.M_userIpAddress = v;
			this.N_userIpAddress = true;
			return this.M_userIpAddress;
		}
		
		/**
		 * ユーザ設定IPv4アドレス
		 * 
		 * @property UserIpAddress
		 * @type string
		 * @public
		 */
		public string UserIpAddress
		{
			get { return this.Get_userIpAddress(); }
			set { this.Set_userIpAddress(value); }
		}
		
		/**
		 * @member saklient.cloud.resources.Iface#N_serverId
		 * @default false
		 * @type bool
		 * @private
		 */
		private bool N_serverId = false;
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Get_serverId
		 * @private
		 * @ignore
		 * @return {string}
		 */
		private string Get_serverId()
		{
			return this.M_serverId;
		}
		
		/**
		 * (This method is generated in Translator_default#buildImpl)
		 * 
		 * @method Set_serverId
		 * @private
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		private string Set_serverId(string v)
		{
			Util.ValidateType(v, "string");
			if (!this.IsNew) {
				throw new SaklientException("immutable_field", "Immutable fields cannot be modified after the resource creation: " + "saklient.cloud.resources.Iface#Set_serverId");
			};
			this.M_serverId = v;
			this.N_serverId = true;
			return this.M_serverId;
		}
		
		/**
		 * このインタフェースが取り付けられているサーバのID
		 * 
		 * @property ServerId
		 * @type string
		 * @public
		 */
		public string ServerId
		{
			get { return this.Get_serverId(); }
			set { this.Set_serverId(value); }
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
			if (Util.ExistsPath(r, "MACAddress")) {
				this.M_macAddress = Util.GetByPath(r, "MACAddress") == null ? null : "" + Util.GetByPath(r, "MACAddress");
			}
			else {
				this.M_macAddress = null;
				this.IsIncomplete = true;
			};
			this.N_macAddress = false;
			if (Util.ExistsPath(r, "IPAddress")) {
				this.M_ipAddress = Util.GetByPath(r, "IPAddress") == null ? null : "" + Util.GetByPath(r, "IPAddress");
			}
			else {
				this.M_ipAddress = null;
				this.IsIncomplete = true;
			};
			this.N_ipAddress = false;
			if (Util.ExistsPath(r, "UserIPAddress")) {
				this.M_userIpAddress = Util.GetByPath(r, "UserIPAddress") == null ? null : "" + Util.GetByPath(r, "UserIPAddress");
			}
			else {
				this.M_userIpAddress = null;
				this.IsIncomplete = true;
			};
			this.N_userIpAddress = false;
			if (Util.ExistsPath(r, "Server.ID")) {
				this.M_serverId = Util.GetByPath(r, "Server.ID") == null ? null : "" + Util.GetByPath(r, "Server.ID");
			}
			else {
				this.M_serverId = null;
				this.IsIncomplete = true;
			};
			this.N_serverId = false;
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
			System.Collections.Generic.List<string> missing = new System.Collections.Generic.List<string> {  };
			object ret = new System.Collections.Generic.Dictionary<string, object> {  };
			if (withClean || this.N_id) {
				Util.SetByPath(ret, "ID", this.M_id);
			};
			if (withClean || this.N_macAddress) {
				Util.SetByPath(ret, "MACAddress", this.M_macAddress);
			};
			if (withClean || this.N_ipAddress) {
				Util.SetByPath(ret, "IPAddress", this.M_ipAddress);
			};
			if (withClean || this.N_userIpAddress) {
				Util.SetByPath(ret, "UserIPAddress", this.M_userIpAddress);
			};
			if (withClean || this.N_serverId) {
				Util.SetByPath(ret, "Server.ID", this.M_serverId);
			}
			else {
				if (this.IsNew) {
					(missing as System.Collections.IList).Add("serverId");
				};
			};
			if (missing.Count > 0) {
				throw new SaklientException("required_field", "Required fields must be set before the Iface creation: " + string.Join(", ", (missing).ToArray()));
			};
			return ret;
		}
		
	}
	
}
