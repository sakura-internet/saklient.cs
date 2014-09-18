using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 要求された操作は許可されていません。権限エラー。
	 */
	public class HttpForbiddenException : HttpException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpForbiddenException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。権限エラー。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
