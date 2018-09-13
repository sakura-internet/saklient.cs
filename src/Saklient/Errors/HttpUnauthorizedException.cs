using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>この操作は認証が必要です。IDまたはパスワードが誤っている可能性があります。
	/// </summary>
	public class HttpUnauthorizedException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpUnauthorizedException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "この操作は認証が必要です。IDまたはパスワードが誤っている可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
