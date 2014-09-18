using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。この操作は有効期限内のトークンが必要です。
	 */
	public class AccessTokenException : HttpForbiddenException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccessTokenException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。この操作は有効期限内のトークンが必要です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
