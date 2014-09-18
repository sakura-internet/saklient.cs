using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * HTTPエラー。Unsupported Media Type.
	 */
	public class HttpUnsupportedMediaTypeException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpUnsupportedMediaTypeException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Unsupported Media Type." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
