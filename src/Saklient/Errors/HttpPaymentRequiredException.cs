using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Payment Required.
	 */
	class HttpPaymentRequiredException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpPaymentRequiredException#DefaultMessage
		 * @default "HTTPエラー。Payment Required."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Payment Required.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpPaymentRequiredException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
