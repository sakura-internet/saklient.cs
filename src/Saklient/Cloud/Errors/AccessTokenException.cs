using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。この操作は有効期限内のトークンが必要です。
	 */
	class AccessTokenException : HttpForbiddenException
	{
		
		/**
		 * @member saklient.cloud.errors.AccessTokenException#DefaultMessage
		 * @default "要求された操作は許可されていません。この操作は有効期限内のトークンが必要です。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作は許可されていません。この操作は有効期限内のトークンが必要です。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccessTokenException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
