using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Script = Saklient.Cloud.Resources.Script;

namespace Saklient.Cloud.Resources
{

	/// <summary>ディスク修正のパラメータ。
	/// </summary>
	public class DiskConfig
	{
		
		internal Client _Client;
		
		internal Client Get_client()
		{
			return this._Client;
		}
		
		public Client Client
		{
			get { return this.Get_client(); }
		}
		
		internal string _DiskId;
		
		internal string Get_diskId()
		{
			return this._DiskId;
		}
		
		public string DiskId
		{
			get { return this.Get_diskId(); }
		}
		
		internal string _HostName;
		
		internal string Get_hostName()
		{
			return this._HostName;
		}
		
		internal string Set_hostName(string v)
		{
			this._HostName = v;
			return v;
		}
		
		/// <summary>ホスト名
		/// </summary>
		public string HostName
		{
			get { return this.Get_hostName(); }
			set { this.Set_hostName(value); }
		}
		
		internal string _Password;
		
		internal string Get_password()
		{
			return this._Password;
		}
		
		internal string Set_password(string v)
		{
			this._Password = v;
			return v;
		}
		
		/// <summary>ログインパスワード
		/// </summary>
		public string Password
		{
			get { return this.Get_password(); }
			set { this.Set_password(value); }
		}
		
		internal System.Collections.Generic.List<string> _SshKeys;
		
		internal System.Collections.Generic.List<string> Get_sshKeys()
		{
			return this._SshKeys;
		}
		
		internal string Get_sshKey()
		{
			if (this._SshKeys.Count < 1) {
				return null;
			}
			return this._SshKeys[System.Convert.ToInt32(0)];
		}
		
		internal string Set_sshKey(string v)
		{
			if (this._SshKeys.Count < 1) {
				(this._SshKeys as System.Collections.IList).Add(v);
			}
			else {
				this._SshKeys[System.Convert.ToInt32(0)] = v;
			}
			return v;
		}
		
		/// <summary>SSHキー
		/// </summary>
		public string SshKey
		{
			get { return this.Get_sshKey(); }
			set { this.Set_sshKey(value); }
		}
		
		/// <summary>SSHキー
		/// </summary>
		public System.Collections.Generic.List<string> SshKeys
		{
			get { return this.Get_sshKeys(); }
		}
		
		internal string _IpAddress;
		
		internal string Get_ipAddress()
		{
			return this._IpAddress;
		}
		
		internal string Set_ipAddress(string v)
		{
			this._IpAddress = v;
			return v;
		}
		
		/// <summary>IPアドレス
		/// </summary>
		public string IpAddress
		{
			get { return this.Get_ipAddress(); }
			set { this.Set_ipAddress(value); }
		}
		
		internal string _DefaultRoute;
		
		internal string Get_defaultRoute()
		{
			return this._DefaultRoute;
		}
		
		internal string Set_defaultRoute(string v)
		{
			this._DefaultRoute = v;
			return v;
		}
		
		/// <summary>デフォルトルート
		/// </summary>
		public string DefaultRoute
		{
			get { return this.Get_defaultRoute(); }
			set { this.Set_defaultRoute(value); }
		}
		
		internal long? _NetworkMaskLen;
		
		internal long? Get_networkMaskLen()
		{
			return this._NetworkMaskLen;
		}
		
		internal long? Set_networkMaskLen(long? v)
		{
			this._NetworkMaskLen = v;
			return v;
		}
		
		/// <summary>ネットワークマスク長
		/// </summary>
		public long? NetworkMaskLen
		{
			get { return this.Get_networkMaskLen(); }
			set { this.Set_networkMaskLen(value); }
		}
		
		internal System.Collections.Generic.List<Script> _Scripts;
		
		internal System.Collections.Generic.List<Script> Get_scripts()
		{
			return this._Scripts;
		}
		
		/// <summary>スタートアップスクリプト <see cref="Saklient.Cloud.Resources.Script" /> の配列（pushによりスクリプトを追加できます）
		/// </summary>
		public System.Collections.Generic.List<Script> Scripts
		{
			get { return this.Get_scripts(); }
		}
		
		public DiskConfig(Client client, string diskId)
		{
			this._Client = client;
			this._DiskId = diskId;
			this._HostName = null;
			this._Password = null;
			this._SshKeys = new System.Collections.Generic.List<string> {  };
			this._IpAddress = null;
			this._DefaultRoute = null;
			this._NetworkMaskLen = null;
			this._Scripts = new System.Collections.Generic.List<Script> {  };
		}

        /// <summary>スタートアップスクリプトを追加します。
        /// diskConfig.addScript(script) と diskConfig.scripts.push(script) の効果は同等です。
        /// </summary>
        /// <param name="script" />
        /// <returns>this</returns>
        public DiskConfig AddScript(Script script)
		{
			(this._Scripts as System.Collections.IList).Add(script);
			return this;
		}

        /// <summary>修正内容を実際のディスクに書き込みます。
        /// </summary>
        /// <returns>this</returns>
        public DiskConfig Write()
		{
			object q = new System.Collections.Generic.Dictionary<string, object> {};
			if (this._HostName != null) {
				Util.SetByPath(q, "HostName", this._HostName);
			}
			if (this._Password != null) {
				Util.SetByPath(q, "Password", this._Password);
			}
			if (this._SshKeys.Count > 0) {
				Util.SetByPath(q, "SSHKey.PublicKey", string.Join("\n", (this._SshKeys).ToArray()));
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
