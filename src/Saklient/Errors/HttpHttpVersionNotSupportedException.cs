using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Http Version Not Supported.
	 */
	public class HttpHttpVersionNotSupportedException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpHttpVersionNotSupportedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Http Version Not Supported." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
