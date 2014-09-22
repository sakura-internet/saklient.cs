using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Script = Saklient.Cloud.Resources.Script;

namespace Saklient.Cloud.Resources
{

	/**
	 * ディスク修正のパラメータ。
	 * 
	 * @module saklient.cloud.resources.DiskConfig
	 * @class DiskConfig
	 * @constructor
	 */
	public class DiskConfig
	{
		
		/**
		 * @private
		 * @member saklient.cloud.resources.DiskConfig#_Client
		 * @type Client
		 * @internal
		 * @ignore
		 */
		internal Client _Client;
		
		/**
		 * @method Get_client
		 * @internal
		 * @ignore
		 * @return {Client}
		 */
		internal Client Get_client()
		{
			return this._Client;
		}
		
		/**
		 * @ignore
		 * @property Client
		 * @type Client
		 * @readOnly
		 */
		public Client Client
		{
			get { return this.Get_client(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.DiskConfig#_DiskId
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _DiskId;
		
		/**
		 * @method Get_diskId
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_diskId()
		{
			return this._DiskId;
		}
		
		/**
		 * @ignore
		 * @property DiskId
		 * @type string
		 * @readOnly
		 */
		public string DiskId
		{
			get { return this.Get_diskId(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.DiskConfig#_HostName
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _HostName;
		
		/**
		 * @method Get_hostName
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_hostName()
		{
			return this._HostName;
		}
		
		/**
		 * @method Set_hostName
		 * @internal
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		internal string Set_hostName(string v)
		{
			this._HostName = v;
			return v;
		}
		
		/**
		 * ホスト名
		 * 
		 * @property HostName
		 * @type string
		 * @public
		 */
		public string HostName
		{
			get { return this.Get_hostName(); }
			set { this.Set_hostName(value); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.DiskConfig#_Password
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _Password;
		
		/**
		 * @method Get_password
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_password()
		{
			return this._Password;
		}
		
		/**
		 * @method Set_password
		 * @internal
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		internal string Set_password(string v)
		{
			this._Password = v;
			return v;
		}
		
		/**
		 * ログインパスワード
		 * 
		 * @property Password
		 * @type string
		 * @public
		 */
		public string Password
		{
			get { return this.Get_password(); }
			set { this.Set_password(value); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.DiskConfig#_SshKey
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _SshKey;
		
		/**
		 * @method Get_sshKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_sshKey()
		{
			return this._SshKey;
		}
		
		/**
		 * @method Set_sshKey
		 * @internal
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		internal string Set_sshKey(string v)
		{
			this._SshKey = v;
			return v;
		}
		
		/**
		 * SSHキー
		 * 
		 * @property SshKey
		 * @type string
		 * @public
		 */
		public string SshKey
		{
			get { return this.Get_sshKey(); }
			set { this.Set_sshKey(value); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.DiskConfig#_IpAddress
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _IpAddress;
		
		/**
		 * @method Get_ipAddress
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_ipAddress()
		{
			return this._IpAddress;
		}
		
		/**
		 * @method Set_ipAddress
		 * @internal
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		internal string Set_ipAddress(string v)
		{
			this._IpAddress = v;
			return v;
		}
		
		/**
		 * IPアドレス
		 * 
		 * @property IpAddress
		 * @type string
		 * @public
		 */
		public string IpAddress
		{
			get { return this.Get_ipAddress(); }
			set { this.Set_ipAddress(value); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.DiskConfig#_DefaultRoute
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _DefaultRoute;
		
		/**
		 * @method Get_defaultRoute
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_defaultRoute()
		{
			return this._DefaultRoute;
		}
		
		/**
		 * @method Set_defaultRoute
		 * @internal
		 * @ignore
		 * @param {string} v
		 * @return {string}
		 */
		internal string Set_defaultRoute(string v)
		{
			this._DefaultRoute = v;
			return v;
		}
		
		/**
		 * デフォルトルート
		 * 
		 * @property DefaultRoute
		 * @type string
		 * @public
		 */
		public string DefaultRoute
		{
			get { return this.Get_defaultRoute(); }
			set { this.Set_defaultRoute(value); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.DiskConfig#_NetworkMaskLen
		 * @type long?
		 * @internal
		 * @ignore
		 */
		internal long? _NetworkMaskLen;
		
		/**
		 * @method Get_networkMaskLen
		 * @internal
		 * @ignore
		 * @return {long?}
		 */
		internal long? Get_networkMaskLen()
		{
			return this._NetworkMaskLen;
		}
		
		/**
		 * @method Set_networkMaskLen
		 * @internal
		 * @ignore
		 * @param {long?} v
		 * @return {long?}
		 */
		internal long? Set_networkMaskLen(long? v)
		{
			this._NetworkMaskLen = v;
			return v;
		}
		
		/**
		 * ネットワークマスク長
		 * 
		 * @property NetworkMaskLen
		 * @type long?
		 * @public
		 */
		public long? NetworkMaskLen
		{
			get { return this.Get_networkMaskLen(); }
			set { this.Set_networkMaskLen(value); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.DiskConfig#_Scripts
		 * @type System.Collections.Generic.List<Script>
		 * @internal
		 * @ignore
		 */
		internal System.Collections.Generic.List<Script> _Scripts;
		
		/**
		 * @method Get_scripts
		 * @internal
		 * @ignore
		 * @return {System.Collections.Generic.List<Script>}
		 */
		internal System.Collections.Generic.List<Script> Get_scripts()
		{
			return this._Scripts;
		}
		
		/**
		 * スタートアップスクリプト（pushによりスクリプトを追加できます）
		 * 
		 * @property Scripts
		 * @type System.Collections.Generic.List<Script>
		 * @readOnly
		 * @public
		 */
		public System.Collections.Generic.List<Script> Scripts
		{
			get { return this.Get_scripts(); }
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 * @param {string} diskId
		 */
		public DiskConfig(Client client, string diskId)
		{
			this._Client = client;
			this._DiskId = diskId;
			this._HostName = null;
			this._Password = null;
			this._SshKey = null;
			this._IpAddress = null;
			this._DefaultRoute = null;
			this._NetworkMaskLen = null;
			this._Scripts = new System.Collections.Generic.List<Script> {  };
		}
		
		/**
		 * スタートアップスクリプトを追加します。
		 * 
		 * diskConfig.addScript(script) と diskConfig.scripts.push(script) の効果は同等です。
		 * 
		 * @method AddScript
		 * @chainable
		 * @public
		 * @param {Script} script
		 * @return {DiskConfig} this
		 */
		public DiskConfig AddScript(Script script)
		{
			(this._Scripts as System.Collections.IList).Add(script);
			return this;
		}
		
		/**
		 * 修正内容を実際のディスクに書き込みます。
		 * 
		 * @method Write
		 * @chainable
		 * @public
		 * @return {DiskConfig} this
		 */
		public DiskConfig Write()
		{
			object q = new System.Collections.Generic.Dictionary<string, object> {};
			if (this._HostName != null) {
				Util.SetByPath(q, "HostName", this._HostName);
			}
			if (this._Password != null) {
				Util.SetByPath(q, "Password", this._Password);
			}
			if (this._SshKey != null) {
				Util.SetByPath(q, "SSHKey.PublicKey", this._SshKey);
			}
			if (this._IpAddress != null) {
				Util.SetByPath(q, "UserIPAddress", this._IpAddress);
			}
			if (this._DefaultRoute != null) {
				Util.SetByPath(q, "UserSubnet.DefaultRoute", this._DefaultRoute);
			}
			if (this._NetworkMaskLen != null) {
				Util.SetByPath(q, "UserSubnet.NetworkMaskLen", this._NetworkMaskLen);
			}
			if (0 < this._Scripts.Count) {
				System.Collections.Generic.List<object> notes = new System.Collections.Generic.List<object> {  };
				for (int __it1=0; __it1 < (this._Scripts as System.Collections.IList).Count; __it1++) {
					var script = this._Scripts[__it1];
					(notes as System.Collections.IList).Add(new System.Collections.Generic.Dictionary<string, object> { { "ID", script._Id() } });
				}
				Util.SetByPath(q, "Notes", notes);
			}
			string path = "/disk/" + this._DiskId + "/config";
			this._Client.Request("PUT", path, q);
			return this;
		}
		
	}
	
}
