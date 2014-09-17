using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Not Implemented.
	 */
	class HttpNotImplementedException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpNotImplementedException#DefaultMessage
		 * @default "HTTPエラー。Not Implemented."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Not Implemented.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpNotImplementedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
