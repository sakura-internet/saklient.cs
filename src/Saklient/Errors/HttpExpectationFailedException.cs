using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Expectation Failed.
	 */
	class HttpExpectationFailedException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpExpectationFailedException#DefaultMessage
		 * @default "HTTPエラー。Expectation Failed."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Expectation Failed.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpExpectationFailedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
