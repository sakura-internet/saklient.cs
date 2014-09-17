using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Length Required.
	 */
	class HttpLengthRequiredException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpLengthRequiredException#DefaultMessage
		 * @default "HTTPエラー。Length Required."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Length Required.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpLengthRequiredException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
