using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Locked.
	 */
	public class HttpLockedException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpLockedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Locked." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
