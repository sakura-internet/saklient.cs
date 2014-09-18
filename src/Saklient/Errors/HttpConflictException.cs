using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 要求された操作を行えません。現在の対象の状態では、この操作を受け付けできません。
	 */
	public class HttpConflictException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpConflictException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。現在の対象の状態では、この操作を受け付けできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
