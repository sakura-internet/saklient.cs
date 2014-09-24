using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Proxy Authentication Required.
	/// </summary>
	public class HttpProxyAuthenticationRequiredException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpProxyAuthenticationRequiredException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Proxy Authentication Required." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
