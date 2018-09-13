using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Expectation Failed.
	/// </summary>
	public class HttpExpectationFailedException : HttpException
	{

        /// <summary>
        /// </summary>
        /// <param name="status" />
        /// <param name="code" />
        /// <param name="message" />
        public HttpExpectationFailedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Expectation Failed." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
