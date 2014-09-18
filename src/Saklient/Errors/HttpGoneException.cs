using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Gone.
	 */
	public class HttpGoneException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpGoneException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Gone." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
