using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Precondition Failed.
	 */
	class HttpPreconditionFailedException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpPreconditionFailedException#DefaultMessage
		 * @default "HTTPエラー。Precondition Failed."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Precondition Failed.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpPreconditionFailedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
