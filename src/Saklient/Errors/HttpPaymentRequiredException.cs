using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Payment Required.
	/// </summary>
	public class HttpPaymentRequiredException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpPaymentRequiredException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Payment Required." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
