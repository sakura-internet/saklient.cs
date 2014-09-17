using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Insufficient Storage.
	 */
	class HttpInsufficientStorageException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpInsufficientStorageException#DefaultMessage
		 * @default "HTTPエラー。Insufficient Storage."
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "HTTPエラー。Insufficient Storage.";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpInsufficientStorageException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
