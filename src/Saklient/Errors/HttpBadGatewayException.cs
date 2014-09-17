using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Bad Gateway.
	 */
	class HttpBadGatewayException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpBadGatewayException#DefaultMessage
		 * @default "HTTPエラー。Bad Gateway."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Bad Gateway.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpBadGatewayException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
