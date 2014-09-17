using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Gateway Timeout.
	 */
	class HttpGatewayTimeoutException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpGatewayTimeoutException#DefaultMessage
		 * @default "HTTPエラー。Gateway Timeout."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Gateway Timeout.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpGatewayTimeoutException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
