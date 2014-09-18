using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Bad Gateway.
	 */
	public class HttpBadGatewayException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpBadGatewayException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Bad Gateway." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
