using Util = Saklient.Util;

namespace Saklient.Cloud.Resources
{

	/// <summary>FTPサーバのアカウント情報。
	/// </summary>
	public class FtpInfo
	{
		
		internal string _HostName;
		
		public string Get_hostName()
		{
			return this._HostName;
		}
		
		/// <summary>ホスト名
		/// </summary>
		public string HostName
		{
			get { return this.Get_hostName(); }
		}
		
		internal string _User;
		
		public string Get_user()
		{
			return this._User;
		}
		
		/// <summary>ユーザ名
		/// </summary>
		public string User
		{
			get { return this.Get_user(); }
		}
		
		internal string _Password;
		
		public string Get_password()
		{
			return this._Password;
		}
		
		/// <summary>パスワード
		/// </summary>
		public string Password
		{
			get { return this.Get_password(); }
		}
		
		public FtpInfo(object obj)
		{
			this._HostName = ((string)((obj as System.Collections.Generic.Dictionary<string, object>)["HostName"]));
			this._User = ((string)((obj as System.Collections.Generic.Dictionary<string, object>)["User"]));
			this._Password = ((string)((obj as System.Collections.Generic.Dictionary<string, object>)["Password"]));
		}
		
	}
	
}
