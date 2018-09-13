using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Request Timeout.
	/// </summary>
	public class HttpRequestTimeoutException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpRequestTimeoutException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Request Timeout." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
