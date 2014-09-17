using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Http Version Not Supported.
	 */
	class HttpHttpVersionNotSupportedException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpHttpVersionNotSupportedException#DefaultMessage
		 * @default "HTTPエラー。Http Version Not Supported."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Http Version Not Supported.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpHttpVersionNotSupportedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
