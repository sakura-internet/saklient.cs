using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Proxy Authentication Required.
	 */
	public class HttpProxyAuthenticationRequiredException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpProxyAuthenticationRequiredException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Proxy Authentication Required." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
