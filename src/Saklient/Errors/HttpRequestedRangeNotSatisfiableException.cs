using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Requested Range Not Satisfiable.
	 */
	class HttpRequestedRangeNotSatisfiableException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpRequestedRangeNotSatisfiableException#DefaultMessage
		 * @default "HTTPエラー。Requested Range Not Satisfiable."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Requested Range Not Satisfiable.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpRequestedRangeNotSatisfiableException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
