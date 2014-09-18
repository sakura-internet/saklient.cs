using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Expectation Failed.
	 */
	public class HttpExpectationFailedException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpExpectationFailedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Expectation Failed." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
