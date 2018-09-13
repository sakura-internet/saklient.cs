using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作は許可されていません。この操作は有効期限内のトークンが必要です。
	/// </summary>
	public class AccessTokenException : HttpForbiddenException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public AccessTokenException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作は許可されていません。この操作は有効期限内のトークンが必要です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
