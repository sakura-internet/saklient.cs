using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Unsupported Media Type.
	 */
	class HttpUnsupportedMediaTypeException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpUnsupportedMediaTypeException#DefaultMessage
		 * @default "HTTPエラー。Unsupported Media Type."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Unsupported Media Type.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpUnsupportedMediaTypeException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
