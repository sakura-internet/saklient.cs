using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Proxy Authentication Required.
	 */
	class HttpProxyAuthenticationRequiredException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpProxyAuthenticationRequiredException#DefaultMessage
		 * @default "HTTPエラー。Proxy Authentication Required."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Proxy Authentication Required.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpProxyAuthenticationRequiredException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
