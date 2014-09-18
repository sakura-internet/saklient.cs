using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 要求されたHTTPメソッドは対応していません。
	 */
	public class HttpMethodNotAllowedException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpMethodNotAllowedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求されたHTTPメソッドは対応していません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
