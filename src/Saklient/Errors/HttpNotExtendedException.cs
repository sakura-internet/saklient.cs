using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Not Extended.
	 */
	class HttpNotExtendedException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpNotExtendedException#DefaultMessage
		 * @default "HTTPエラー。Not Extended."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Not Extended.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpNotExtendedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
