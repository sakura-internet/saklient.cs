using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Request Entity Too Large.
	 */
	public class HttpRequestEntityTooLargeException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpRequestEntityTooLargeException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Request Entity Too Large." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
