using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Request Uri Too Long.
	 */
	public class HttpRequestUriTooLongException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpRequestUriTooLongException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Request Uri Too Long." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
