using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Request Uri Too Long.
	/// </summary>
	public class HttpRequestUriTooLongException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpRequestUriTooLongException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "HTTPエラー。Request Uri Too Long." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
