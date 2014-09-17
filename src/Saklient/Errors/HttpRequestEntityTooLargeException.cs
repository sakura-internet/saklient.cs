using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Request Entity Too Large.
	 */
	class HttpRequestEntityTooLargeException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpRequestEntityTooLargeException#DefaultMessage
		 * @default "HTTPエラー。Request Entity Too Large."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Request Entity Too Large.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpRequestEntityTooLargeException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
