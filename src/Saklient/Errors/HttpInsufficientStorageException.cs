using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Insufficient Storage.
	 */
	public class HttpInsufficientStorageException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpInsufficientStorageException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Insufficient Storage." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
