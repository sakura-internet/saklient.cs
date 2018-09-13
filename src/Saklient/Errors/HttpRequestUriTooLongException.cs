using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Request Uri Too Long.
	/// </summary>
	public class HttpRequestUriTooLongException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpRequestUriTooLongException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Request Uri Too Long." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
