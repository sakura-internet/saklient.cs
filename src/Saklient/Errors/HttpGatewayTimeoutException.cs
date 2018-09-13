using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Gateway Timeout.
	/// </summary>
	public class HttpGatewayTimeoutException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpGatewayTimeoutException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Gateway Timeout." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
