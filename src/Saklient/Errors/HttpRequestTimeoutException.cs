using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Request Timeout.
	 */
	class HttpRequestTimeoutException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpRequestTimeoutException#DefaultMessage
		 * @default "HTTPエラー。Request Timeout."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Request Timeout.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpRequestTimeoutException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
