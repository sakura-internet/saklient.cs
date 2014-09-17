using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Request Uri Too Long.
	 */
	class HttpRequestUriTooLongException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpRequestUriTooLongException#DefaultMessage
		 * @default "HTTPエラー。Request Uri Too Long."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Request Uri Too Long.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpRequestUriTooLongException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
