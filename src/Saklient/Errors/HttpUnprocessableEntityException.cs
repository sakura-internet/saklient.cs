using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Unprocessable Entity.
	 */
	class HttpUnprocessableEntityException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpUnprocessableEntityException#DefaultMessage
		 * @default "HTTPエラー。Unprocessable Entity."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Unprocessable Entity.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpUnprocessableEntityException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
