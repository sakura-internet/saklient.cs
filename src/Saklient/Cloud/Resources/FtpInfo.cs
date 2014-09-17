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
	class FtpInfo
	{
		
		/**
		 * @private
		 * @member saklient.cloud.resources.FtpInfo#_hostName
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _hostName;
		
		/**
		 * @method Get_hostName
		 * @ignore
		 * @return {string}
		 */
		public string Get_hostName()
		{
			return this._hostName;
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
		 * @member saklient.cloud.resources.FtpInfo#_user
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _user;
		
		/**
		 * @method Get_user
		 * @ignore
		 * @return {string}
		 */
		public string Get_user()
		{
			return this._user;
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
		 * @member saklient.cloud.resources.FtpInfo#_password
		 * @type string
		 * @internal
		 * @ignore
		 */
		internal string _password;
		
		/**
		 * @method Get_password
		 * @ignore
		 * @return {string}
		 */
		public string Get_password()
		{
			return this._password;
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
		 * @param {dynamic} obj
		 */
		public FtpInfo(dynamic obj)
		{
			Util.ValidateType(obj, "dynamic");
			this._hostName = ((string)(dynamic)((obj as System.Collections.Generic.Dictionary<string, object>)["HostName"]));
			this._user = ((string)(dynamic)((obj as System.Collections.Generic.Dictionary<string, object>)["User"]));
			this._password = ((string)(dynamic)((obj as System.Collections.Generic.Dictionary<string, object>)["Password"]));
		}
		
	}
	
}
