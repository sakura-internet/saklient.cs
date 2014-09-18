using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Not Extended.
	 */
	public class HttpNotExtendedException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpNotExtendedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Not Extended." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
