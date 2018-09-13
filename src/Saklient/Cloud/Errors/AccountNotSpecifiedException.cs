using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作は許可されていません。このAPIはアカウントを特定できる認証方法でアクセスする必要があります。
	/// </summary>
	public class AccountNotSpecifiedException : HttpForbiddenException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public AccountNotSpecifiedException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作は許可されていません。このAPIはアカウントを特定できる認証方法でアクセスする必要があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
