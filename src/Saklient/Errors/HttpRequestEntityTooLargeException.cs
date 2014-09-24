using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Request Entity Too Large.
	/// </summary>
	public class HttpRequestEntityTooLargeException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpRequestEntityTooLargeException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Request Entity Too Large." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
