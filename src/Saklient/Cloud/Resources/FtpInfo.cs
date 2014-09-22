using Util = Saklient.Util;

namespace Saklient.Cloud.Resources
{

	/**
	 * FTPサーバのアカウント情報。
	 * 
	 * @module saklient.cloud.resources.FtpInfo
	 * @class FtpInfo
	 * @constructor
	 */
	public class FtpInfo
	{
		
		/**
		 * @private
		 * @member saklient.cloud.resources.FtpInfo#_HostName
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _HostName;
		
		/**
		 * @method Get_hostName
		 * @ignore
		 * @return {string}
		 */
		public string Get_hostName()
		{
			return this._HostName;
		}
		
		/**
		 * ホスト名
		 * 
		 * @property HostName
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string HostName
		{
			get { return this.Get_hostName(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.FtpInfo#_User
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _User;
		
		/**
		 * @method Get_user
		 * @ignore
		 * @return {string}
		 */
		public string Get_user()
		{
			return this._User;
		}
		
		/**
		 * ユーザ名
		 * 
		 * @property User
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string User
		{
			get { return this.Get_user(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.resources.FtpInfo#_Password
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _Password;
		
		/**
		 * @method Get_password
		 * @ignore
		 * @return {string}
		 */
		public string Get_password()
		{
			return this._Password;
		}
		
		/**
		 * パスワード
		 * 
		 * @property Password
		 * @type string
		 * @readOnly
		 * @public
		 */
		public string Password
		{
			get { return this.Get_password(); }
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {object} obj
		 */
		public FtpInfo(object obj)
		{
			this._HostName = ((string)((obj as System.Collections.Generic.Dictionary<string, object>)["HostName"]));
			this._User = ((string)((obj as System.Collections.Generic.Dictionary<string, object>)["User"]));
			this._Password = ((string)((obj as System.Collections.Generic.Dictionary<string, object>)["Password"]));
		}
		
	}
	
}
