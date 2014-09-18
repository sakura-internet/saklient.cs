using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Not Implemented.
	 */
	public class HttpNotImplementedException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpNotImplementedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Not Implemented." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
