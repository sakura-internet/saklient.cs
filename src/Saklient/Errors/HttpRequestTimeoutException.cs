using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Request Timeout.
	 */
	public class HttpRequestTimeoutException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpRequestTimeoutException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Request Timeout." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
