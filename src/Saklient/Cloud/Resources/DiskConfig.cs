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
		 * @member saklient.cloud.resources.DiskConfig#_client
		 * @type Client
		 * @internal
		 * @ignore
		 */
		internal Client _client;
		
		/**
		 * @method Get_client
		 * @internal
		 * @ignore
		 * @return {Client}
		 */
		internal Client Get_client()
		{
			return this._client;
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
		 * @member saklient.cloud.resources.DiskConfig#_diskId
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _diskId;
		
		/**
		 * @method Get_diskId
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_diskId()
		{
			return this._diskId;
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
		 * @member saklient.cloud.resources.DiskConfig#_hostName
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _hostName;
		
		/**
		 * @method Get_hostName
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_hostName()
		{
			return this._hostName;
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
			this._hostName = v;
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
		 * @member saklient.cloud.resources.DiskConfig#_password
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _password;
		
		/**
		 * @method Get_password
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_password()
		{
			return this._password;
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
			this._password = v;
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
		 * @member saklient.cloud.resources.DiskConfig#_sshKey
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _sshKey;
		
		/**
		 * @method Get_sshKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_sshKey()
		{
			return this._sshKey;
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
			this._sshKey = v;
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
		 * @member saklient.cloud.resources.DiskConfig#_ipAddress
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _ipAddress;
		
		/**
		 * @method Get_ipAddress
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_ipAddress()
		{
			return this._ipAddress;
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
			this._ipAddress = v;
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
		 * @member saklient.cloud.resources.DiskConfig#_defaultRoute
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _defaultRoute;
		
		/**
		 * @method Get_defaultRoute
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal string Get_defaultRoute()
		{
			return this._defaultRoute;
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
			this._defaultRoute = v;
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
		 * @member saklient.cloud.resources.DiskConfig#_networkMaskLen
		 * @type long?
		 * @internal
		 * @ignore
		 */
		internal long? _networkMaskLen;
		
		/**
		 * @method Get_networkMaskLen
		 * @internal
		 * @ignore
		 * @return {long?}
		 */
		internal long? Get_networkMaskLen()
		{
			return this._networkMaskLen;
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
			this._networkMaskLen = v;
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
		 * @member saklient.cloud.resources.DiskConfig#_scripts
		 * @type System.Collections.Generic.List<Script>
		 * @internal
		 * @ignore
		 */
		internal System.Collections.Generic.List<Script> _scripts;
		
		/**
		 * @method Get_scripts
		 * @internal
		 * @ignore
		 * @return {System.Collections.Generic.List<Script>}
		 */
		internal System.Collections.Generic.List<Script> Get_scripts()
		{
			return this._scripts;
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
			this._client = client;
			this._diskId = diskId;
			this._hostName = null;
			this._password = null;
			this._sshKey = null;
			this._ipAddress = null;
			this._defaultRoute = null;
			this._networkMaskLen = null;
			this._scripts = new System.Collections.Generic.List<Script> {  };
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
			(this._scripts as System.Collections.IList).Add(script);
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
			if (this._hostName != null) {
				Util.SetByPath(q, "HostName", this._hostName);
			}
			if (this._password != null) {
				Util.SetByPath(q, "Password", this._password);
			}
			if (this._sshKey != null) {
				Util.SetByPath(q, "SSHKey.PublicKey", this._sshKey);
			}
			if (this._ipAddress != null) {
				Util.SetByPath(q, "UserIPAddress", this._ipAddress);
			}
			if (this._defaultRoute != null) {
				Util.SetByPath(q, "UserSubnet.DefaultRoute", this._defaultRoute);
			}
			if (this._networkMaskLen != null) {
				Util.SetByPath(q, "UserSubnet.NetworkMaskLen", this._networkMaskLen);
			}
			if (0 < this._scripts.Count) {
				System.Collections.Generic.List<object> notes = new System.Collections.Generic.List<object> {  };
				for (int __it1=0; __it1 < (this._scripts as System.Collections.IList).Count; __it1++) {
					var script = this._scripts[__it1];
					(notes as System.Collections.IList).Add(new System.Collections.Generic.Dictionary<string, object> { { "ID", script._id() } });
				}
				Util.SetByPath(q, "Notes", notes);
			}
			string path = "/disk/" + this._diskId + "/config";
			this._client.Request("PUT", path, q);
			return this;
		}
		
	}
	
}
