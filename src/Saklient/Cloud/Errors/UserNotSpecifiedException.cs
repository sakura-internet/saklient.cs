using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作は許可されていません。このAPIはユーザを特定できる認証方法でアクセスする必要があります。
	/// </summary>
	public class UserNotSpecifiedException : HttpForbiddenException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public UserNotSpecifiedException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作は許可されていません。このAPIはユーザを特定できる認証方法でアクセスする必要があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
